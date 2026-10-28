// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ModifyDBClusterRequest : TeaModel {
        /// <summary>
        /// <para>The number of AI nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("AINodeNumber")]
        [Validation(Required=false)]
        public int? AINodeNumber { get; set; }

        /// <summary>
        /// <para>The AI node specifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADB.MLPlus.4</para>
        /// </summary>
        [NameInMap("AINodeSpec")]
        [Validation(Required=false)]
        public string AINodeSpec { get; set; }

        /// <summary>
        /// <para>The reserved compute resources. Valid values: 0 ACU to 4096 ACU. Step: 16. 1 ACU is approximately equal to 1 core and 4 GB of memory.</para>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/454250.html">DescribeDBClusters</a> operation to query the ID of the Data Lakehouse Edition cluster.</para>
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
        /// <para>Specifies whether to allocate all reserved compute resources to the default resource group (user_default). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default): Yes.</description></item>
        /// <item><description>false: No.</description></item>
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
        /// <item><description><b>IntegrationForm</b>: Integration form.</description></item>
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
        /// <para>The target product version. When you switch from LegacyForm to IntegrationForm Enterprise Edition in-place, set this parameter to enterprise_version and specify ProductForm, ReservedNodeSize, and ReservedNodeCount at the same time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enterprise_version</para>
        /// </summary>
        [NameInMap("ProductVersion")]
        [Validation(Required=false)]
        public string ProductVersion { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/454314.html">DescribeRegions</a> operation to query the region ID of the specified Data Lakehouse Edition cluster.</para>
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
        /// <item><description>For Enterprise Edition, the default value is 3 and the step is 3.</description></item>
        /// <item><description>For Basic Edition, the default value is 1.<remarks>
        /// <para>Specify this parameter only when ProductForm is set to IntegrationForm.</para>
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
        /// <para>The node specifications for reserved storage resources. Valid values: 8 ACU, 12 ACU, and 16 ACU.</para>
        /// <remarks>
        /// <para>Include the unit when you specify this parameter. Specify this parameter only when ProductForm is set to IntegrationForm.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8ACU</para>
        /// </summary>
        [NameInMap("ReservedNodeSize")]
        [Validation(Required=false)]
        public string ReservedNodeSize { get; set; }

        /// <summary>
        /// <para>The reserved storage resources. Valid values: 0 ACU to 2064 ACU. Step: 24. 1 ACU is approximately equal to 1 core and 4 GB of memory.</para>
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
