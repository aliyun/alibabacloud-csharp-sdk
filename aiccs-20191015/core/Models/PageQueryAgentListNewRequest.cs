// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class PageQueryAgentListNewRequest : TeaModel {
        /// <summary>
        /// <para>Agent ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The agent name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Intelligent Customer Service Assistant</para>
        /// </summary>
        [NameInMap("AgentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

        /// <summary>
        /// <para>Specifies whether to return only candidate agents that are configurable for inbound calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("InboundConfigurableOnly")]
        [Validation(Required=false)]
        public bool? InboundConfigurableOnly { get; set; }

        /// <summary>
        /// <para>Specifies whether the agent is available for outbound calls. A value of True indicates that the current deployment branch of the agent has a published version and is available for outbound calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsAvailable")]
        [Validation(Required=false)]
        public bool? IsAvailable { get; set; }

        /// <summary>
        /// <para>The page number. This parameter is deprecated. Use PageNo instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public long? PageIndex { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The service direction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample value</para>
        /// </summary>
        [NameInMap("ServiceDirection")]
        [Validation(Required=false)]
        public string ServiceDirection { get; set; }

        /// <summary>
        /// <para>The source template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

    }

}
