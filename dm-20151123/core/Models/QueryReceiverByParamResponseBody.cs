// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class QueryReceiverByParamResponseBody : TeaModel {
        /// <summary>
        /// <para>Used for pagination. If there are more results, set this returned value to the NextStart in the next request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6aec200853#102#1638894326#<a href="mailto:test@example.com">test@example.com</a></para>
        /// </summary>
        [NameInMap("NextStart")]
        [Validation(Required=false)]
        public string NextStart { get; set; }

        /// <summary>
        /// <para>Number of items displayed per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>10A1AD70-E48E-476D-98D9-39BD92193837</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total count</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>Detailed information of the recipient list</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryReceiverByParamResponseBodyData Data { get; set; }
        public class QueryReceiverByParamResponseBodyData : TeaModel {
            [NameInMap("receiver")]
            [Validation(Required=false)]
            public List<QueryReceiverByParamResponseBodyDataReceiver> Receiver { get; set; }
            public class QueryReceiverByParamResponseBodyDataReceiver : TeaModel {
                /// <summary>
                /// <para>Total number of recipient addresses</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public string Count { get; set; }

                /// <summary>
                /// <para>Creation time</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-09-29T13:28Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>Description</para>
                /// 
                /// <b>Example:</b>
                /// <para>Description</para>
                /// </summary>
                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                /// <summary>
                /// <para>Recipient list ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>0c910a7143044b1e116719eb678907b3</para>
                /// </summary>
                [NameInMap("ReceiverId")]
                [Validation(Required=false)]
                public string ReceiverId { get; set; }

                /// <summary>
                /// <para>Recipient list alias</para>
                /// 
                /// <b>Example:</b>
                /// <para>10***@example.com</para>
                /// </summary>
                [NameInMap("ReceiversAlias")]
                [Validation(Required=false)]
                public string ReceiversAlias { get; set; }

                /// <summary>
                /// <para>Recipient list name</para>
                /// 
                /// <b>Example:</b>
                /// <para>TKP000442-333</para>
                /// </summary>
                [NameInMap("ReceiversName")]
                [Validation(Required=false)]
                public string ReceiversName { get; set; }

                /// <summary>
                /// <para>List status. Values:</para>
                /// <list type="bullet">
                /// <item><description>0: Uploading</description></item>
                /// <item><description>1: Upload completed</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ReceiversStatus")]
                [Validation(Required=false)]
                public string ReceiversStatus { get; set; }

                /// <summary>
                /// <para>UTC formatted creation time</para>
                /// 
                /// <b>Example:</b>
                /// <para>1569734892</para>
                /// </summary>
                [NameInMap("UtcCreateTime")]
                [Validation(Required=false)]
                public long? UtcCreateTime { get; set; }

            }

        }

    }

}
