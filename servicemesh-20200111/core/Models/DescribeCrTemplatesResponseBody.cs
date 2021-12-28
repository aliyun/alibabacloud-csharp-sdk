// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeCrTemplatesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Templates")]
        [Validation(Required=false)]
        public List<DescribeCrTemplatesResponseBodyTemplates> Templates { get; set; }
        public class DescribeCrTemplatesResponseBodyTemplates : TeaModel {
            [NameInMap("ChineseName")]
            [Validation(Required=false)]
            public string ChineseName { get; set; }

            [NameInMap("EnglishName")]
            [Validation(Required=false)]
            public string EnglishName { get; set; }

            [NameInMap("Yaml")]
            [Validation(Required=false)]
            public string Yaml { get; set; }

        }

    }

}
