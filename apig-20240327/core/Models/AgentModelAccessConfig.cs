// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AgentModelAccessConfig : TeaModel {
        /// <summary>
        /// <para>The list of consumer IDs that represent the Agent to access the Model API. The Model API ID and consumer ID together identify the Agent identity, and the configuration takes effect for all current and future routes of the Model API. Specify at least one consumer. The consumer must be enabled and must have direct Consumer authorization for the Model API in the default environment of the target gateway, with the authorization publish status being Success. Different Agents cannot bind the same consumer to the same Model API. ConsumerGroup is not supported.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("consumerIds")]
        [Validation(Required=false)]
        public List<string> ConsumerIds { get; set; }

        /// <summary>
        /// <para>The ID of the Model API to associate. The Model API must belong to the specified gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>model-api-1</para>
        /// </summary>
        [NameInMap("modelApiId")]
        [Validation(Required=false)]
        public string ModelApiId { get; set; }

    }

}
