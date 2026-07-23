// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class CreateRecallManagementConfigRequest : TeaModel {
        /// <summary>
        /// <para><b>The instance ID.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>learn-pairec-xxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para><b>The network configurations.</b></para>
        /// </summary>
        [NameInMap("NetworkConfigs")]
        [Validation(Required=false)]
        public List<CreateRecallManagementConfigRequestNetworkConfigs> NetworkConfigs { get; set; }
        public class CreateRecallManagementConfigRequestNetworkConfigs : TeaModel {
            /// <summary>
            /// <para>A map of availability zones to VSwitch IDs.</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public Dictionary<string, string> VSwitchIds { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-xxx</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para><b>The password.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para><b>The user name.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>zhhangsan</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
