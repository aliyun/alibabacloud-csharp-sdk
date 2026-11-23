// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetConsumerAccessOverviewRequest : TeaModel {
        /// <summary>
        /// <para>The target AI gateway instance ID. Quotas and resources are isolated by instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-123456</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>Specifies whether to also query the model TPM limits. Default value: false. If set to true, modelTpmLimits is returned for dedicated instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("includeModelTpm")]
        [Validation(Required=false)]
        public bool? IncludeModelTpm { get; set; }

    }

}
