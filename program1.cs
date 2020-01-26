public class Program
{
	public static void Main()
	{
		int i,n;
		Console.WriteLine("Enter the input array size");
		n=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Size is"+n);
		int[] a= new int[n];
		Console.WriteLine("Enter the input numbers");
		for(i=0;i<n;i++)
		{
			a[i]=Convert.ToInt32(Console.ReadLine());
		}
			for(i=0;i<n;i++)
			{
				if(a[i]%2==0)
					a[i]--;
				else
					a[i]++;
			}
		for(i=0;i<n;i++)
			{
				Console.WriteLine(a[i]);
			}
	}
}
