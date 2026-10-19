// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeParameterGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The engine type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>redis</b>: open-source Redis or Tair (Memory-optimized).</description></item>
        /// <item><description><b>tair_pena</b>: Tair (Persistent Memory-optimized).</description></item>
        /// <item><description><b>tair_pdb</b>: Tair (Disk-optimized, ESSD/SSD).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>redis</para>
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        /// <summary>
        /// <para>The compatible engine version.</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/473763.html">DescribeRegions</a> operation to query the region ID.</para>
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

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
