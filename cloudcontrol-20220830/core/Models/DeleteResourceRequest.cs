// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudcontrol20220830.Models
{
    public class DeleteResourceRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. If a cloud service supports idempotence, the parameter takes effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1e810dfe1468721d0664a49b9d9f74f4</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("filter")]
        [Validation(Required=false)]
        public Dictionary<string, object> Filter { get; set; }

        /// <summary>
        /// <para>The region. This parameter is required if a cloud service is a regionalized.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
