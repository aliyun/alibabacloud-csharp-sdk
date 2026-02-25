// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class UpdateGatewayRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("FeNodeNumber")]
        [Validation(Required=false)]
        public int? FeNodeNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dg-65u7d65p5960fjq7</para>
        /// </summary>
        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>polar-byd-glm-47</para>
        /// </summary>
        [NameInMap("GatewayName")]
        [Validation(Required=false)]
        public string GatewayName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>c-b25e21e24388****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
