// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class ConvertHybridInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>000000</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The order information.</para>
        /// </summary>
        [NameInMap("OrderInfo")]
        [Validation(Required=false)]
        public ConvertHybridInstanceResponseBodyOrderInfo OrderInfo { get; set; }
        public class ConvertHybridInstanceResponseBodyOrderInfo : TeaModel {
            /// <summary>
            /// <para>The instance ID of the pay-as-you-go portion of hybrid billing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f-cn-asd***</para>
            /// </summary>
            [NameInMap("ElasticInstanceId")]
            [Validation(Required=false)]
            public string ElasticInstanceId { get; set; }

            /// <summary>
            /// <para>The instance ID of the subscription portion of hybrid billing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f-cn-zvp2q*****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2104063546****</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>67F33190-946B-1105-B6A1-E2DF042*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
