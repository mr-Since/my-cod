namespace Lab1V2Library
{
    public abstract class V2Data{
        public string Key { get; set;}
        public DateOnly Date { get; set;}
        public V2Data(string key, DateOnly date){
            Key = key;
            Date = date;
        }
        public abstract int xCount { get;}
        public abstract (double, double) MinMaxMagnitude { get;}
        public abstract string ToLongString(string format);
        public override string ToString(){
            return $"Key: {Key}, Date: {Date}";
        }
    }
}
