// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class GetWorksEmbedListResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>38C0F*<b><b>0-415</b></b>9F1-*****422BDB65</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The report array object.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetWorksEmbedListResponseBodyResult Result { get; set; }
        public class GetWorksEmbedListResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The report array.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<GetWorksEmbedListResponseBodyResultData> Data { get; set; }
            public class GetWorksEmbedListResponseBodyResultData : TeaModel {
                /// <summary>
                /// <para>The time when the report was embedded. Format: YYYY-MM-DD hh:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>YYYY-mm-DD hh:MM:ss</para>
                /// </summary>
                [NameInMap("EmbedTime")]
                [Validation(Required=false)]
                public string EmbedTime { get; set; }

                /// <summary>
                /// <para>The report ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>897ce25e-<b><b>-</b></b>-af84-d13c5610****</para>
                /// </summary>
                [NameInMap("WorksId")]
                [Validation(Required=false)]
                public string WorksId { get; set; }

                /// <summary>
                /// <para>The report name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("WorksName")]
                [Validation(Required=false)]
                public string WorksName { get; set; }

                /// <summary>
                /// <para>The report type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>page</para>
                /// </summary>
                [NameInMap("WorksType")]
                [Validation(Required=false)]
                public string WorksType { get; set; }

                /// <summary>
                /// <para>The ID of the workspace to which the report belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>87c6b145-<b><b>-43e1-9426-8f93be23</b></b></para>
                /// </summary>
                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18</para>
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public long? TotalNum { get; set; }

            /// <summary>
            /// <para>The total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public long? TotalPages { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
