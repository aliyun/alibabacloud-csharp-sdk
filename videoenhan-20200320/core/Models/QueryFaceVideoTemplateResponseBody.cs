// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class QueryFaceVideoTemplateResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryFaceVideoTemplateResponseBodyData Data { get; set; }
        public class QueryFaceVideoTemplateResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<QueryFaceVideoTemplateResponseBodyDataElements> Elements { get; set; }
            public class QueryFaceVideoTemplateResponseBodyDataElements : TeaModel {
                public string CreateTime { get; set; }
                public string UpdateTime { get; set; }
                public string UserId { get; set; }
                public string TemplateId { get; set; }
                public string TemplateURL { get; set; }
            }
        };

    }

}
