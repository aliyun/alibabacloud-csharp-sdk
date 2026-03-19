// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class CreateBackupPlanRequest : TeaModel {
        /// <summary>
        /// <para>The backup method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>logical</b>: logical backup</para>
        /// </description></item>
        /// <item><description><para><b>physical</b>: physical backup</para>
        /// </description></item>
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
        /// <para>A client token that is used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KJSAHKJFHKJSHFKASHFKJADFHKDXXXX</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The region of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DatabaseRegion")]
        [Validation(Required=false)]
        public string DatabaseRegion { get; set; }

        /// <summary>
        /// <para>The database type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>MySQL</b></para>
        /// </description></item>
        /// <item><description><para><b>MSSQL</b></para>
        /// </description></item>
        /// <item><description><para><b>Oracle</b></para>
        /// </description></item>
        /// <item><description><para><b>MariaDB</b></para>
        /// </description></item>
        /// <item><description><para><b>PostgreSQL</b></para>
        /// </description></item>
        /// <item><description><para><b>DRDS</b></para>
        /// </description></item>
        /// <item><description><para><b>MongoDB</b></para>
        /// </description></item>
        /// <item><description><para><b>Redis</b></para>
        /// </description></item>
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
        /// <para>The source of the request. The default value is OpenAPI. You do not need to set this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OpenAPI</para>
        /// </summary>
        [NameInMap("FromApp")]
        [Validation(Required=false)]
        public string FromApp { get; set; }

        /// <summary>
        /// <para>The instance class. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>micro</b>: Entry</para>
        /// </description></item>
        /// <item><description><para><b>small</b>: Basic</para>
        /// </description></item>
        /// <item><description><para><b>medium</b>: Standard</para>
        /// </description></item>
        /// <item><description><para><b>large</b>: Enhanced</para>
        /// </description></item>
        /// <item><description><para><b>xlarge</b>: Enhanced (no traffic limit)</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The higher the instance class, the better the performance of backup and recovery. For more information, see <a href="https://help.aliyun.com/document_detail/84372.html">Specifications</a>.</para>
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
        /// <para>The database instance type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>RDS</b></para>
        /// </description></item>
        /// <item><description><para><b>PolarDB</b></para>
        /// </description></item>
        /// <item><description><para><b>DDS</b>: Alibaba Cloud MongoDB</para>
        /// </description></item>
        /// <item><description><para><b>Kvstore</b>: Alibaba Cloud Redis</para>
        /// </description></item>
        /// <item><description><para><b>Other</b>: A database that is connected over the Internet.</para>
        /// </description></item>
        /// <item><description><para><b>dg</b>: A self-managed database without a public IP address and port that is connected through Database Gateway (DG).</para>
        /// </description></item>
        /// </list>
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
        /// <para>The payment method. Valid value:</para>
        /// <para><b>prepay</b>: subscription</para>
        /// 
        /// <b>Example:</b>
        /// <para>prepay</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The billing cycle of the subscription instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Year</b></para>
        /// </description></item>
        /// <item><description><para><b>Month</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The region ID of the DBS instance. This parameter is required. Call the <a href="https://help.aliyun.com/document_detail/2869853.html">DescribeRegions</a> operation to view the regions that DBS supports.</para>
        /// <remarks>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/2869810.html">Endpoints</a>.</para>
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
        /// <para>The storage region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("StorageRegion")]
        [Validation(Required=false)]
        public string StorageRegion { get; set; }

        /// <summary>
        /// <para>This parameter is not used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The subscription duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If you set the <b>Period</b> parameter to <b>Year</b>, the value of <b>UsedTime</b> can be 1 to 5.</para>
        /// </description></item>
        /// <item><description><para>If you set the <b>Period</b> parameter to <b>Month</b>, the value of <b>UsedTime</b> can be 1 to 11.</para>
        /// </description></item>
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
