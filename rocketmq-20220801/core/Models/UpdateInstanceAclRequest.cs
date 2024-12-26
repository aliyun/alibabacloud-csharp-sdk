// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class UpdateInstanceAclRequest : TeaModel {
        /// <summary>
        /// <para>The following items describe the types of permissions that can be granted based on the resource type:</para>
        /// <list type="bullet">
        /// <item><description>Topic: Pub, Sub, and Pub|Sub</description></item>
        /// <item><description>Consumer group: Sub</description></item>
        /// </list>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SUB: subscribe</description></item>
        /// <item><description>Pub|Sub: publish and subscribe</description></item>
        /// <item><description>Pub: publish</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Pub</para>
        /// </summary>
        [NameInMap("actions")]
        [Validation(Required=false)]
        public string Actions { get; set; }

        /// <summary>
        /// <para>The decision result of the authorization.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Deny</description></item>
        /// <item><description>Allow</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Allow</para>
        /// </summary>
        [NameInMap("decision")]
        [Validation(Required=false)]
        public string Decision { get; set; }

        /// <summary>
        /// <para>The IP address whitelists.</para>
        /// </summary>
        [NameInMap("ipWhitelists")]
        [Validation(Required=false)]
        public List<string> IpWhitelists { get; set; }

        /// <summary>
        /// <para>The name of the resource on which you want to grant permissions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("resourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// <para>The type of the resource on which you want to grant permissions.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Group</description></item>
        /// <item><description>Topic</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Topic</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
