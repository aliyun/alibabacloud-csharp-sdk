// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateEnterpriseAcceleratePolicyRequest : TeaModel {
        /// <summary>
        /// <para>The acceleration mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>whiltelist</b>: whitelist-based acceleration.</description></item>
        /// <item><description><b>global</b>: global acceleration.</description></item>
        /// <item><description><b>build-in-list</b>: built-in application acceleration.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>whitelist</para>
        /// </summary>
        [NameInMap("AccelerationType")]
        [Validation(Required=false)]
        public string AccelerationType { get; set; }

        /// <summary>
        /// <para>The description of the enterprise management policy. The description must be 1 to 512 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Acceleration policy for global network access</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The policy name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GlobalAccelerationPolicy</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        /// <summary>
        /// <para>Specifies whether to display the policy in the client. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: not displayed.</description></item>
        /// <item><description><b>1</b>: displayed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ShowInClient")]
        [Validation(Required=false)]
        public int? ShowInClient { get; set; }

        /// <summary>
        /// <para>The address (IP address or domain name) of the acceleration instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12.34.56.XX</para>
        /// </summary>
        [NameInMap("UpstreamHost")]
        [Validation(Required=false)]
        public string UpstreamHost { get; set; }

        /// <summary>
        /// <para>The port of the acceleration instance. Valid values: 1000 to 60000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("UpstreamPort")]
        [Validation(Required=false)]
        public int? UpstreamPort { get; set; }

        /// <summary>
        /// <para>The acceleration instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga</para>
        /// </summary>
        [NameInMap("UpstreamType")]
        [Validation(Required=false)]
        public string UpstreamType { get; set; }

        /// <summary>
        /// <para>The acceleration user group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestUserGroup</para>
        /// </summary>
        [NameInMap("UserAttributeGroup")]
        [Validation(Required=false)]
        public string UserAttributeGroup { get; set; }

    }

}
