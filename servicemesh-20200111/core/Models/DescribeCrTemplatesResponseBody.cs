// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeCrTemplatesResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The common YAML templates for the specified type of Istio resource.
        /// </summary>
        [NameInMap("Templates")]
        [Validation(Required=false)]
        public List<DescribeCrTemplatesResponseBodyTemplates> Templates { get; set; }
        public class DescribeCrTemplatesResponseBodyTemplates : TeaModel {
            /// <summary>
            /// The Chinese name of the YAML template.
            /// </summary>
            [NameInMap("ChineseName")]
            [Validation(Required=false)]
            public string ChineseName { get; set; }

            /// <summary>
            /// The English name of the YAML template.
            /// </summary>
            [NameInMap("EnglishName")]
            [Validation(Required=false)]
            public string EnglishName { get; set; }

            /// <summary>
            /// The content in the YAML template.
            /// </summary>
            [NameInMap("Yaml")]
            [Validation(Required=false)]
            public string Yaml { get; set; }

        }

    }

}
