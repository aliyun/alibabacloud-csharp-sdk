// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class GetBaseTemplateListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TemplateList")]
        [Validation(Required=false)]
        public List<GetBaseTemplateListResponseBodyTemplateList> TemplateList { get; set; }
        public class GetBaseTemplateListResponseBodyTemplateList : TeaModel {
            [NameInMap("DbTypeName")]
            [Validation(Required=false)]
            public string DbTypeName { get; set; }

            [NameInMap("TemplateContent")]
            [Validation(Required=false)]
            public string TemplateContent { get; set; }

            [NameInMap("SqlTypeName")]
            [Validation(Required=false)]
            public string SqlTypeName { get; set; }

            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            [NameInMap("TemplateState")]
            [Validation(Required=false)]
            public string TemplateState { get; set; }

        }

    }

}
