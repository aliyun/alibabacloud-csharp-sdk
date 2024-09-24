// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeUniBackupDatabaseResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the information about the databases.</para>
        /// </summary>
        [NameInMap("DatabaseList")]
        [Validation(Required=false)]
        public List<DescribeUniBackupDatabaseResponseBodyDatabaseList> DatabaseList { get; set; }
        public class DescribeUniBackupDatabaseResponseBodyDatabaseList : TeaModel {
            /// <summary>
            /// <para>The status of the anti-ransomware agent. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>UNKNOWN</b>: unknown</description></item>
            /// <item><description><b>INSTALLED</b>: installed</description></item>
            /// <item><description><b>INSTALL_FAILED</b>: installation failed</description></item>
            /// <item><description><b>UNINSTALL_FAILED</b>: uninstallation failed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>INSTALLED</para>
            /// </summary>
            [NameInMap("AgentStatus")]
            [Validation(Required=false)]
            public string AgentStatus { get; set; }

            /// <summary>
            /// <para>The service from which the database is created. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>HBR</b>: HBR</description></item>
            /// <item><description><b>AEGIS</b>: Security Center</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AEGIS</para>
            /// </summary>
            [NameInMap("CreatedByProduct")]
            [Validation(Required=false)]
            public string CreatedByProduct { get; set; }

            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apns_tt180</para>
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// <para>The type of the database. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>MYSQL</b></description></item>
            /// <item><description><b>MSSQL</b></description></item>
            /// <item><description><b>Oracle</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MYSQL</para>
            /// </summary>
            [NameInMap("DatabaseType")]
            [Validation(Required=false)]
            public string DatabaseType { get; set; }

            /// <summary>
            /// <para>The version of the database engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12.0.4100.1</para>
            /// </summary>
            [NameInMap("DatabaseVersion")]
            [Validation(Required=false)]
            public string DatabaseVersion { get; set; }

            /// <summary>
            /// <para>The ID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp15aho9hhftvmhw****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the instance to which the database belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sql-test-001</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The UUID of the Hybrid Backup Recovery (HBR) agent that is used to back up the data of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>85878b284df911ec800000163e19****</para>
            /// </summary>
            [NameInMap("InstanceUuid")]
            [Validation(Required=false)]
            public string InstanceUuid { get; set; }

            /// <summary>
            /// <para>The ID of the anti-ransomware policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public long? PolicyId { get; set; }

            /// <summary>
            /// <para>The status of the ECS instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Stopped</b></description></item>
            /// <item><description><b>Running</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeUniBackupDatabaseResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeUniBackupDatabaseResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>09969D2C-4FAD-429E-BFBF-9A60DEF8****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
