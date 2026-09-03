// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ADBAI20250812.Models
{
    public class CreateMultiModelKnowledgeBaseRequest : TeaModel {
        [NameInMap("AdbInstanceName")]
        [Validation(Required=false)]
        public string AdbInstanceName { get; set; }

        /// <summary>
        /// <para>The instance cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp11q28kvl688****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("DbClusterAcu")]
        [Validation(Required=false)]
        public int? DbClusterAcu { get; set; }

        [NameInMap("LakeStorageBucketName")]
        [Validation(Required=false)]
        public string LakeStorageBucketName { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>You can call the DescribeRegions operation to query the region ID of a specified Data Lakehouse Edition cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceAcuMax")]
        [Validation(Required=false)]
        public int? ResourceAcuMax { get; set; }

        [NameInMap("ResourceAcuMin")]
        [Validation(Required=false)]
        public int? ResourceAcuMin { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
