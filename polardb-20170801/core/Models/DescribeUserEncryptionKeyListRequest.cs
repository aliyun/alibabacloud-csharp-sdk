// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeUserEncryptionKeyListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98094.html">DescribeDBClusters</a> operation to query information about all clusters that are deployed in a specified region, such as the cluster ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pc-************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98041.html">DescribeRegions</a> operation to query all regions that are available for your account, such as the region ID.</para>
        /// </remarks>
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
        /// <para>The region where the TDE key resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("TDERegion")]
        [Validation(Required=false)]
        public string TDERegion { get; set; }

    }

}
