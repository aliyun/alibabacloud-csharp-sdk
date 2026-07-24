// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class ListKeywordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListKeywordsResponseBodyData Data { get; set; }
        public class ListKeywordsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The data on the current page.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<ListKeywordsResponseBodyDataItems> Items { get; set; }
            public class ListKeywordsResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-06-03 14:43:03</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The modification time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-06-03 14:43:03</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The primary key ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>112</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The keyword library ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>custom_xxxx</para>
                /// </summary>
                [NameInMap("KeywordLibId")]
                [Validation(Required=false)]
                public string KeywordLibId { get; set; }

                /// <summary>
                /// <para>The keyword data ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4205334</para>
                /// </summary>
                [NameInMap("KeywordMd5Id")]
                [Validation(Required=false)]
                public long? KeywordMd5Id { get; set; }

                /// <summary>
                /// <para>The properties.</para>
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public ListKeywordsResponseBodyDataItemsProperties Properties { get; set; }
                public class ListKeywordsResponseBodyDataItemsProperties : TeaModel {
                    /// <summary>
                    /// <para>The properties.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("Attribute")]
                    [Validation(Required=false)]
                    public string Attribute { get; set; }

                }

                /// <summary>
                /// <para>The keyword.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试词</para>
                /// </summary>
                [NameInMap("Word")]
                [Validation(Required=false)]
                public string Word { get; set; }

            }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The description of the error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>The ID assigned by the backend to uniquely identify the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
