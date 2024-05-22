// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudesl20190801.Models
{
    public class DescribeAlarmsResponseBody : TeaModel {
        [NameInMap("Alarms")]
        [Validation(Required=false)]
        public DescribeAlarmsResponseBodyAlarms Alarms { get; set; }
        public class DescribeAlarmsResponseBodyAlarms : TeaModel {
            [NameInMap("AlarmInfo")]
            [Validation(Required=false)]
            public List<DescribeAlarmsResponseBodyAlarmsAlarmInfo> AlarmInfo { get; set; }
            public class DescribeAlarmsResponseBodyAlarmsAlarmInfo : TeaModel {
                [NameInMap("AlarmId")]
                [Validation(Required=false)]
                public string AlarmId { get; set; }

                [NameInMap("AlarmStatus")]
                [Validation(Required=false)]
                public string AlarmStatus { get; set; }

                [NameInMap("AlarmTime")]
                [Validation(Required=false)]
                public string AlarmTime { get; set; }

                [NameInMap("AlarmType")]
                [Validation(Required=false)]
                public string AlarmType { get; set; }

                [NameInMap("CompanyId")]
                [Validation(Required=false)]
                public string CompanyId { get; set; }

                [NameInMap("DealTime")]
                [Validation(Required=false)]
                public string DealTime { get; set; }

                [NameInMap("DealUserId")]
                [Validation(Required=false)]
                public long? DealUserId { get; set; }

                [NameInMap("DeviceBarCode")]
                [Validation(Required=false)]
                public string DeviceBarCode { get; set; }

                [NameInMap("DeviceMac")]
                [Validation(Required=false)]
                public string DeviceMac { get; set; }

                [NameInMap("DeviceType")]
                [Validation(Required=false)]
                public string DeviceType { get; set; }

                [NameInMap("ErrorType")]
                [Validation(Required=false)]
                public string ErrorType { get; set; }

                [NameInMap("ItemBarCode")]
                [Validation(Required=false)]
                public string ItemBarCode { get; set; }

                [NameInMap("ItemTitle")]
                [Validation(Required=false)]
                public string ItemTitle { get; set; }

                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                [NameInMap("StoreId")]
                [Validation(Required=false)]
                public string StoreId { get; set; }

                [NameInMap("Vendor")]
                [Validation(Required=false)]
                public string Vendor { get; set; }

            }

        }

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
