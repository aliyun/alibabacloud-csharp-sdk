// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListChatbotInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The access key of the chatbot workspace.</para>
        /// <remarks>
        /// <para>You can obtain the value by calling the ListChatbotAgents operation. If you leave this parameter empty, chatbots in all workspaces are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>9137ab9c27044921860030adf8590ec4_p_outbound_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <remarks>
        /// <para>The value of this parameter must be less than or equal to 50.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
