// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ListClassesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of instance type information.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<ListClassesResponseBodyItems> Items { get; set; }
        public class ListClassesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The instance type code. For more information, see <a href="https://help.aliyun.com/document_detail/26312.html">Primary instance types</a> and <a href="https://help.aliyun.com/document_detail/145759.html">Read-only instance types</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysql.n1.micro.1</para>
            /// </summary>
            [NameInMap("ClassCode")]
            [Validation(Required=false)]
            public string ClassCode { get; set; }

            /// <summary>
            /// <para>The instance family. For more information, see <a href="https://help.aliyun.com/document_detail/57184.html">Instance families</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>general-purpose</para>
            /// </summary>
            [NameInMap("ClassGroup")]
            [Validation(Required=false)]
            public string ClassGroup { get; set; }

            /// <summary>
            /// <para>The number of CPU cores for the instance type. Unit: cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public string Cpu { get; set; }

            /// <summary>
            /// <para>The encrypted memory size for the security-enhanced instance family. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("EncryptedMemory")]
            [Validation(Required=false)]
            public string EncryptedMemory { get; set; }

            /// <summary>
            /// <para>The architecture type of the instance type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>If the instance uses the <b>x86</b> architecture, this parameter is empty by default.</description></item>
            /// <item><description>If the instance uses the <b>arm</b> architecture, <b>arm</b> is returned.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>arm</para>
            /// </summary>
            [NameInMap("InstructionSetArch")]
            [Validation(Required=false)]
            public string InstructionSetArch { get; set; }

            /// <summary>
            /// <para>The maximum number of connections for the instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("MaxConnections")]
            [Validation(Required=false)]
            public string MaxConnections { get; set; }

            /// <summary>
            /// <para>The maximum I/O bandwidth for the instance type. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024Mbps</para>
            /// </summary>
            [NameInMap("MaxIOMBPS")]
            [Validation(Required=false)]
            public string MaxIOMBPS { get; set; }

            /// <summary>
            /// <para>The maximum IOPS for the instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("MaxIOPS")]
            [Validation(Required=false)]
            public string MaxIOPS { get; set; }

            /// <summary>
            /// <para>The memory size for the instance type. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1GB</para>
            /// </summary>
            [NameInMap("MemoryClass")]
            [Validation(Required=false)]
            public string MemoryClass { get; set; }

            /// <summary>
            /// <para>The price for the instance type.</para>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <list type="bullet">
            /// <item><description>Unit: cents (CNY).</description></item>
            /// </list>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <list type="bullet">
            /// <item><description>Unit: cents (USD).</description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>If you set the <b>CommodityCode</b> parameter to a pay-as-you-go commodity code, this parameter indicates the hourly price.</description></item>
            /// <item><description>If you set the <b>CommodityCode</b> parameter to a subscription commodity code, this parameter indicates the monthly price.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2500</para>
            /// </summary>
            [NameInMap("ReferencePrice")]
            [Validation(Required=false)]
            public string ReferencePrice { get; set; }

            /// <summary>
            /// <para>The instance edition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Regular instances<list type="bullet">
            /// <item><description><b>Basic</b>: Basic Edition.</description></item>
            /// <item><description><b>HighAvailability</b>: High availability series.</description></item>
            /// <item><description><b>cluster</b>: MySQL or PostgreSQL Cluster Edition.</description></item>
            /// <item><description><b>AlwaysOn</b>: SQL Server Cluster Edition.</description></item>
            /// <item><description><b>Finance</b>: RDS Enterprise Edition.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description>Serverless instances<list type="bullet">
            /// <item><description><b>serverless_basic</b>: Serverless Basic Edition. (Applicable only to MySQL and PostgreSQL)</description></item>
            /// <item><description><b>serverless_standard</b>: Serverless high availability series. (Applicable only to MySQL and PostgreSQL)</description></item>
            /// <item><description><b>serverless_ha</b>: SQL Server Serverless high availability series.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Basic</para>
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The instance storage type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd</para>
            /// </summary>
            [NameInMap("storageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

        }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CF8D35BF-263D-4F7B-883A-1163B79A9EC6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
