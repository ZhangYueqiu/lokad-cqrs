﻿namespace Lokad.Cqrs
{
	public interface IStorageContainer
	{
		IStorageContainer GetContainer(string name);
		IStorageItem GetItem(string name);

		IStorageContainer Create();
		void Delete();
		bool Exists();

		string FullPath { get; }
	}
}