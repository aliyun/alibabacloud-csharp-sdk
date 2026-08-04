// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateEnterpriseAcceleratePolicyRequest : TeaModel {
        /// <summary>
        /// <para>Acceleration pattern:</para>
        /// <list type="bullet">
        /// <item><description><para><b>whitelist</b>: Whitelist acceleration</para>
        /// </description></item>
        /// <item><description><para><b>global</b>: Global acceleration</para>
        /// </description></item>
        /// <item><description><para><b>build-in-list</b>: Built-in application acceleration</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>whitelist</para>
        /// </summary>
        [NameInMap("AccelerationType")]
        [Validation(Required=false)]
        public string AccelerationType { get; set; }

        /// <summary>
        /// <para>Policy description. Length: 1 to 512 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>用于全局网络访问的加速策略</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Policy Name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>全局加速策略</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        /// <summary>
        /// <para>Whether to display this policy in the client:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Do not display</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Display</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ShowInClient")]
        [Validation(Required=false)]
        public int? ShowInClient { get; set; }

        /// <summary>
        /// <para>The IP address or domain name of the acceleration instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12.34.56.XX</para>
        /// </summary>
        [NameInMap("UpstreamHost")]
        [Validation(Required=false)]
        public string UpstreamHost { get; set; }

        /// <summary>
        /// <para>Port for the accelerated instance. The port must be between 1000 and 60000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("UpstreamPort")]
        [Validation(Required=false)]
        public int? UpstreamPort { get; set; }

        /// <summary>
        /// <para>Accelerated instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga</para>
        /// </summary>
        [NameInMap("UpstreamType")]
        [Validation(Required=false)]
        public string UpstreamType { get; set; }

        /// <summary>
        /// <para>User group for acceleration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试用户组</para>
        /// </summary>
        [NameInMap("UserAttributeGroup")]
        [Validation(Required=false)]
        public string UserAttributeGroup { get; set; }

    }

}
