// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class ListJobTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of job templates.</para>
        /// </summary>
        [NameInMap("JobTemplates")]
        [Validation(Required=false)]
        public List<ListJobTemplatesResponseBodyJobTemplates> JobTemplates { get; set; }
        public class ListJobTemplatesResponseBodyJobTemplates : TeaModel {
            /// <summary>
            /// <para>The time when the job template was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-20 11:09:59</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Demo</para>
            /// </summary>
            [NameInMap("JobTemplateDescription")]
            [Validation(Required=false)]
            public string JobTemplateDescription { get; set; }

            /// <summary>
            /// <para>The ID of the job template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jt-xxxx</para>
            /// </summary>
            [NameInMap("JobTemplateId")]
            [Validation(Required=false)]
            public string JobTemplateId { get; set; }

            /// <summary>
            /// <para>The name of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-template</para>
            /// </summary>
            [NameInMap("JobTemplateName")]
            [Validation(Required=false)]
            public string JobTemplateName { get; set; }

            /// <summary>
            /// <para>The status of the job template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Working</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tag information of the job.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListJobTemplatesResponseBodyJobTemplatesTags> Tags { get; set; }
            public class ListJobTemplatesResponseBodyJobTemplatesTags : TeaModel {
                /// <summary>
                /// <para>The key of the job tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the job tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestValue</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The time when the job template was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-20 11:09:59</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>896D338C-E4F4-41EC-A154-D605E5DE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
