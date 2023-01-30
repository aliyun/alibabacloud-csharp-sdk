// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribePluginTemplatesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The templates.
        /// </summary>
        [NameInMap("Templates")]
        [Validation(Required=false)]
        public DescribePluginTemplatesResponseBodyTemplates Templates { get; set; }
        public class DescribePluginTemplatesResponseBodyTemplates : TeaModel {
            [NameInMap("Template")]
            [Validation(Required=false)]
            public List<DescribePluginTemplatesResponseBodyTemplatesTemplate> Template { get; set; }
            public class DescribePluginTemplatesResponseBodyTemplatesTemplate : TeaModel {
                /// <summary>
                /// The description.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The document anchor point.
                /// </summary>
                [NameInMap("DocumentAnchor")]
                [Validation(Required=false)]
                public string DocumentAnchor { get; set; }

                /// <summary>
                /// The ID of the document.
                /// </summary>
                [NameInMap("DocumentId")]
                [Validation(Required=false)]
                public string DocumentId { get; set; }

                /// <summary>
                /// The sample.
                /// </summary>
                [NameInMap("Sample")]
                [Validation(Required=false)]
                public string Sample { get; set; }

                /// <summary>
                /// The title of the plug-in template title.
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

    }

}
