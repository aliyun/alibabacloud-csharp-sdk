// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ADBAI20250812.Models
{
    public class CreateMultiModelKnowledgeBaseRequest : TeaModel {
        /// <summary>
        /// <para><b>[Deprecated]</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AdbInstanceName")]
        [Validation(Required=false)]
        public string AdbInstanceName { get; set; }

        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp11q28kvl688****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The number of ACUs for the AnalyticDB for MySQL instance resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("DbClusterAcu")]
        [Validation(Required=false)]
        public int? DbClusterAcu { get; set; }

        /// <summary>
        /// <para>The description of the multimodal knowledge base instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
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

        /// <summary>
        /// <para>The maximum number of ACUs for the multimodal knowledge base resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("ResourceAcuMax")]
        [Validation(Required=false)]
        public int? ResourceAcuMax { get; set; }

        /// <summary>
        /// <para>The minimum number of ACUs for the multimodal knowledge base resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("ResourceAcuMin")]
        [Validation(Required=false)]
        public int? ResourceAcuMin { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1ak7shaq72ywiah****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-uf66oesmrqge1t2gs****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The ID of the zone to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
