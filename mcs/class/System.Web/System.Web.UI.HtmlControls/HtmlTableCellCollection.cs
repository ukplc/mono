/*	System.Web.UI.HtmlControls
*	Authors
*		Leen Toelen (toelen@hotmail.com)
*/

using System;
using System.Web;
using System.Web.UI;

namespace System.Web.UI.HtmlControls{
	public sealed class HtmlTableCellCollection : ICollection {
		private HtmlTableRow _owner;
		
		internal HtmlTableCellCollection(HtmlTableRow owner){
			_owner = owner;
		}
		
		public void Add(HtmlTableCell cell){
			Insert(-1, cell);
		}
		
		public void Clear(){
			if (_owner.HasConrols) _owner.Conrols.Clear;
		}
		
		public void CopyTo(Array array, int index){
			IEnumerator i = GetEnumerator;
			while(i.MoveNext){
				array.SetValue(i.Current, index++);
			}
		}
		
		public IEnumerator GetEnumerator(){
			return _owner.Controls.GetEnumerator;
		}
		
		public void Insert(int index, HtmlTableCell cell){
			_owner.Controls.AddAt(index,cell);
		}
		
		public void Remove(HtmlTableCell cell){
			_owner.Controls.Remove(cell);
		}
		
		public void RemoveAt(int index){
			_owner.Controls.RemoveAt(index);
		}
		
		public int Count {
			get{
				if (_owner.HasConrols) return _owner.Controls.Count;
				return 0;
			}
		}
		
		public bool IsReadOnly {
			get{
				return false;
			}
		}
		
		public bool IsSynchronized {
			get{
				return false;
			}
		}
		
		public HtmlTableRow this[int index] {
			get{
				return (HtmlTableCell) _owner.Controls[index];
			}
		}
		
		public object SyncRoot {};
		
	} // end of System.Web.UI.HtmlControls.HtmlTableCellCollection
	
}

