// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class InstallAddonRequest : TeaModel {
        /// <summary>
        /// <para>The addon name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Login</para>
        /// </summary>
        [NameInMap("AddonName")]
        [Validation(Required=false)]
        public string AddonName { get; set; }

        /// <summary>
        /// <para>The addon version.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("AddonVersion")]
        [Validation(Required=false)]
        public string AddonVersion { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The resource configurations of the addon.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><c>{&quot;EipResource&quot;: {&quot;AutoCreate&quot;: true}, &quot;EcsResources&quot;: [{&quot;InstanceType&quot;: &quot;ecs.c7.xlarge&quot;, &quot;ImageId&quot;: &quot;centos_7_6_xxx.vhd&quot;, &quot;SystemDisk&quot;: {&quot;Category&quot;: &quot;cloud_essd&quot;, &quot;Size&quot;: 40, &quot;Level&quot;: &quot;PL0&quot;}]}</c></para>
        /// </summary>
        [NameInMap("ResourcesSpec")]
        [Validation(Required=false)]
        public string ResourcesSpec { get; set; }

        /// <summary>
        /// <para>The service configurations of the addon.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><c>[{&quot;ServiceName&quot;: &quot;SSH&quot;, &quot;ServiceAccessType&quot;: null, &quot;ServiceAccessUrl&quot;: null, &quot;NetworkACL&quot;: [{&quot;IpProtocol&quot;: &quot;TCP&quot;, &quot;Port&quot;: 22, &quot;SourceCidrIp&quot;: &quot;0.0.0.0/0&quot;}]}, {&quot;ServiceName&quot;: &quot;VNC&quot;, &quot;ServiceAccessType&quot;: null, &quot;ServiceAccessUrl&quot;: null, &quot;NetworkACL&quot;: [{&quot;IpProtocol&quot;: &quot;TCP&quot;, &quot;Port&quot;: 12016, &quot;SourceCidrIp&quot;: &quot;0.0.0.0/0&quot;}]}]</c></para>
        /// </summary>
        [NameInMap("ServicesSpec")]
        [Validation(Required=false)]
        public string ServicesSpec { get; set; }

    }

}
