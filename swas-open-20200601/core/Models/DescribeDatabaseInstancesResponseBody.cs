// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeDatabaseInstancesResponseBody : TeaModel {
        /// <summary>
        /// The information about the Simple Database Service instances.
        /// </summary>
        [NameInMap("DatabaseInstances")]
        [Validation(Required=false)]
        public List<DescribeDatabaseInstancesResponseBodyDatabaseInstances> DatabaseInstances { get; set; }
        public class DescribeDatabaseInstancesResponseBodyDatabaseInstances : TeaModel {
            /// <summary>
            /// The business status of the instance. Valid values:
            /// 
            /// *   normal
            /// *   expired
            /// *   overdue
            /// </summary>
            [NameInMap("BusinessStatus")]
            [Validation(Required=false)]
            public string BusinessStatus { get; set; }

            /// <summary>
            /// The billing method of the Simple Database Service instance. Set the value to PrePaid. This value indicates the subscription billing method.
            /// 
            /// Default value: PrePaid.
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// The number of vCPUs.
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public string Cpu { get; set; }

            /// <summary>
            /// The time when the instance was created. The time follows the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The plan edition ID of the Simple Database Service instance. Valid values:
            /// 
            /// *   swas.db.c1m1s25: CNY 35/month.
            /// *   swas.db.c1m2s80: CNY 100/month.
            /// *   swas.db.c2m4s120: CNY 200/month.
            /// *   swas.db.c2m8s240: CNY 300/month.
            /// </summary>
            [NameInMap("DatabaseInstanceEdition")]
            [Validation(Required=false)]
            public string DatabaseInstanceEdition { get; set; }

            /// <summary>
            /// The ID of the Simple Database Service instance.
            /// </summary>
            [NameInMap("DatabaseInstanceId")]
            [Validation(Required=false)]
            public string DatabaseInstanceId { get; set; }

            /// <summary>
            /// The name of the Simple Database Service instance.
            /// </summary>
            [NameInMap("DatabaseInstanceName")]
            [Validation(Required=false)]
            public string DatabaseInstanceName { get; set; }

            /// <summary>
            /// The status of the Simple Database Service instance. Valid values:
            /// 
            /// *   Pending: The instance is being created.
            /// *   Restarting: The instance is being restarted.
            /// *   Running: The instance is running.
            /// *   Stopping: The instance is being stopped.
            /// *   Stopped: The instance is stopped.
            /// *   UPGRADING: The instance is being upgraded.
            /// *   DISABLED: The instance is disabled.
            /// </summary>
            [NameInMap("DatabaseInstanceStatus")]
            [Validation(Required=false)]
            public string DatabaseInstanceStatus { get; set; }

            /// <summary>
            /// The database engine version of the instance. Valid values:
            /// 
            /// *   5.7: MySQL 5.7.
            /// *   8.0: MySQL 8.0.
            /// </summary>
            [NameInMap("DatabaseVersion")]
            [Validation(Required=false)]
            public string DatabaseVersion { get; set; }

            /// <summary>
            /// The time when the instance expires. The time follows the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// 
            /// >  The time displayed in the Simple Application Server console is in the format of UTC+8.
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// The memory size of the instance. Unit: GB.
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public string Memory { get; set; }

            /// <summary>
            /// The private endpoint.
            /// </summary>
            [NameInMap("PrivateConnection")]
            [Validation(Required=false)]
            public string PrivateConnection { get; set; }

            /// <summary>
            /// The public endpoint.
            /// 
            /// >  This parameter is displayed only after you apply for a public endpoint for the instance and a public endpoint is assigned to the instance. You can call [AllocatePublicConnection](https://help.aliyun.com/document_detail/451413.html) to apply for a public endpoint for the instance.
            /// </summary>
            [NameInMap("PublicConnection")]
            [Validation(Required=false)]
            public string PublicConnection { get; set; }

            /// <summary>
            /// The region ID of the Simple Database Service instances.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The size of the enhanced SSD (ESSD). Unit: GB.
            /// </summary>
            [NameInMap("Storage")]
            [Validation(Required=false)]
            public int? Storage { get; set; }

            /// <summary>
            /// The name of the super administrator account of the Simple Database Service instance.
            /// </summary>
            [NameInMap("SuperAccountName")]
            [Validation(Required=false)]
            public string SuperAccountName { get; set; }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
