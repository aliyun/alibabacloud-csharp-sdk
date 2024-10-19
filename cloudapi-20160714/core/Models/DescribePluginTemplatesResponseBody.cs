// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribePluginTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EF924FE4-2EDD-4CD3-89EC-34E4708574E7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The templates.</para>
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
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>balabala</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The document anchor point.</para>
                /// 
                /// <b>Example:</b>
                /// <para>anchor</para>
                /// </summary>
                [NameInMap("DocumentAnchor")]
                [Validation(Required=false)]
                public string DocumentAnchor { get; set; }

                /// <summary>
                /// <para>The ID of the document.</para>
                /// 
                /// <b>Example:</b>
                /// <para>41079</para>
                /// </summary>
                [NameInMap("DocumentId")]
                [Validation(Required=false)]
                public string DocumentId { get; set; }

                /// <summary>
                /// <para>The sample.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Sample")]
                [Validation(Required=false)]
                public string Sample { get; set; }

                /// <summary>
                /// <para>The title of the plug-in template title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>template title</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

    }

}
