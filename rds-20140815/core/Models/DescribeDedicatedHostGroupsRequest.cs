// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDedicatedHostGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The dedicated cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dhg-7a9xxxxxxxx</para>
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// <para>The host image based on which you want to query dedicated clusters. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>WindowsWithMssqlStdLicense</b>: Windows (with SQL Server Standard Edition license).</description></item>
        /// <item><description><b>WindowsWithMssqlEntLisence</b>: Windows (with SQL Server Enterprise Edition license).</description></item>
        /// <item><description><b>WindowsWithMssqlWebLisence</b>: Windows (with SQL Server Web Edition license).</description></item>
        /// <item><description><b>AliLinux</b>: Linux.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>WindowsWithMssqlStdLicense</para>
        /// </summary>
        [NameInMap("ImageCategory")]
        [Validation(Required=false)]
        public string ImageCategory { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the DescribeRegions operation to query available region IDs.</para>
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

    }

}
