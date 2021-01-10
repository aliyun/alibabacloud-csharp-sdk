// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListMqSofamqClusterResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListMqSofamqClusterResponseBodyData> Data { get; set; }
        public class ListMqSofamqClusterResponseBodyData : TeaModel {
            [NameInMap("Appkey")]
            [Validation(Required=false)]
            public string Appkey { get; set; }

            [NameInMap("Cluster")]
            [Validation(Required=false)]
            public string Cluster { get; set; }

            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            [NameInMap("DeployMode")]
            [Validation(Required=false)]
            public string DeployMode { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("LdcMode")]
            [Validation(Required=false)]
            public string LdcMode { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

        }

    }

}
