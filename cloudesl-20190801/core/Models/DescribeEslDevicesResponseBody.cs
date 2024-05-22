// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudesl20190801.Models
{
    public class DescribeEslDevicesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("EslDevices")]
        [Validation(Required=false)]
        public DescribeEslDevicesResponseBodyEslDevices EslDevices { get; set; }
        public class DescribeEslDevicesResponseBodyEslDevices : TeaModel {
            [NameInMap("EslDeviceInfo")]
            [Validation(Required=false)]
            public List<DescribeEslDevicesResponseBodyEslDevicesEslDeviceInfo> EslDeviceInfo { get; set; }
            public class DescribeEslDevicesResponseBodyEslDevicesEslDeviceInfo : TeaModel {
                [NameInMap("BatteryLevel")]
                [Validation(Required=false)]
                public int? BatteryLevel { get; set; }

                [NameInMap("BeBind")]
                [Validation(Required=false)]
                public bool? BeBind { get; set; }

                [NameInMap("CompanyId")]
                [Validation(Required=false)]
                public string CompanyId { get; set; }

                [NameInMap("ConnectAp")]
                [Validation(Required=false)]
                public string ConnectAp { get; set; }

                [NameInMap("EslBarCode")]
                [Validation(Required=false)]
                public string EslBarCode { get; set; }

                [NameInMap("EslStatus")]
                [Validation(Required=false)]
                public string EslStatus { get; set; }

                [NameInMap("ItemActionPrice")]
                [Validation(Required=false)]
                public int? ItemActionPrice { get; set; }

                [NameInMap("ItemBarCode")]
                [Validation(Required=false)]
                public string ItemBarCode { get; set; }

                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public long? ItemId { get; set; }

                [NameInMap("ItemPriceUnit")]
                [Validation(Required=false)]
                public string ItemPriceUnit { get; set; }

                [NameInMap("ItemTitle")]
                [Validation(Required=false)]
                public string ItemTitle { get; set; }

                [NameInMap("LastCommunicateTime")]
                [Validation(Required=false)]
                public string LastCommunicateTime { get; set; }

                [NameInMap("Mac")]
                [Validation(Required=false)]
                public string Mac { get; set; }

                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                [NameInMap("PositionCode")]
                [Validation(Required=false)]
                public string PositionCode { get; set; }

                [NameInMap("ScreenHeight")]
                [Validation(Required=false)]
                public int? ScreenHeight { get; set; }

                [NameInMap("ScreenWidth")]
                [Validation(Required=false)]
                public int? ScreenWidth { get; set; }

                [NameInMap("ShelfCode")]
                [Validation(Required=false)]
                public string ShelfCode { get; set; }

                [NameInMap("StoreId")]
                [Validation(Required=false)]
                public string StoreId { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Vendor")]
                [Validation(Required=false)]
                public string Vendor { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
