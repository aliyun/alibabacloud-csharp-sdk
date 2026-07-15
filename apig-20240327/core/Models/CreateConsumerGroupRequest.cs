// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateConsumerGroupRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>csg-8c13d2b4f8a1</para>
        /// </summary>
        [NameInMap("consumerGroupId")]
        [Validation(Required=false)]
        public string ConsumerGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>用于线上 API 调用方分组</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>API</para>
        /// </summary>
        [NameInMap("gatewayType")]
        [Validation(Required=false)]
        public string GatewayType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>api-consumer-group</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
