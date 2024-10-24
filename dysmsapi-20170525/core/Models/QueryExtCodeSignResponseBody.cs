// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QueryExtCodeSignResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryExtCodeSignResponseBodyData Data { get; set; }
        public class QueryExtCodeSignResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryExtCodeSignResponseBodyDataList> List { get; set; }
            public class QueryExtCodeSignResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>是否可回收</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Active")]
                [Validation(Required=false)]
                public long? Active { get; set; }

                /// <summary>
                /// <para>扩展码A3</para>
                /// 
                /// <b>Example:</b>
                /// <para>01</para>
                /// </summary>
                [NameInMap("ExtCode")]
                [Validation(Required=false)]
                public string ExtCode { get; set; }

                /// <summary>
                /// <para>近1个月发送成功条数（只读）</para>
                /// 
                /// <b>Example:</b>
                /// <para>69</para>
                /// </summary>
                [NameInMap("SendCount")]
                [Validation(Required=false)]
                public long? SendCount { get; set; }

                /// <summary>
                /// <para>签名</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("SignName")]
                [Validation(Required=false)]
                public string SignName { get; set; }

                /// <summary>
                /// <para>来源</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>90E63D28-E31D-1EB2-8939-A9486641****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
