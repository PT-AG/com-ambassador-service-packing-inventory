using Com.Danliris.Service.Packing.Inventory.Application.CommonViewModelObjectProperties;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Com.Danliris.Service.Packing.Inventory.Test.Models.CommonViewModelObjectProperties
{
  public  class MaterialTest
    {
        [Fact]
        public void should_Success_Instantiate_Material()
        {

            Material material = new Material()
            {
                Id = 1,
                Code = "Code",
                Name = "Name"
            };

            Assert.Equal(1, material.Id);
            Assert.Equal("Code", material.Code);
            Assert.Equal("Name", material.Name);
        }
    }
}
