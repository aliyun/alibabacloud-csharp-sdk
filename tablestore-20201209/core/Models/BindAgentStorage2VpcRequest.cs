// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tablestore20201209.Models
{
    public class BindAgentStorage2VpcRequest : TeaModel {
        /// <summary>
        /// <para>The agent storage name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent-test</para>
        /// </summary>
        [NameInMap("AgentStorageName")]
        [Validation(Required=false)]
        public string AgentStorageName { get; set; }

        /// <summary>
        /// <para>The VPC name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>remua</para>
        /// </summary>
        [NameInMap("AgentStorageVpcName")]
        [Validation(Required=false)]
        public string AgentStorageVpcName { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6***********ez6ge</para>
        /// </summary>
        [NameInMap("VirtualSwitchId")]
        [Validation(Required=false)]
        public string VirtualSwitchId { get; set; }

        /// <summary>
        /// <para>VPC ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2ze***********g31n7</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
