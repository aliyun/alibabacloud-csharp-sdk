// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class QueryFaceImageTemplateResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryFaceImageTemplateResponseBodyData Data { get; set; }
        public class QueryFaceImageTemplateResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<QueryFaceImageTemplateResponseBodyDataElements> Elements { get; set; }
            public class QueryFaceImageTemplateResponseBodyDataElements : TeaModel {
                public string CreateTime { get; set; }
                public string UpdateTime { get; set; }
                public string UserId { get; set; }
                public string TemplateId { get; set; }
                public string TemplateURL { get; set; }
            }
        };

    }

}
