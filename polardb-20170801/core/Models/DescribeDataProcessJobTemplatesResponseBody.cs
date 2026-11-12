// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDataProcessJobTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of data processing task templates.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDataProcessJobTemplatesResponseBodyItems> Items { get; set; }
        public class DescribeDataProcessJobTemplatesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>Specifies whether it is to fetch the image summary or video synopsis.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Captioning")]
            [Validation(Required=false)]
            public bool? Captioning { get; set; }

            /// <summary>
            /// <para>The prompt used when extracting captions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Summarize the image content</para>
            /// </summary>
            [NameInMap("CaptioningPrompt")]
            [Validation(Required=false)]
            public string CaptioningPrompt { get; set; }

            /// <summary>
            /// <para>The time when the task template was created, in RFC 3339 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>Indicates whether content is converted into vectors.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Embedding")]
            [Validation(Required=false)]
            public bool? Embedding { get; set; }

            /// <summary>
            /// <para>The vector output dimensions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>768</para>
            /// </summary>
            [NameInMap("EmbeddingDimension")]
            [Validation(Required=false)]
            public int? EmbeddingDimension { get; set; }

            /// <summary>
            /// <para>The task template status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The JSON configuration string of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;ETL_TEMPLATE_STR&quot;:&quot;config&quot;}</para>
            /// </summary>
            [NameInMap("TemplateConfig")]
            [Validation(Required=false)]
            public string TemplateConfig { get; set; }

            /// <summary>
            /// <para>The task template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tpl-123456</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The task template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>template1</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>The node templatetype. Valid value: image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>image</para>
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

        }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of templates returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2921D843-433A-5FB3-A03B-4EC093B219F8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of templates that meet the specified conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
