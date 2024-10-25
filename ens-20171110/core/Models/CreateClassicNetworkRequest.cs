// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateClassicNetworkRequest : TeaModel {
        /// <summary>
        /// <para>The CIDR block of the network. You can use one of the following CIDR blocks or their subnets as the CIDR block of the network:</para>
        /// <list type="bullet">
        /// <item><description>10.0.0.0/8 (default)</description></item>
        /// <item><description>172.16.0.0/12</description></item>
        /// <item><description>192.168.0.0/16</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/16</para>
        /// </summary>
        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        /// <summary>
        /// <para>The description of the network. The name must be 2 to 256 characters in length. It must start with a letter but cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is my vswitch.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the edge node.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-chengdu-xxxx-4</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>The name of the network. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name must be 2 to 128 characters in length.</description></item>
        /// <item><description>The name must start with a letter but cannot start with http:// or https://.</description></item>
        /// <item><description>The name can contain letters, digits, colons (:), underscores (_), and hyphens (-).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("NetworkName")]
        [Validation(Required=false)]
        public string NetworkName { get; set; }

    }

}
