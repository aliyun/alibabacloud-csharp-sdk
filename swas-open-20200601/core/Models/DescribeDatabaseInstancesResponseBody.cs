// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeDatabaseInstancesResponseBody : TeaModel {
        /// <summary>
        /// The name of the super administrator account of the Simple Database Service instance.
        /// </summary>
        [NameInMap("DatabaseInstances")]
        [Validation(Required=false)]
        public List<DescribeDatabaseInstancesResponseBodyDatabaseInstances> DatabaseInstances { get; set; }
        public class DescribeDatabaseInstancesResponseBodyDatabaseInstances : TeaModel {
            [NameInMap("BusinessStatus")]
            [Validation(Required=false)]
            public string BusinessStatus { get; set; }

            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public string Cpu { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("DatabaseInstanceEdition")]
            [Validation(Required=false)]
            public string DatabaseInstanceEdition { get; set; }

            [NameInMap("DatabaseInstanceId")]
            [Validation(Required=false)]
            public string DatabaseInstanceId { get; set; }

            [NameInMap("DatabaseInstanceName")]
            [Validation(Required=false)]
            public string DatabaseInstanceName { get; set; }

            [NameInMap("DatabaseInstanceStatus")]
            [Validation(Required=false)]
            public string DatabaseInstanceStatus { get; set; }

            [NameInMap("DatabaseVersion")]
            [Validation(Required=false)]
            public string DatabaseVersion { get; set; }

            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            [NameInMap("Memory")]
            [Validation(Required=false)]
            public string Memory { get; set; }

            [NameInMap("PrivateConnection")]
            [Validation(Required=false)]
            public string PrivateConnection { get; set; }

            [NameInMap("PublicConnection")]
            [Validation(Required=false)]
            public string PublicConnection { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("Storage")]
            [Validation(Required=false)]
            public int? Storage { get; set; }

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
