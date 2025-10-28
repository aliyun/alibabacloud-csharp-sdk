// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListConfigTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The result of the request.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListConfigTemplatesResponseBodyData Data { get; set; }
        public class ListConfigTemplatesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The configuration templates.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListConfigTemplatesResponseBodyDataResult> Result { get; set; }
            public class ListConfigTemplatesResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The content of the configuration template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;name&quot;:&quot;William&quot;}</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The description of the configuration template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test configuration template</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The data format of the configuration template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>JSON</para>
                /// </summary>
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// <para>The time when the configuration template was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1638171689626</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <para>The time when the configuration template was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1638171689626</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                /// <summary>
                /// <para>The ID of the configuration template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3d84efaf-37d9-49fb-a3a8-b38d5c2b460c</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The name of the configuration template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>config-tmpl-1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The total number of configuration templates.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The additional information that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4D9F-DR94-FD****************</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
