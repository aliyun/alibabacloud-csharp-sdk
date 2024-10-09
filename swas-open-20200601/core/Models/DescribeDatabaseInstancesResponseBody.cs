// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeDatabaseInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the Simple Database Service instances.</para>
        /// </summary>
        [NameInMap("DatabaseInstances")]
        [Validation(Required=false)]
        public List<DescribeDatabaseInstancesResponseBodyDatabaseInstances> DatabaseInstances { get; set; }
        public class DescribeDatabaseInstancesResponseBodyDatabaseInstances : TeaModel {
            /// <summary>
            /// <para>The business status of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>normal</description></item>
            /// <item><description>expired</description></item>
            /// <item><description>overdue</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("BusinessStatus")]
            [Validation(Required=false)]
            public string BusinessStatus { get; set; }

            /// <summary>
            /// <para>The billing method of the Simple Database Service instance. Set the value to PrePaid. This value indicates the subscription billing method.</para>
            /// <para>Default value: PrePaid.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PrePaid</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The number of vCPUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public string Cpu { get; set; }

            /// <summary>
            /// <para>The time when the instance was created. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-01T02:39:46Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The plan edition ID of the Simple Database Service instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>swas.db.c1m1s25: CNY 35/month.</description></item>
            /// <item><description>swas.db.c1m2s80: CNY 100/month.</description></item>
            /// <item><description>swas.db.c2m4s120: CNY 200/month.</description></item>
            /// <item><description>swas.db.c2m8s240: CNY 300/month.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>swas.db.c1m1s25</para>
            /// </summary>
            [NameInMap("DatabaseInstanceEdition")]
            [Validation(Required=false)]
            public string DatabaseInstanceEdition { get; set; }

            /// <summary>
            /// <para>The ID of the Simple Database Service instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>db-38263fa955774501a2ae1bdaed6f****</para>
            /// </summary>
            [NameInMap("DatabaseInstanceId")]
            [Validation(Required=false)]
            public string DatabaseInstanceId { get; set; }

            /// <summary>
            /// <para>The name of the Simple Database Service instance.</para>
            /// </summary>
            [NameInMap("DatabaseInstanceName")]
            [Validation(Required=false)]
            public string DatabaseInstanceName { get; set; }

            /// <summary>
            /// <para>The status of the Simple Database Service instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pending: The instance is being created.</description></item>
            /// <item><description>Restarting: The instance is being restarted.</description></item>
            /// <item><description>Running: The instance is running.</description></item>
            /// <item><description>Stopping: The instance is being stopped.</description></item>
            /// <item><description>Stopped: The instance is stopped.</description></item>
            /// <item><description>UPGRADING: The instance is being upgraded.</description></item>
            /// <item><description>DISABLED: The instance is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("DatabaseInstanceStatus")]
            [Validation(Required=false)]
            public string DatabaseInstanceStatus { get; set; }

            /// <summary>
            /// <para>The database engine version of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>5.7: MySQL 5.7.</description></item>
            /// <item><description>8.0: MySQL 8.0.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5.7</para>
            /// </summary>
            [NameInMap("DatabaseVersion")]
            [Validation(Required=false)]
            public string DatabaseVersion { get; set; }

            /// <summary>
            /// <para>The time when the instance expires. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// <remarks>
            /// <para> The time displayed in the Simple Application Server console is in the format of UTC+8.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2022-10-01T16:00:00Z</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The memory size of the instance. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public string Memory { get; set; }

            /// <summary>
            /// <para>The private endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-bp1d39opj7906****.mysql.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("PrivateConnection")]
            [Validation(Required=false)]
            public string PrivateConnection { get; set; }

            /// <summary>
            /// <para>The public endpoint.</para>
            /// <remarks>
            /// <para> This parameter is displayed only after you apply for a public endpoint for the instance and a public endpoint is assigned to the instance. You can call <a href="https://help.aliyun.com/document_detail/451413.html">AllocatePublicConnection</a> to apply for a public endpoint for the instance.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>db-38263fa955774501a2ae1bdaed6f****.mysql.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("PublicConnection")]
            [Validation(Required=false)]
            public string PublicConnection { get; set; }

            /// <summary>
            /// <para>The region ID of the Simple Database Service instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The size of the enhanced SSD (ESSD). Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25</para>
            /// </summary>
            [NameInMap("Storage")]
            [Validation(Required=false)]
            public int? Storage { get; set; }

            /// <summary>
            /// <para>The name of the super administrator account of the Simple Database Service instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>administrator</para>
            /// </summary>
            [NameInMap("SuperAccountName")]
            [Validation(Required=false)]
            public string SuperAccountName { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20758A-585D-4A41-A9B2-28DA8F4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
