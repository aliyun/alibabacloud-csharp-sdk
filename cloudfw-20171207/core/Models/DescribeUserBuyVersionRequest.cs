// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeUserBuyVersionRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance. If you specify this parameter, the query is performed based on the instance ID. If you leave this parameter empty, the latest instance is queried by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cfw_elasticity_public_cn-*******</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
