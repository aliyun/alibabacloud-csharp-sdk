// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudesl20200201.Models
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
        public List<DescribeEslDevicesResponseBodyEslDevices> EslDevices { get; set; }
        public class DescribeEslDevicesResponseBodyEslDevices : TeaModel {
            [NameInMap("BatteryLevel")]
            [Validation(Required=false)]
            public int? BatteryLevel { get; set; }

            [NameInMap("EslBarCode")]
            [Validation(Required=false)]
            public string EslBarCode { get; set; }

            [NameInMap("EslSignal")]
            [Validation(Required=false)]
            public int? EslSignal { get; set; }

            [NameInMap("EslStatus")]
            [Validation(Required=false)]
            public string EslStatus { get; set; }

            [NameInMap("LastCommunicateTime")]
            [Validation(Required=false)]
            public string LastCommunicateTime { get; set; }

            [NameInMap("LayoutId")]
            [Validation(Required=false)]
            public string LayoutId { get; set; }

            [NameInMap("LayoutName")]
            [Validation(Required=false)]
            public string LayoutName { get; set; }

            [NameInMap("Mac")]
            [Validation(Required=false)]
            public string Mac { get; set; }

            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            [NameInMap("ScreenHeight")]
            [Validation(Required=false)]
            public int? ScreenHeight { get; set; }

            [NameInMap("ScreenWidth")]
            [Validation(Required=false)]
            public int? ScreenWidth { get; set; }

            [NameInMap("StoreId")]
            [Validation(Required=false)]
            public string StoreId { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("TypeEncode")]
            [Validation(Required=false)]
            public string TypeEncode { get; set; }

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
