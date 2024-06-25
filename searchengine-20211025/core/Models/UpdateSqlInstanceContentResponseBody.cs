// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class UpdateSqlInstanceContentResponseBody : TeaModel {
        /// <summary>
        /// id of request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// InstanceVersionVO
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateSqlInstanceContentResponseBodyResult Result { get; set; }
        public class UpdateSqlInstanceContentResponseBodyResult : TeaModel {
            [NameInMap("combineParams")]
            [Validation(Required=false)]
            public string CombineParams { get; set; }

            [NameInMap("comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("dynamicParams")]
            [Validation(Required=false)]
            public string DynamicParams { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            [NameInMap("kvpairs")]
            [Validation(Required=false)]
            public string Kvpairs { get; set; }

            [NameInMap("relatedTemplateId")]
            [Validation(Required=false)]
            public long? RelatedTemplateId { get; set; }

            [NameInMap("staticParams")]
            [Validation(Required=false)]
            public string StaticParams { get; set; }

            [NameInMap("templateParams")]
            [Validation(Required=false)]
            public string TemplateParams { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

    }

}
