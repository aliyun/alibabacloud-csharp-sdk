// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tablestore20201209.Models
{
    public class UpdateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The alias of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance-test</para>
        /// </summary>
        [NameInMap("AliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

        /// <summary>
        /// <para>The description of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>the test instance</para>
        /// </summary>
        [NameInMap("InstanceDescription")]
        [Validation(Required=false)]
        public string InstanceDescription { get; set; }

        /// <summary>
        /// <para>The name of the instance whose information you want to update.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance-test</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>(Deprecated) The network type of the instance. Valid values: NORMAL and VPC_CONSOLE. Default value: NORMAL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("Network")]
        [Validation(Required=false)]
        public string Network { get; set; }

        /// <summary>
        /// <para>The new sources of the network from which access is allowed. By default, all sources of networks are allowed. Valid value:</para>
        /// <para>TRUST_PROXY: the console</para>
        /// </summary>
        [NameInMap("NetworkSourceACL")]
        [Validation(Required=false)]
        public List<string> NetworkSourceACL { get; set; }

        /// <summary>
        /// <para>The new types of the network from which access is allowed. By default, all types of networks are allowed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>INTERNET: the Internet</description></item>
        /// <item><description>VPC: VPCs</description></item>
        /// <item><description>CLASSIC: the classic network</description></item>
        /// </list>
        /// </summary>
        [NameInMap("NetworkTypeACL")]
        [Validation(Required=false)]
        public List<string> NetworkTypeACL { get; set; }

    }

}
