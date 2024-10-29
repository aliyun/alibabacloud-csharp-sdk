// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcIpam20230228.Models
{
    public class UpdateIpamPoolAllocationRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test description</para>
        /// </summary>
        [NameInMap("IpamPoolAllocationDescription")]
        [Validation(Required=false)]
        public string IpamPoolAllocationDescription { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipam-pool-alloc-112za33e4****</para>
        /// </summary>
        [NameInMap("IpamPoolAllocationId")]
        [Validation(Required=false)]
        public string IpamPoolAllocationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test name</para>
        /// </summary>
        [NameInMap("IpamPoolAllocationName")]
        [Validation(Required=false)]
        public string IpamPoolAllocationName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
