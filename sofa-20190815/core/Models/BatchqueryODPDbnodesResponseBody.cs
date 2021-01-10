// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class BatchqueryODPDbnodesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<BatchqueryODPDbnodesResponseBodyData> Data { get; set; }
        public class BatchqueryODPDbnodesResponseBodyData : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("EnvTenant")]
            [Validation(Required=false)]
            public string EnvTenant { get; set; }

            [NameInMap("OverMaxRetryCount")]
            [Validation(Required=false)]
            public bool? OverMaxRetryCount { get; set; }

            [NameInMap("ProbeFailMsg")]
            [Validation(Required=false)]
            public string ProbeFailMsg { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            [NameInMap("LastProbeTime")]
            [Validation(Required=false)]
            public string LastProbeTime { get; set; }

            [NameInMap("DatacenterVipMapping")]
            [Validation(Required=false)]
            public List<BatchqueryODPDbnodesResponseBodyDataDatacenterVipMapping> DatacenterVipMapping { get; set; }
            public class BatchqueryODPDbnodesResponseBodyDataDatacenterVipMapping : TeaModel {
                [NameInMap("DataCenter")]
                [Validation(Required=false)]
                public string DataCenter { get; set; }

                [NameInMap("DbUrl")]
                [Validation(Required=false)]
                public string DbUrl { get; set; }

            }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            [NameInMap("EnvMode")]
            [Validation(Required=false)]
            public string EnvMode { get; set; }

            [NameInMap("NetMode")]
            [Validation(Required=false)]
            public string NetMode { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("CheckDbStatus")]
            [Validation(Required=false)]
            public bool? CheckDbStatus { get; set; }

            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
