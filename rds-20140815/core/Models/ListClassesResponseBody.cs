// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ListClassesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of instance specifications.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<ListClassesResponseBodyItems> Items { get; set; }
        public class ListClassesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The code of the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/26312.html">Primary ApsaraDB RDS instance types</a> and <a href="https://help.aliyun.com/document_detail/145759.html">Read-only ApsaraDB RDS instance types</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysql.n1.micro.1</para>
            /// </summary>
            [NameInMap("ClassCode")]
            [Validation(Required=false)]
            public string ClassCode { get; set; }

            /// <summary>
            /// <para>The instance family. For more information, see <a href="https://help.aliyun.com/document_detail/57184.html">Overview of instance families</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>General</para>
            /// </summary>
            [NameInMap("ClassGroup")]
            [Validation(Required=false)]
            public string ClassGroup { get; set; }

            /// <summary>
            /// <para>The number of CPU cores that are supported by the instance type. Unit: cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public string Cpu { get; set; }

            /// <summary>
            /// <para>The size of the encrypted memory that is supported by the security-enhanced instance type. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("EncryptedMemory")]
            [Validation(Required=false)]
            public string EncryptedMemory { get; set; }

            /// <summary>
            /// <para>The architecture of the instance type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>If the architecture of the instance type is <b>x86</b>, an empty string is returned by default.</description></item>
            /// <item><description>If the architecture of the instance type is <b>ARM</b>, <b>arm</b> is returned.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>arm</para>
            /// </summary>
            [NameInMap("InstructionSetArch")]
            [Validation(Required=false)]
            public string InstructionSetArch { get; set; }

            /// <summary>
            /// <para>The maximum number of connections that are supported by the instance type. Unit: connections.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("MaxConnections")]
            [Validation(Required=false)]
            public string MaxConnections { get; set; }

            /// <summary>
            /// <para>The maximum I/O bandwidth that is supported by the instance type. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024Mbps</para>
            /// </summary>
            [NameInMap("MaxIOMBPS")]
            [Validation(Required=false)]
            public string MaxIOMBPS { get; set; }

            /// <summary>
            /// <para>The maximum input/output operations per second (IOPS) that is supported by the instance type. Unit: operations per second.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("MaxIOPS")]
            [Validation(Required=false)]
            public string MaxIOPS { get; set; }

            /// <summary>
            /// <para>The memory size that is supported by the instance type. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1 GB (RDS Basic Edition)</para>
            /// </summary>
            [NameInMap("MemoryClass")]
            [Validation(Required=false)]
            public string MemoryClass { get; set; }

            /// <summary>
            /// <para>The fee that you must pay for the instance type.</para>
            /// <list type="bullet">
            /// <item><description>Unit: cents (USD).</description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>If you set <b>CommodityCode</b> to a value that indicates the pay-as-you-go billing method, the ReferencePrice parameter specifies the hourly fee that you must pay.</description></item>
            /// <item><description>If you set <b>CommodityCode</b> to a value that indicates the subscription billing method, the ReferencePrice parameter specifies the monthly fee that you must pay.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2500</para>
            /// </summary>
            [NameInMap("ReferencePrice")]
            [Validation(Required=false)]
            public string ReferencePrice { get; set; }

            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("storageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CF8D35BF-263D-4F7B-883A-1163B79A9EC6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
