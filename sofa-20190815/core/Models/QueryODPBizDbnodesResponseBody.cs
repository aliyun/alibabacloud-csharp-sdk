// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryODPBizDbnodesResponseBody : TeaModel {
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
        public List<QueryODPBizDbnodesResponseBodyData> Data { get; set; }
        public class QueryODPBizDbnodesResponseBodyData : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DbInstanceId")]
            [Validation(Required=false)]
            public string DbInstanceId { get; set; }

            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            [NameInMap("Imported")]
            [Validation(Required=false)]
            public bool? Imported { get; set; }

            [NameInMap("NetMode")]
            [Validation(Required=false)]
            public string NetMode { get; set; }

            [NameInMap("Port")]
            [Validation(Required=false)]
            public long? Port { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

    }

}
