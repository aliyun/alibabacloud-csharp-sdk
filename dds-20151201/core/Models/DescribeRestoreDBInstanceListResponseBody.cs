// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeRestoreDBInstanceListResponseBody : TeaModel {
        /// <summary>
        /// <para>DB instances list.</para>
        /// </summary>
        [NameInMap("DBInstances")]
        [Validation(Required=false)]
        public DescribeRestoreDBInstanceListResponseBodyDBInstances DBInstances { get; set; }
        public class DescribeRestoreDBInstanceListResponseBodyDBInstances : TeaModel {
            [NameInMap("DBInstance")]
            [Validation(Required=false)]
            public List<DescribeRestoreDBInstanceListResponseBodyDBInstancesDBInstance> DBInstance { get; set; }
            public class DescribeRestoreDBInstanceListResponseBodyDBInstancesDBInstance : TeaModel {
                /// <summary>
                /// <para>The time of instance creation, formatted as <i>yyyy-MM-dd</i>T<i>HH:00:00</i>Z (UTC time).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-01-02T07:43:59Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The description of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-database</para>
                /// </summary>
                [NameInMap("DBInstanceDescription")]
                [Validation(Required=false)]
                public string DBInstanceDescription { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dds-bp12c5b040dc****</para>
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// <para>The status of the instance. For more information, see <a href="https://help.aliyun.com/document_detail/63870.html">Instance states</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("DBInstanceStatus")]
                [Validation(Required=false)]
                public string DBInstanceStatus { get; set; }

                /// <summary>
                /// <para>The architecture of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>sharding</b>: sharded cluster instance</description></item>
                /// <item><description><b>replicate</b>: replica set or standalone instance</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>replicate</para>
                /// </summary>
                [NameInMap("DBInstanceType")]
                [Validation(Required=false)]
                public string DBInstanceType { get; set; }

                /// <summary>
                /// <para>The database engine version of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>7.0</b></description></item>
                /// <item><description><b>6.0</b></description></item>
                /// <item><description><b>5.0</b></description></item>
                /// <item><description><b>4.4</b></description></item>
                /// <item><description><b>4.2</b></description></item>
                /// <item><description><b>4.0</b></description></item>
                /// <item><description><b>3.4</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>4.2</para>
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// <para>The secondary availability zone 2 for the instance when implementing multi-AZ deployment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-h</para>
                /// </summary>
                [NameInMap("HiddenZoneId")]
                [Validation(Required=false)]
                public string HiddenZoneId { get; set; }

                /// <summary>
                /// <para>Specifies whether the instance is deleted. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: not deleted</description></item>
                /// <item><description><b>1</b>: deleted</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IsDeleted")]
                [Validation(Required=false)]
                public int? IsDeleted { get; set; }

                /// <summary>
                /// <para>The locked state of the instance, value description:</para>
                /// <list type="bullet">
                /// <item><description>Unlock: Normal.</description></item>
                /// <item><description>ManualLock: Manually triggered lock.</description></item>
                /// <item><description>LockByExpiration: Automatically locked due to expiration.</description></item>
                /// <item><description>LockByRestoration: Automatically locked before restoration.</description></item>
                /// <item><description>LockByDiskQuota: Automatically locked due to disk quota exceeded.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Unlock</para>
                /// </summary>
                [NameInMap("LockMode")]
                [Validation(Required=false)]
                public string LockMode { get; set; }

                /// <summary>
                /// <para>The region ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The secondary availability zone 1 for the instance when implementing multi-AZ deployment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-i</para>
                /// </summary>
                [NameInMap("SecondaryZoneId")]
                [Validation(Required=false)]
                public string SecondaryZoneId { get; set; }

                /// <summary>
                /// <para>The zone ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-g</para>
                /// </summary>
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
