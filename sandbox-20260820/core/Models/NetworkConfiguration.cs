// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class NetworkConfiguration : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>PUBLIC_AND_PRIVATE</para>
        /// </summary>
        [NameInMap("networkMode")]
        [Validation(Required=false)]
        public string NetworkMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sg-****</para>
        /// </summary>
        [NameInMap("securityGroupID")]
        [Validation(Required=false)]
        public string SecurityGroupID { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vpc-****</para>
        /// </summary>
        [NameInMap("vpcID")]
        [Validation(Required=false)]
        public string VpcID { get; set; }

        [NameInMap("vswitchIDs")]
        [Validation(Required=false)]
        public List<string> VswitchIDs { get; set; }

    }

}
