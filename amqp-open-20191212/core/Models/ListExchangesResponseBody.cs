// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class ListExchangesResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListExchangesResponseBodyData Data { get; set; }
        public class ListExchangesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The exchanges.</para>
            /// </summary>
            [NameInMap("Exchanges")]
            [Validation(Required=false)]
            public List<ListExchangesResponseBodyDataExchanges> Exchanges { get; set; }
            public class ListExchangesResponseBodyDataExchanges : TeaModel {
                /// <summary>
                /// <para>The attributes of the exchange. This parameter is not supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Attributes")]
                [Validation(Required=false)]
                public Dictionary<string, object> Attributes { get; set; }

                /// <summary>
                /// <para>Indicates whether the exchange is an auto-delete exchange.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AutoDeleteState")]
                [Validation(Required=false)]
                public bool? AutoDeleteState { get; set; }

                /// <summary>
                /// <para>The time when the exchange was created. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1580886216000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The type of the exchange.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DIRECT</para>
                /// </summary>
                [NameInMap("ExchangeType")]
                [Validation(Required=false)]
                public string ExchangeType { get; set; }

                /// <summary>
                /// <para>Indicates whether the exchange is an internal exchange.</para>
                /// </summary>
                [NameInMap("Internal")]
                [Validation(Required=false)]
                public bool? Internal { get; set; }

                /// <summary>
                /// <para>The name of the exchange.</para>
                /// 
                /// <b>Example:</b>
                /// <para>amq.direct</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The name of the vhost to which the exchange belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("VHostName")]
                [Validation(Required=false)]
                public string VHostName { get; set; }

            }

            /// <summary>
            /// <para>The maximum number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The token that marks the start of the next query.</para>
            /// <list type="bullet">
            /// <item><description><para>If this parameter is empty, no more data is available.</para>
            /// </description></item>
            /// <item><description><para>If a value is returned, use the value as the <c>NextToken</c> value in the next call to continue the query.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AAAANDQBYW1xcC1jbi03cHAybXdiY3AwMGEBdmhvc3QBAXNkZndhYWJhATE2NDkzMTM4OTU5NDIB4o3z1pPwWzk4aYuiRffi8R6-****</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FEBA5E0C-50D0-4FA6-A794-4901E5465***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
