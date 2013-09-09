#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2013 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.

#endregion

using System;
using NUnit.Framework;

using OpenTK;

// see README-Tests.txt for information and instructions

namespace Test.OpenTK
{

	[TestFixture]
	public class A00_Math
	{
        [Test]
        public void T00_Vector2() {
            Assert.AreEqual(
                new Vector2(11.0f, 23.0f),
                new Vector2(1.0f, 3.0f) + new Vector2(10.0f, 20.0f),
                "Vector2 Add");
            Assert.AreEqual(
                new Vector2(10.0f, 30.0f),
                new Vector2(1.0f, 3.0f) * 10.0f,
                "Vector2 Scalar Multiply");
        }

        [Test]
        public void T00_Vector3 () {            
            Assert.AreEqual(
                new Vector3(11.0f, 23.0f, 62.0f),
                new Vector3(1.0f, 3.0f, 12.0f) + new Vector3(10.0f, 20.0f, 50.0f),
                "Vector3 Add");
            Assert.AreEqual(
                new Vector3(10.0f, 30.0f, 40.0f),
                new Vector3(1.0f, 3.0f, 4.0f) * 10.0f,
                "Vector3 Scalar Multiply");
		}

        [Test]
        public void T01_Matrix3() {
            // TODO.. put some stuff here...
        }
	}

	[TestFixture]
	public class ZZ_TODO
	{
		// place tests here which someone should write someday

		[Test]
		public void T00_WindowCreate() {
		}

	}


}

