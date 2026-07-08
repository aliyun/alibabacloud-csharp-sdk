// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class BatchDeleteDevicesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID of this task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Result list.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<BatchDeleteDevicesResponseBodyResults> Results { get; set; }
        public class BatchDeleteDevicesResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>Device error message. (Only present if an error occurs)</para>
            /// 
            /// <b>Example:</b>
            /// <para>Device not found</para>
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            /// <summary>
            /// <para>Device ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>323884****9092996</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

    }

}
