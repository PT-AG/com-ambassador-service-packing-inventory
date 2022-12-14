using Com.Danliris.Service.Packing.Inventory.Application.ToBeRefactored.DyeingPrintingAreaOutput.Warehouse;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xunit;

namespace Com.Danliris.Service.Packing.Inventory.Test.DataUtils.Warehouse.Output
{
    public class IndexViewModelDataUtil
    {
        private IndexViewModel IndexViewModel
        {
            get
            {
                return new IndexViewModel()
                {
                    Id = 1,
                    Area = "GUDANG JADI",
                    BonNo = "TR.GJ.20.001",
                    Date = DateTimeOffset.UtcNow,
                    DestinationArea = "SHIPPING",
                    HasNextAreaDocument = false,
                    Shift = "PAGI",
                    Group = "A"
                };
            }
        }

        [Fact]
        public void Should_ValidatorId_Success()
        {
            var dataUtil = IndexViewModel;
            Assert.NotEqual(0, dataUtil.Id);
        }

        [Fact]
        public void Should_ValidatorArea_Success()
        {
            var dataUtil = IndexViewModel;
            Assert.NotNull(dataUtil.Area);
        }

        [Fact]
        public void Should_ValidatorBonNo_Success()
        {
            var dataUtil = IndexViewModel;
            Assert.NotNull(dataUtil.BonNo);
        }

        [Fact]
        public void Should_ValidatorDate_Success()
        {
            var dataUtil = IndexViewModel;
            Debug.Assert((dataUtil.Date - DateTimeOffset.UtcNow) < TimeSpan.FromSeconds(2));
        }

        [Fact]
        public void Should_ValidatorDestinationArea_Success()
        {
            var dataUtil = IndexViewModel;
            Assert.NotNull(dataUtil.DestinationArea);
        }

        [Fact]
        public void Should_ValidatorHasNextAreaDocument_Success()
        {
            var dataUtil = IndexViewModel;
            Assert.False(dataUtil.HasNextAreaDocument);
        }

        [Fact]
        public void Should_ValidatorShift_Success()
        {
            var dataUtil = IndexViewModel;
            Assert.NotNull(dataUtil.Shift);
        }

        [Fact]
        public void Should_ValidatorGroup_Success()
        {
            var dataUtil = IndexViewModel;
            Assert.NotNull(dataUtil.Group);
        }
    }
}
