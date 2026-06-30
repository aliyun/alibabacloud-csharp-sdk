// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class UpdatePolarClawAgentToolsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Agent ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>work</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The list of explicitly allowed tools.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;read&quot;,&quot;write&quot;,&quot;exec&quot;]</para>
        /// </summary>
        [NameInMap("Allow")]
        [Validation(Required=false)]
        public string AllowShrink { get; set; }

        /// <summary>
        /// <para>The list of additionally allowed tools.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;send_message&quot;]</para>
        /// </summary>
        [NameInMap("AlsoAllow")]
        [Validation(Required=false)]
        public string AlsoAllowShrink { get; set; }

        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-xxx</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The list of denied tools.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;exec&quot;]</para>
        /// </summary>
        [NameInMap("Deny")]
        [Validation(Required=false)]
        public string DenyShrink { get; set; }

        /// <summary>
        /// <para>The tool profile.</para>
        /// 
        /// <b>Example:</b>
        /// <para>coding</para>
        /// </summary>
        [NameInMap("Profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

    }

}
