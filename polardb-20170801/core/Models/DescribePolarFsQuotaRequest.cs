// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribePolarFsQuotaRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>To find the cluster ID for enterprise, basic, or data lakehouse edition clusters, call the <a href="https://help.aliyun.com/document_detail/2319131.html">DescribeDBClusters</a> operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The destination path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/data</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>The PolarFS instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pfs-2ze0i74ka607*****</para>
        /// </summary>
        [NameInMap("PolarFsInstanceId")]
        [Validation(Required=false)]
        public string PolarFsInstanceId { get; set; }

        /// <summary>
        /// <para>The quota type to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quotaPolicy</para>
        /// </summary>
        [NameInMap("QuotaType")]
        [Validation(Required=false)]
        public string QuotaType { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/98041.html">DescribeRegions</a> operation to find the IDs of all available regions in your account.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
