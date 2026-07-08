// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class BatchUnbindPurchasedDevicesResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
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
        public List<BatchUnbindPurchasedDevicesResponseBodyResults> Results { get; set; }
        public class BatchUnbindPurchasedDevicesResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>Device ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>348*****380-cn-qingdao</para>
            /// </summary>
            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// <para>Error message.</para>
            /// <remarks>
            /// <para>This field appears only when an error occurs.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>some error</para>
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

        }

    }

}
