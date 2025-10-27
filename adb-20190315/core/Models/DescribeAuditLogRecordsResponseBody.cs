// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeAuditLogRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-t4nj8619bz2w3****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The queried SQL audit logs.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeAuditLogRecordsResponseBodyItems> Items { get; set; }
        public class DescribeAuditLogRecordsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>This parameter is unavailable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("ConnId")]
            [Validation(Required=false)]
            public string ConnId { get; set; }

            /// <summary>
            /// <para>The name of the database on which the SQL statement was executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>adb_test</para>
            /// </summary>
            [NameInMap("DBName")]
            [Validation(Required=false)]
            public string DBName { get; set; }

            /// <summary>
            /// <para>The start time of the execution of the SQL statement. The time is displayed in the ISO 8601 standard in the yyyy-MM-dd HH:mm:ss format. The time must be in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-23 16:05:08</para>
            /// </summary>
            [NameInMap("ExecuteTime")]
            [Validation(Required=false)]
            public string ExecuteTime { get; set; }

            [NameInMap("ExecuteTimestamp")]
            [Validation(Required=false)]
            public long? ExecuteTimestamp { get; set; }

            /// <summary>
            /// <para>The IP address and port number of the client that is used to execute the SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.104.XX.XX:43908</para>
            /// </summary>
            [NameInMap("HostAddress")]
            [Validation(Required=false)]
            public string HostAddress { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>202106081752021720161662490345362390</para>
            /// </summary>
            [NameInMap("ProcessID")]
            [Validation(Required=false)]
            public string ProcessID { get; set; }

            /// <summary>
            /// <para>Details of the SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT * FROM tb_courses</para>
            /// </summary>
            [NameInMap("SQLText")]
            [Validation(Required=false)]
            public string SQLText { get; set; }

            /// <summary>
            /// <para>The type of the SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT</para>
            /// </summary>
            [NameInMap("SQLType")]
            [Validation(Required=false)]
            public string SQLType { get; set; }

            /// <summary>
            /// <para>Indicates whether the SQL statement was successfully executed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Succeed")]
            [Validation(Required=false)]
            public string Succeed { get; set; }

            /// <summary>
            /// <para>The amount of time that is consumed to execute the SQL statement. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>216</para>
            /// </summary>
            [NameInMap("TotalTime")]
            [Validation(Required=false)]
            public string TotalTime { get; set; }

            /// <summary>
            /// <para>The name of the user who executed the SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_user</para>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8A564B7F-8C00-43C0-8EC5-919FBB70573</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
