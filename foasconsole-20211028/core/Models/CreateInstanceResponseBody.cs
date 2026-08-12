// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class CreateInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The order information.</para>
        /// </summary>
        [NameInMap("OrderInfo")]
        [Validation(Required=false)]
        public CreateInstanceResponseBodyOrderInfo OrderInfo { get; set; }
        public class CreateInstanceResponseBodyOrderInfo : TeaModel {
            /// <summary>
            /// <para>The instance ID of the order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f-cn-zvp2q0zik06</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>210406354694567</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            /// <summary>
            /// <para>The storage instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sc_flinkstorage_public_cn-w*****</para>
            /// </summary>
            [NameInMap("StorageInstanceId")]
            [Validation(Required=false)]
            public string StorageInstanceId { get; set; }

            /// <summary>
            /// <para>The storage order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>240353501970749</para>
            /// </summary>
            [NameInMap("StorageOrderId")]
            [Validation(Required=false)]
            public long? StorageOrderId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>67F33190-946B-1105-B6A1-E2DF0426DD51</para>
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
