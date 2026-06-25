// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20201214.Models
{
    public class DumpMetaListResponseBody : TeaModel {
        /// <summary>
        /// <para>The metadata export information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DumpMetaListResponseBodyData Data { get; set; }
        public class DumpMetaListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The collection of metadata export tasks.</para>
            /// </summary>
            [NameInMap("DumpMetaList")]
            [Validation(Required=false)]
            public List<DumpMetaListResponseBodyDataDumpMetaList> DumpMetaList { get; set; }
            public class DumpMetaListResponseBodyDataDumpMetaList : TeaModel {
                /// <summary>
                /// <para>The error code. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: Succeeded.</description></item>
                /// <item><description>Non-zero: Failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The URL for downloading the result. The URL is valid for two hours.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://imagesearchname.oss-cn-shanghai.aliyuncs.com/xxx">https://imagesearchname.oss-cn-shanghai.aliyuncs.com/xxx</a></para>
                /// </summary>
                [NameInMap("MetaUrl")]
                [Validation(Required=false)]
                public string MetaUrl { get; set; }

                /// <summary>
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Msg")]
                [Validation(Required=false)]
                public string Msg { get; set; }

                /// <summary>
                /// <para>The task status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PROCESSING: The task is being processed.</description></item>
                /// <item><description>FAIL: The task failed.</description></item>
                /// <item><description>SUCCESS: The task is completed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SUCCESS</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The time when the task was created. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1629095713000</para>
                /// </summary>
                [NameInMap("UtcCreate")]
                [Validation(Required=false)]
                public string UtcCreate { get; set; }

                /// <summary>
                /// <para>The time when the task was last updated. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1629095760000</para>
                /// </summary>
                [NameInMap("UtcModified")]
                [Validation(Required=false)]
                public long? UtcModified { get; set; }

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
            /// <para>The number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B3137727-7D6E-488C-BA21-0E034C38A879</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
