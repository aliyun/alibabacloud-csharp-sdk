// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class CreateExecutorGroupRequest : TeaModel {
        /// <summary>
        /// <para>The client secret.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HfGUG/Qf8qRCCWlv5RT6WA==</para>
        /// </summary>
        [NameInMap("ApiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <para>The authentication type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api_key</para>
        /// </summary>
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        /// <summary>
        /// <para>The auto scaling configuration.</para>
        /// </summary>
        [NameInMap("AutoScale")]
        [Validation(Required=false)]
        public bool? AutoScale { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxljob-b6ec1xxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The CloudMonitor Service (CMS) workspace ID.</para>
        /// </summary>
        [NameInMap("CmsWorkspaceId")]
        [Validation(Required=false)]
        public string CmsWorkspaceId { get; set; }

        /// <summary>
        /// <para>The description of the worker group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group1</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The integration method of the executor. Valid values: manual (indicates manual entry) and acs (indicates ACS integration).</para>
        /// 
        /// <b>Example:</b>
        /// <para>manual</para>
        /// </summary>
        [NameInMap("IntegrationType")]
        [Validation(Required=false)]
        public string IntegrationType { get; set; }

        /// <summary>
        /// <para>The name of the worker group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The network type. Valid values: public and private.</para>
        /// 
        /// <b>Example:</b>
        /// <para>public</para>
        /// </summary>
        [NameInMap("Network")]
        [Validation(Required=false)]
        public string Network { get; set; }

        /// <summary>
        /// <para>The backend protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>HTTP</b> (default): Supports association with HTTPS, HTTP, and QUIC listeners.</para>
        /// </description></item>
        /// <item><description><para><b>HTTPS</b>: Supports association with HTTPS listeners.</para>
        /// </description></item>
        /// <item><description><para><b>gRPC</b>: Supports association with HTTPS and QUIC listeners.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If <b>ServerGroupType</b> is set to <b>Fc</b>, you do not need to configure the backend protocol.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>HTTPS</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The worker type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>openclaw</para>
        /// </summary>
        [NameInMap("WorkerType")]
        [Validation(Required=false)]
        public string WorkerType { get; set; }

        /// <summary>
        /// <para>The list of workers in JSON format.</para>
        /// <para>This parameter is required.</para>
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
