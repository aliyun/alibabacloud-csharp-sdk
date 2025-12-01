// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class CreateBackupPlanRequest : TeaModel {
        /// <summary>
        /// <para>The backup method of the backup schedule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>logical</b>: logical backup</description></item>
        /// <item><description><b>physical</b>: physical backup</description></item>
        /// <item><description><b>duplication</b>: dump backup</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>logical</para>
        /// </summary>
        [NameInMap("BackupMethod")]
        [Validation(Required=false)]
        public string BackupMethod { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KJSAHKJFHKJSHFKASHFKJADFHKDXXXX</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The region in which the database you want to back up resides.</para>
        /// <remarks>
        /// <para>This parameter is required if the <b>PayType</b> parameter is set to <b>postpay</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DatabaseRegion")]
        [Validation(Required=false)]
        public string DatabaseRegion { get; set; }

        /// <summary>
        /// <para>The type of the source database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b></description></item>
        /// <item><description><b>MSSQL</b></description></item>
        /// <item><description><b>Oracle</b></description></item>
        /// <item><description><b>MariaDB</b></description></item>
        /// <item><description><b>PostgreSQL</b></description></item>
        /// <item><description><b>DRDS</b></description></item>
        /// <item><description><b>MongoDB</b></description></item>
        /// <item><description><b>Redis</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DatabaseType")]
        [Validation(Required=false)]
        public string DatabaseType { get; set; }

        /// <summary>
        /// <para>The source of the request. The default value is OpenAPI and cannot be changed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OpenAPI</para>
        /// </summary>
        [NameInMap("FromApp")]
        [Validation(Required=false)]
        public string FromApp { get; set; }

        /// <summary>
        /// <para>The type of the backup schedule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>micro</b></description></item>
        /// <item><description><b>small</b></description></item>
        /// <item><description><b>medium</b></description></item>
        /// <item><description><b>large</b></description></item>
        /// <item><description><b>xlarge</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> A backup schedule type with higher specifications offers higher backup and restoration performance. For more information, see <a href="https://help.aliyun.com/document_detail/84372.html">Select a backup schedule type</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>micro</para>
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// <para>The type of the source database instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RDS</b>: ApsaraDB RDS.</description></item>
        /// <item><description><b>PolarDB</b>: PolarDB.</description></item>
        /// <item><description><b>DDS</b>: ApsaraDB for MongoDB.</description></item>
        /// <item><description><b>Kvstore</b>: ApsaraDB for Redis.</description></item>
        /// <item><description><b>Other</b>: Database connected by using an IP address and a port number.</description></item>
        /// <item><description><b>dg</b>: Self-managed database that has no public IP address or port number and is connected over Database Gateway.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If <b>PayType</b> is set to <b>postpay</b>, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The billing method of the backup schedule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>postpay</b>: pay-as-you-go</description></item>
        /// <item><description><b>prepay</b>: subscription</description></item>
        /// </list>
        /// <remarks>
        /// <para>The default value is <b>prepay</b>. If the <b>BackupMethod</b> parameter is set to <b>duplication</b>, <b>postpay</b> is supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>prepay</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The unit of the subscription period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Year</b>: yearly subscription</description></item>
        /// <item><description><b>Month</b>: monthly subscription</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The ID of the region in which you can activate Data Disaster Recovery. You can call the <a href="https://help.aliyun.com/document_detail/2869853.html">DescribeRegions</a> operation to query the regions supported by Data Disaster Recovery.</para>
        /// <remarks>
        /// <para> For more information, see <a href="https://help.aliyun.com/document_detail/2869810.html">Endpoints</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzecovzti****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The region in which you want to store the backup data.</para>
        /// <remarks>
        /// <para>This parameter is required if the <b>PayType</b> parameter is set to <b>postpay</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("StorageRegion")]
        [Validation(Required=false)]
        public string StorageRegion { get; set; }

        /// <summary>
        /// <para>This parameter is unavailable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>N/A</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The subscription period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>Period</b> is set to <b>Year</b>, the valid values of <b>UsedTime</b> range from 1 to 5.</description></item>
        /// <item><description>If <b>Period</b> is set to <b>Month</b>, the valid values of <b>UsedTime</b> range from 1 to 11.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public int? UsedTime { get; set; }

    }

}
