// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSuspEventDetailResponseBody : TeaModel {
        [NameInMap("DataSource")]
        [Validation(Required=false)]
        public string DataSource { get; set; }

        [NameInMap("EventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        [NameInMap("InternetIp")]
        [Validation(Required=false)]
        public string InternetIp { get; set; }

        [NameInMap("IntranetIp")]
        [Validation(Required=false)]
        public string IntranetIp { get; set; }

        [NameInMap("LastTime")]
        [Validation(Required=false)]
        public string LastTime { get; set; }

        [NameInMap("OperateMsg")]
        [Validation(Required=false)]
        public string OperateMsg { get; set; }

        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        [NameInMap("CanBeDealOnLine")]
        [Validation(Required=false)]
        public bool? CanBeDealOnLine { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("EventTypeDesc")]
        [Validation(Required=false)]
        public string EventTypeDesc { get; set; }

        [NameInMap("EventDesc")]
        [Validation(Required=false)]
        public string EventDesc { get; set; }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("EventStatus")]
        [Validation(Required=false)]
        public string EventStatus { get; set; }

        [NameInMap("SaleVersion")]
        [Validation(Required=false)]
        public string SaleVersion { get; set; }

        [NameInMap("OperateErrorCode")]
        [Validation(Required=false)]
        public string OperateErrorCode { get; set; }

        [NameInMap("SasId")]
        [Validation(Required=false)]
        public string SasId { get; set; }

        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public int? Id { get; set; }

        [NameInMap("Details")]
        [Validation(Required=false)]
        public List<DescribeSuspEventDetailResponseBodyDetails> Details { get; set; }
        public class DescribeSuspEventDetailResponseBodyDetails : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            [NameInMap("InfoType")]
            [Validation(Required=false)]
            public string InfoType { get; set; }

            [NameInMap("NameDisplay")]
            [Validation(Required=false)]
            public string NameDisplay { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
