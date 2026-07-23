// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class UpdateRecallManagementConfigRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The network configuration.</para>
        /// </summary>
        [NameInMap("NetworkConfigs")]
        [Validation(Required=false)]
        public List<UpdateRecallManagementConfigRequestNetworkConfigs> NetworkConfigs { get; set; }
        public class UpdateRecallManagementConfigRequestNetworkConfigs : TeaModel {
            /// <summary>
            /// <para>The ID of the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-xxx</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>A map of availability zones to VSwitch IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("VswitchIds")]
            [Validation(Required=false)]
            public Dictionary<string, string> VswitchIds { get; set; }

        }

        /// <summary>
        /// <para>The password.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

    }

}
