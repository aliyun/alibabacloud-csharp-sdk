// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeUserBuyVersionRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. If you specify an instance ID, the system queries the specified instance. If you leave this parameter empty, the system queries the most recent instance by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cfw_elasticity_public_cn-*******</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
