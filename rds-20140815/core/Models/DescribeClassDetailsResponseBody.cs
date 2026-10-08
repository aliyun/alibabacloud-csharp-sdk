// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeClassDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Basic</b>: Basic Edition</description></item>
        /// <item><description><b>HighAvailability</b>: High-availability Edition</description></item>
        /// <item><description><b>AlwaysOn</b>: Cluster Edition</description></item>
        /// <item><description><b>Finance</b>: RDS Enterprise Edition</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Basic</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The instance type code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql.n2.medium.1</para>
        /// </summary>
        [NameInMap("ClassCode")]
        [Validation(Required=false)]
        public string ClassCode { get; set; }

        /// <summary>
        /// <para>The instance family.</para>
        /// 
        /// <b>Example:</b>
        /// <para>x</para>
        /// </summary>
        [NameInMap("ClassGroup")]
        [Validation(Required=false)]
        public string ClassGroup { get; set; }

        /// <summary>
        /// <para>The number of CPU cores for the instance type. Unit: cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public string Cpu { get; set; }

        /// <summary>
        /// <para>The storage type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>local_ssd</b>: local SSD</description></item>
        /// <item><description><b>cloud_ssd</b>: standard SSD</description></item>
        /// <item><description><b>cloud_essd</b>: PL1 ESSD</description></item>
        /// <item><description><b>cloud_essd2</b>: PL2 ESSD</description></item>
        /// <item><description><b>cloud_essd3</b>: PL3 ESSD</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>local_ssd</para>
        /// </summary>
        [NameInMap("DBInstanceStorageType")]
        [Validation(Required=false)]
        public string DBInstanceStorageType { get; set; }

        /// <summary>
        /// <para>The architecture.</para>
        /// 
        /// <b>Example:</b>
        /// <para>x86</para>
        /// </summary>
        [NameInMap("InstructionSetArch")]
        [Validation(Required=false)]
        public string InstructionSetArch { get; set; }

        /// <summary>
        /// <para>The maximum number of connections.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4000</para>
        /// </summary>
        [NameInMap("MaxConnections")]
        [Validation(Required=false)]
        public string MaxConnections { get; set; }

        /// <summary>
        /// <para>The maximum I/O bandwidth for the instance type. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("MaxIOMBPS")]
        [Validation(Required=false)]
        public string MaxIOMBPS { get; set; }

        /// <summary>
        /// <para>The maximum IOPS for the instance type. Unit: operations per second.</para>
        /// 
        /// <b>Example:</b>
        /// <para>N/A</para>
        /// </summary>
        [NameInMap("MaxIOPS")]
        [Validation(Required=false)]
        public string MaxIOPS { get; set; }

        /// <summary>
        /// <para>The memory capacity. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2GB</para>
        /// </summary>
        [NameInMap("MemoryClass")]
        [Validation(Required=false)]
        public string MemoryClass { get; set; }

        /// <summary>
        /// <para>The price.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;Unit: cents (CNY).
        /// &lt;props=&quot;intl&quot;&gt;Unit: cents (USD).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you set the CommodityCode parameter to a pay-as-you-go commodity code, the hourly price is returned.</description></item>
        /// <item><description>If you set the CommodityCode parameter to a subscription commodity code, the monthly price is returned.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>13400</para>
        /// </summary>
        [NameInMap("ReferencePrice")]
        [Validation(Required=false)]
        public string ReferencePrice { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E9DD55F4-1A5F-48CA-BA57-DFB3CA8C4C34</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
