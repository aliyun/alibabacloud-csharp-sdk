// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ModifyDBClusterRequest : TeaModel {
        [NameInMap("AINodeNumber")]
        [Validation(Required=false)]
        public int? AINodeNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ADB.MLPlus.4</para>
        /// </summary>
        [NameInMap("AINodeSpec")]
        [Validation(Required=false)]
        public string AINodeSpec { get; set; }

        /// <summary>
        /// <para>The compute reserved resources. Valid values: 0 ACU to 4096 ACU, in increments of 16. 1 ACU is approximately equivalent to 1 core and 4 GB of memory.</para>
        /// <remarks>
        /// <para>Include the unit when you specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>16ACU</para>
        /// </summary>
        [NameInMap("ComputeResource")]
        [Validation(Required=false)]
        public string ComputeResource { get; set; }

        /// <summary>
        /// <para>The ID of the Data Lakehouse Edition cluster.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/454250.html">DescribeDBClusters</a> operation to query the cluster ID of a Data Lakehouse Edition cluster.</para>
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
        /// <para>Specifies whether to allocate all compute reserved resources to the default resource group (user_default). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default): All compute reserved resources are allocated to the default resource group.</description></item>
        /// <item><description>false: Not all compute reserved resources are allocated to the default resource group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableDefaultResourcePool")]
        [Validation(Required=false)]
        public bool? EnableDefaultResourcePool { get; set; }

        /// <summary>
        /// <para>The product form. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IntegrationForm</b>: integrated form.</description></item>
        /// <item><description><b>LegacyForm</b>: Data Lakehouse Edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>LegacyForm</para>
        /// </summary>
        [NameInMap("ProductForm")]
        [Validation(Required=false)]
        public string ProductForm { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/454314.html">DescribeRegions</a> operation to query the region ID of a specified Data Lakehouse Edition cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The number of reserved nodes. </para>
        /// <list type="bullet">
        /// <item><description>Enterprise Edition: The default value is 3. The value increases in increments of 3.</description></item>
        /// <item><description>Basic Edition: The default value is 1.<remarks>
        /// <para>This parameter is required only when ProductForm is set to IntegrationForm.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ReservedNodeCount")]
        [Validation(Required=false)]
        public int? ReservedNodeCount { get; set; }

        /// <summary>
        /// <para>The node specifications of storage reserved resources. Valid values: 8ACU, 12ACU, and 16ACU.</para>
        /// <remarks>
        /// <para>Include the unit when you specify this parameter. This parameter is required only when ProductForm is set to IntegrationForm.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8ACU</para>
        /// </summary>
        [NameInMap("ReservedNodeSize")]
        [Validation(Required=false)]
        public string ReservedNodeSize { get; set; }

        /// <summary>
        /// <para>The storage reserved resources. Valid values: 0 ACU to 2064 ACU, in increments of 24. 1 ACU is approximately equivalent to 1 core and 4 GB of memory.</para>
        /// <remarks>
        /// <para>Include the unit when you specify this parameter.</para>
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
