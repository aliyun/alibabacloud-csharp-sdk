// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreateAICloudPhoneResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateAICloudPhoneResponseBodyData Data { get; set; }
        public class CreateAICloudPhoneResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20230930123456</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            /// <summary>
            /// <para>The list of package IDs. After the payment is successful, instances are created based on these IDs through a callback.</para>
            /// </summary>
            [NameInMap("PackageIds")]
            [Validation(Required=false)]
            public List<string> PackageIds { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9A51B1DF-96FF-3BCC-B08C-783161D3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
