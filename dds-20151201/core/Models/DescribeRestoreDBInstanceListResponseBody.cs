// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeRestoreDBInstanceListResponseBody : TeaModel {
        [NameInMap("DBInstances")]
        [Validation(Required=false)]
        public DescribeRestoreDBInstanceListResponseBodyDBInstances DBInstances { get; set; }
        public class DescribeRestoreDBInstanceListResponseBodyDBInstances : TeaModel {
            [NameInMap("DBInstance")]
            [Validation(Required=false)]
            public List<DescribeRestoreDBInstanceListResponseBodyDBInstancesDBInstance> DBInstance { get; set; }
            public class DescribeRestoreDBInstanceListResponseBodyDBInstancesDBInstance : TeaModel {
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("DBInstanceDescription")]
                [Validation(Required=false)]
                public string DBInstanceDescription { get; set; }

                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                [NameInMap("DBInstanceStatus")]
                [Validation(Required=false)]
                public string DBInstanceStatus { get; set; }

                [NameInMap("DBInstanceType")]
                [Validation(Required=false)]
                public string DBInstanceType { get; set; }

                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                [NameInMap("HiddenZoneId")]
                [Validation(Required=false)]
                public string HiddenZoneId { get; set; }

                [NameInMap("IsDeleted")]
                [Validation(Required=false)]
                public int? IsDeleted { get; set; }

                [NameInMap("LockMode")]
                [Validation(Required=false)]
                public string LockMode { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("SecondaryZoneId")]
                [Validation(Required=false)]
                public string SecondaryZoneId { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AF0AD89-ED4F-44AD-B65F-BFC1D5Cxxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of instances in the query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
