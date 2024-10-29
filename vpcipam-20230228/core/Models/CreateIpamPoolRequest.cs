// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcIpam20230228.Models
{
    public class CreateIpamPoolRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>28</para>
        /// </summary>
        [NameInMap("AllocationDefaultCidrMask")]
        [Validation(Required=false)]
        public int? AllocationDefaultCidrMask { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("AllocationMaxCidrMask")]
        [Validation(Required=false)]
        public int? AllocationMaxCidrMask { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("AllocationMinCidrMask")]
        [Validation(Required=false)]
        public int? AllocationMinCidrMask { get; set; }

        [NameInMap("AutoImport")]
        [Validation(Required=false)]
        public bool? AutoImport { get; set; }

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
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test description</para>
        /// </summary>
        [NameInMap("IpamPoolDescription")]
        [Validation(Required=false)]
        public string IpamPoolDescription { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("IpamPoolName")]
        [Validation(Required=false)]
        public string IpamPoolName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipam-scope-glfmcyldpm8lsy****</para>
        /// </summary>
        [NameInMap("IpamScopeId")]
        [Validation(Required=false)]
        public string IpamScopeId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("PoolRegionId")]
        [Validation(Required=false)]
        public string PoolRegionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ipam-pool-6rcq3tobayc20t****</para>
        /// </summary>
        [NameInMap("SourceIpamPoolId")]
        [Validation(Required=false)]
        public string SourceIpamPoolId { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateIpamPoolRequestTag> Tag { get; set; }
        public class CreateIpamPoolRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
