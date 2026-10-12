// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetApiPathFieldConfigRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cloud-native API gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-123456</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The ID of the HTTP API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api-123456</para>
        /// </summary>
        [NameInMap("httpApiId")]
        [Validation(Required=false)]
        public string HttpApiId { get; set; }

    }

}
