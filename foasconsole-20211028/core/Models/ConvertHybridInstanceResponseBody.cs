// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class ConvertHybridInstanceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>000000</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("OrderInfo")]
        [Validation(Required=false)]
        public ConvertHybridInstanceResponseBodyOrderInfo OrderInfo { get; set; }
        public class ConvertHybridInstanceResponseBodyOrderInfo : TeaModel {
            [NameInMap("ElasticInstanceId")]
            [Validation(Required=false)]
            public string ElasticInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>f-cn-zvp2q0zik06</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>210406354694567</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>67F33190-946B-1105-B6A1-E2DF0426DD51</para>
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
