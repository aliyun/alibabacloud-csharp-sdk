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
        /// <para>The image based on which the hosts in the dedicated clusters are created. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>WindowsWithMssqlStdLicense</b>: a Windows image that contains the licenses of SQL Server Standard Edition</description></item>
        /// <item><description><b>WindowsWithMssqlEntLisence</b>: a Windows image that contains the licenses of SQL Server Enterprise Edition</description></item>
        /// <item><description><b>WindowsWithMssqlWebLisence</b>: a Windows image that contains the licenses of SQL Server Web Edition</description></item>
        /// <item><description><b>AliLinux</b>: a Linux image</description></item>
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
        /// <para>The region ID. You can call the DescribeRegions operation to query the most recent region list.</para>
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
