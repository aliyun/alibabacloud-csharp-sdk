// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ModifyDBClusterRequest : TeaModel {
        /// <summary>
        /// <para>The reserved computing resources. Valid values: 0ACU to 4096ACU. The value must be in increments of 16ACU. Each ACU is approximately equal to 1 core and 4 GB memory.</para>
        /// <remarks>
        /// <para> This parameter must be specified with a unit.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>16ACU</para>
        /// </summary>
        [NameInMap("ComputeResource")]
        [Validation(Required=false)]
        public string ComputeResource { get; set; }

        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/454250.html">DescribeDBClusters</a> operation to query the IDs of all AnalyticDB for MySQL Data Lakehouse Edition (V3.0) clusters within a region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp1r053byu48p****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to allocate all reserved computing resources to the user_default resource group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default)</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableDefaultResourcePool")]
        [Validation(Required=false)]
        public bool? EnableDefaultResourcePool { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>LegacyForm</para>
        /// </summary>
        [NameInMap("ProductForm")]
        [Validation(Required=false)]
        public string ProductForm { get; set; }

        /// <summary>
        /// <para>The region ID of the cluster.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/454314.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ReservedNodeCount")]
        [Validation(Required=false)]
        public int? ReservedNodeCount { get; set; }

        [NameInMap("ReservedNodeSize")]
        [Validation(Required=false)]
        public string ReservedNodeSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The reserved storage resources. Valid values: 0ACU to 2064ACU. The value must be in increments of 24ACU. Each ACU is approximately equal to 1 core and 4 GB memory.</para>
        /// <remarks>
        /// <para> This parameter must be specified with a unit.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>24ACU</para>
        /// </summary>
        [NameInMap("StorageResource")]
        [Validation(Required=false)]
        public string StorageResource { get; set; }

    }

}
