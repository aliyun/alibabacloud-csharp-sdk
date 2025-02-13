// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20201214.Models
{
    public class DumpMetaListResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the task that is used to export metadata.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DumpMetaListResponseBodyData Data { get; set; }
        public class DumpMetaListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>A list of tasks that are used to export metadata.</para>
            /// </summary>
            [NameInMap("DumpMetaList")]
            [Validation(Required=false)]
            public List<DumpMetaListResponseBodyDataDumpMetaList> DumpMetaList { get; set; }
            public class DumpMetaListResponseBodyDataDumpMetaList : TeaModel {
                /// <summary>
                /// <para>The error code returned.</para>
                /// <list type="bullet">
                /// <item><description>A value of 0 indicates that the operation is successful.</description></item>
                /// <item><description>Values other than 0 indicate errors.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The ID of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The address where you can download the metadata. The address is valid for 2 hours.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://imagesearchname.oss-cn-shanghai.aliyuncs.com/xxx">https://imagesearchname.oss-cn-shanghai.aliyuncs.com/xxx</a></para>
                /// </summary>
                [NameInMap("MetaUrl")]
                [Validation(Required=false)]
                public string MetaUrl { get; set; }

                /// <summary>
                /// <para>The error message returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Msg")]
                [Validation(Required=false)]
                public string Msg { get; set; }

                /// <summary>
                /// <para>The status of the export task.</para>
                /// <list type="bullet">
                /// <item><description>PROCESSING: in progress</description></item>
                /// <item><description>FAIL: failed</description></item>
                /// <item><description>SUCCESS: successful</description></item>
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
                /// <para>The time when the task was updated. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1629095760000</para>
                /// </summary>
                [NameInMap("UtcModified")]
                [Validation(Required=false)]
                public long? UtcModified { get; set; }

            }

            /// <summary>
            /// <para>The number of the page to return.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries to return on each page.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B3137727-7D6E-488C-BA21-0E034C38A879</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
