// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListZonesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListZonesResponseBodyData Data { get; set; }
        public class ListZonesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of zones.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListZonesResponseBodyDataItems> Items { get; set; }
            public class ListZonesResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>Indicates whether QuickAssist Technology (QAT) is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("supportQat")]
                [Validation(Required=false)]
                public string SupportQat { get; set; }

                /// <summary>
                /// <para>The zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shenzhen-c</para>
                /// </summary>
                [NameInMap("zoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E8079207-B651-592A-A565-23E9EE5673B0</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
