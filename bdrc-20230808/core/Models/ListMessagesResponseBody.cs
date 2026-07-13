// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class ListMessagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListMessagesResponseBodyData Data { get; set; }
        public class ListMessagesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Response parameters.</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<ListMessagesResponseBodyDataContent> Content { get; set; }
            public class ListMessagesResponseBodyDataContent : TeaModel {
                /// <summary>
                /// <para>Message ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zgrjap8j-us04-owef-fpmo-kdpr80pbss0k</para>
                /// </summary>
                [NameInMap("MessageId")]
                [Validation(Required=false)]
                public string MessageId { get; set; }

                /// <summary>
                /// <para>Message level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>WARNING</para>
                /// </summary>
                [NameInMap("MessageLevel")]
                [Validation(Required=false)]
                public string MessageLevel { get; set; }

                /// <summary>
                /// <para>Message name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MyMessage</para>
                /// </summary>
                [NameInMap("MessageName")]
                [Validation(Required=false)]
                public string MessageName { get; set; }

                /// <summary>
                /// <para>Message source ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>p-123***7890</para>
                /// </summary>
                [NameInMap("MessageSourceId")]
                [Validation(Required=false)]
                public string MessageSourceId { get; set; }

                /// <summary>
                /// <para>Message source region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("MessageSourceRegionId")]
                [Validation(Required=false)]
                public string MessageSourceRegionId { get; set; }

                /// <summary>
                /// <para>Message source type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PROTECTION_POLICY</para>
                /// </summary>
                [NameInMap("MessageSourceType")]
                [Validation(Required=false)]
                public string MessageSourceType { get; set; }

                /// <summary>
                /// <para>Message time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1740019609</para>
                /// </summary>
                [NameInMap("MessageTime")]
                [Validation(Required=false)]
                public long? MessageTime { get; set; }

                /// <summary>
                /// <para>Message type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SUB_PROTECTION_POLICY_MODIFIED</para>
                /// </summary>
                [NameInMap("MessageType")]
                [Validation(Required=false)]
                public string MessageType { get; set; }

            }

            /// <summary>
            /// <para>The maximum number of results requested.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The pagination token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eKDyCM0zFQ5op7jVMWmNNA==</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>42</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5748C531-80B1-5C31-8421-63A1830B9E48</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
