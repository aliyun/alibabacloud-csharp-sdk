// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckItemWarningMachineResponseBody : TeaModel {
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListCheckItemWarningMachineResponseBodyList> List { get; set; }
        public class ListCheckItemWarningMachineResponseBodyList : TeaModel {
            [NameInMap("AuthVersion")]
            [Validation(Required=false)]
            public int? AuthVersion { get; set; }

            [NameInMap("Bind")]
            [Validation(Required=false)]
            public bool? Bind { get; set; }

            [NameInMap("FixList")]
            [Validation(Required=false)]
            public List<ListCheckItemWarningMachineResponseBodyListFixList> FixList { get; set; }
            public class ListCheckItemWarningMachineResponseBodyListFixList : TeaModel {
                [NameInMap("RiskId")]
                [Validation(Required=false)]
                public long? RiskId { get; set; }

                [NameInMap("RiskName")]
                [Validation(Required=false)]
                public string RiskName { get; set; }

            }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            [NameInMap("PortOpen")]
            [Validation(Required=false)]
            public bool? PortOpen { get; set; }

            [NameInMap("Prompt")]
            [Validation(Required=false)]
            public string Prompt { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            [NameInMap("WarningRiskList")]
            [Validation(Required=false)]
            public List<ListCheckItemWarningMachineResponseBodyListWarningRiskList> WarningRiskList { get; set; }
            public class ListCheckItemWarningMachineResponseBodyListWarningRiskList : TeaModel {
                [NameInMap("RiskId")]
                [Validation(Required=false)]
                public long? RiskId { get; set; }

                [NameInMap("RiskName")]
                [Validation(Required=false)]
                public string RiskName { get; set; }

            }

        }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListCheckItemWarningMachineResponseBodyPageInfo PageInfo { get; set; }
        public class ListCheckItemWarningMachineResponseBodyPageInfo : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
