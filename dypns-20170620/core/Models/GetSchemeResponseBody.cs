// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypns20170620.Models
{
    public class GetSchemeResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSchemeResponseBodyData Data { get; set; }
        public class GetSchemeResponseBodyData : TeaModel {
            [NameInMap("AuditDesc")]
            [Validation(Required=false)]
            public string AuditDesc { get; set; }

            [NameInMap("AuditTime")]
            [Validation(Required=false)]
            public long? AuditTime { get; set; }

            [NameInMap("BusinessTypeList")]
            [Validation(Required=false)]
            public List<int?> BusinessTypeList { get; set; }

            [NameInMap("CompanyId")]
            [Validation(Required=false)]
            public long? CompanyId { get; set; }

            [NameInMap("CycleList")]
            [Validation(Required=false)]
            public List<string> CycleList { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("IndustryId")]
            [Validation(Required=false)]
            public string IndustryId { get; set; }

            [NameInMap("ScenesList")]
            [Validation(Required=false)]
            public List<GetSchemeResponseBodyDataScenesList> ScenesList { get; set; }
            public class GetSchemeResponseBodyDataScenesList : TeaModel {
                [NameInMap("ScenesId")]
                [Validation(Required=false)]
                public long? ScenesId { get; set; }

                [NameInMap("ScenesName")]
                [Validation(Required=false)]
                public string ScenesName { get; set; }

            }

            [NameInMap("SchemeId")]
            [Validation(Required=false)]
            public long? SchemeId { get; set; }

            [NameInMap("SchemeName")]
            [Validation(Required=false)]
            public string SchemeName { get; set; }

            [NameInMap("SchemeType")]
            [Validation(Required=false)]
            public int? SchemeType { get; set; }

            [NameInMap("Statement")]
            [Validation(Required=false)]
            public string Statement { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
