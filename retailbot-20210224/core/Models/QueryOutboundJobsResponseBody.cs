// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class QueryOutboundJobsResponseBody : TeaModel {
        /// <summary>
        /// BaseResult<List<OutboundJobDTO>>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public QueryOutboundJobsResponseBodyContent Content { get; set; }
        public class QueryOutboundJobsResponseBodyContent : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryOutboundJobsResponseBodyContentData> Data { get; set; }
            public class QueryOutboundJobsResponseBodyContentData : TeaModel {
                public string AppCode { get; set; }
                public string AppId { get; set; }
                public string Config { get; set; }
                public string CrowdConfig { get; set; }
                public int? CrowdType { get; set; }
                public string EndTime { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModified { get; set; }
                public long? Id { get; set; }
                public string JobName { get; set; }
                public string RunConfig { get; set; }
                public int? RunType { get; set; }
                public string SaasId { get; set; }
                public long? ShopId { get; set; }
                public string StartTime { get; set; }
                public int? Status { get; set; }
                public long? TenantId { get; set; }
                public string Version { get; set; }
            }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }
        };

        [NameInMap("First")]
        [Validation(Required=false)]
        public bool? First { get; set; }

        [NameInMap("Last")]
        [Validation(Required=false)]
        public bool? Last { get; set; }

    }

}
