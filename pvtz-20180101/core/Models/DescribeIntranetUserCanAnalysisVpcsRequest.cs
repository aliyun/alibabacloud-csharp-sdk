// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeIntranetUserCanAnalysisVpcsRequest : TeaModel {
        /// <summary>
        /// <para>The network type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CLOUD</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The level in the query hierarchy. For example, you can query for VPCs that belong to a specific cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("QueryTreeLevel")]
        [Validation(Required=false)]
        public int? QueryTreeLevel { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The owner of the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1204673843521685</para>
        /// </summary>
        [NameInMap("VpcOwner")]
        [Validation(Required=false)]
        public long? VpcOwner { get; set; }

        /// <summary>
        /// <para>The VPC type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>STANDARD</para>
        /// </summary>
        [NameInMap("VpcType")]
        [Validation(Required=false)]
        public string VpcType { get; set; }

    }

}
