// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20210202.Models
{
    public class ListTemplatesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TemplateData")]
        [Validation(Required=false)]
        public List<ListTemplatesResponseBodyTemplateData> TemplateData { get; set; }
        public class ListTemplatesResponseBodyTemplateData : TeaModel {
            [NameInMap("Template")]
            [Validation(Required=false)]
            public ListTemplatesResponseBodyTemplateDataTemplate Template { get; set; }
            public class ListTemplatesResponseBodyTemplateDataTemplate : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>url://xxx</para>
                /// </summary>
                [NameInMap("DocLink")]
                [Validation(Required=false)]
                public string DocLink { get; set; }

                /// <summary>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
                /// </summary>
                [NameInMap("GmtCreateTime")]
                [Validation(Required=false)]
                public string GmtCreateTime { get; set; }

                /// <summary>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
                /// </summary>
                [NameInMap("GmtModifiedTime")]
                [Validation(Required=false)]
                public string GmtModifiedTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>url://xxx</para>
                /// </summary>
                [NameInMap("ImageLink")]
                [Validation(Required=false)]
                public string ImageLink { get; set; }

                [NameInMap("Labels")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> Labels { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>template-rbvg5wzljzjhc9ks92</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

            }

            [NameInMap("TemplateTag")]
            [Validation(Required=false)]
            public ListTemplatesResponseBodyTemplateDataTemplateTag TemplateTag { get; set; }
            public class ListTemplatesResponseBodyTemplateDataTemplateTag : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>PyTorch</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>template-tag-rbvg5wzljzjhc9ks92</para>
                /// </summary>
                [NameInMap("TagId")]
                [Validation(Required=false)]
                public string TagId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>template-tag-type-rbvg5wzljzjhc9ks92</para>
                /// </summary>
                [NameInMap("TypeId")]
                [Validation(Required=false)]
                public string TypeId { get; set; }

            }

            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public ListTemplatesResponseBodyTemplateDataTemplateType TemplateType { get; set; }
            public class ListTemplatesResponseBodyTemplateDataTemplateType : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>行业分类</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>templatetagtype-rbvg5wzljzjhc9ks92</para>
                /// </summary>
                [NameInMap("TypeId")]
                [Validation(Required=false)]
                public string TypeId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
