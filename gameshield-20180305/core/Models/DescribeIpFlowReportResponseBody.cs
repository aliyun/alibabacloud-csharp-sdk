// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeIpFlowReportResponseBody : TeaModel {
        [NameInMap("IpFlowReportList")]
        [Validation(Required=false)]
        public List<DescribeIpFlowReportResponseBodyIpFlowReportList> IpFlowReportList { get; set; }
        public class DescribeIpFlowReportResponseBodyIpFlowReportList : TeaModel {
            [NameInMap("Outpps")]
            [Validation(Required=false)]
            public string Outpps { get; set; }

            [NameInMap("Cps")]
            [Validation(Required=false)]
            public string Cps { get; set; }

            [NameInMap("Inkbps")]
            [Validation(Required=false)]
            public string Inkbps { get; set; }

            [NameInMap("Inpps")]
            [Validation(Required=false)]
            public string Inpps { get; set; }

            [NameInMap("Inbps")]
            [Validation(Required=false)]
            public string Inbps { get; set; }

            [NameInMap("Conns")]
            [Validation(Required=false)]
            public bool? Conns { get; set; }

            [NameInMap("Inpkts")]
            [Validation(Required=false)]
            public string Inpkts { get; set; }

            [NameInMap("Inbytes")]
            [Validation(Required=false)]
            public string Inbytes { get; set; }

            [NameInMap("Outbytes")]
            [Validation(Required=false)]
            public string Outbytes { get; set; }

            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            [NameInMap("Actconns")]
            [Validation(Required=false)]
            public string Actconns { get; set; }

            [NameInMap("Outbps")]
            [Validation(Required=false)]
            public string Outbps { get; set; }

            [NameInMap("Outpkts")]
            [Validation(Required=false)]
            public string Outpkts { get; set; }

            [NameInMap("Vip")]
            [Validation(Required=false)]
            public string Vip { get; set; }

            [NameInMap("Qtime")]
            [Validation(Required=false)]
            public string Qtime { get; set; }

            [NameInMap("Outkbps")]
            [Validation(Required=false)]
            public string Outkbps { get; set; }

            [NameInMap("Inactconns")]
            [Validation(Required=false)]
            public string Inactconns { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PromptInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> PromptInfo { get; set; }

    }

}
