// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeUserBuyVersionRequest : TeaModel {
        /// <summary>
        /// <para>Instance ID. If the Instance ID is provided, the query will be based on this ID. If not provided, the latest instance will be queried by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cfw_elasticity_public_cn-*******</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
