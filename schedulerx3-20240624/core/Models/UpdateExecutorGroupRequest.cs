// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class UpdateExecutorGroupRequest : TeaModel {
        /// <summary>
        /// <para>The client secret.</para>
        /// 
        /// <b>Example:</b>
        /// <para>K4KWGINZVY9JwcZT0/vpSg==</para>
        /// </summary>
        [NameInMap("ApiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <para>The authentication type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>APP</para>
        /// </summary>
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto scaling.</para>
        /// </summary>
        [NameInMap("AutoScale")]
        [Validation(Required=false)]
        public bool? AutoScale { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxljob-d6a5243b6fa</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The CMS workspace ID.</para>
        /// </summary>
        [NameInMap("CmsWorkspaceId")]
        [Validation(Required=false)]
        public string CmsWorkspaceId { get; set; }

        /// <summary>
        /// <para>The description of the executor group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group1</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>110176</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        [Obsolete]
        public string Id { get; set; }

        /// <summary>
        /// <para>The name of the executor group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The network configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>public</para>
        /// </summary>
        [NameInMap("Network")]
        [Validation(Required=false)]
        public string Network { get; set; }

        /// <summary>
        /// <para>The protocol.</para>
        /// 
        /// <b>Example:</b>
        /// <para>openai</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The executor type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>openclaw</para>
        /// </summary>
        [NameInMap("WorkerType")]
        [Validation(Required=false)]
        public string WorkerType { get; set; }

        /// <summary>
        /// <para>The list of specified machines in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;address&quot;:&quot;<a href="http://47.111.188.191:18789%22%7D%5D">http://47.111.188.191:18789&quot;}]</a></para>
        /// </summary>
        [NameInMap("Workers")]
        [Validation(Required=false)]
        public string Workers { get; set; }

        /// <summary>
        /// <para>The extended configuration of the executor group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Not publicly available</para>
        /// </summary>
        [NameInMap("XAttrs")]
        [Validation(Required=false)]
        public string XAttrs { get; set; }

    }

}
