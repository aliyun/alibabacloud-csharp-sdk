// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class CreateAgentRequest : TeaModel {
        /// <summary>
        /// <para>The agent name. The name must be unique within the same tenant. Maximum length: 128 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order-analysis-agent</para>
        /// </summary>
        [NameInMap("AgentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

        /// <summary>
        /// <para>The permission inheritance type of the agent, which specifies the permission source. Default value: HUMAN_BOUND.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HUMAN_BOUND</para>
        /// </summary>
        [NameInMap("AgentType")]
        [Validation(Required=false)]
        public string AgentType { get; set; }

        /// <summary>
        /// <para>The description of the agent. Maximum length: 512 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>An agent for querying and analyzing order data</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The validity period of the automatically issued API key, in seconds. Valid values: 1 to 31536000 (up to 1 year).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2592000</para>
        /// </summary>
        [NameInMap("ExpireAfterSeconds")]
        [Validation(Required=false)]
        public int? ExpireAfterSeconds { get; set; }

    }

}
