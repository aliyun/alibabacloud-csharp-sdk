// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class CreateApiKeyRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>rds_copilot***_public_cn-*********6</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>api-*****</para>
        /// </summary>
        [NameInMap("KeyName")]
        [Validation(Required=false)]
        public string KeyName { get; set; }

        [NameInMap("LimitRate")]
        [Validation(Required=false)]
        public double? LimitRate { get; set; }

        [NameInMap("LimitType")]
        [Validation(Required=false)]
        public string LimitType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Quantity")]
        [Validation(Required=false)]
        public int? Quantity { get; set; }

        [NameInMap("TokenQuota")]
        [Validation(Required=false)]
        public long? TokenQuota { get; set; }

    }

}
