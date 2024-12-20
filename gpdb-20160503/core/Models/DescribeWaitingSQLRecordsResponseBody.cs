// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeWaitingSQLRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of lock diagnostics records.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeWaitingSQLRecordsResponseBodyItems> Items { get; set; }
        public class DescribeWaitingSQLRecordsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            /// <summary>
            /// <para>The ID of the process that uniquely identifies the query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PID")]
            [Validation(Required=false)]
            public string PID { get; set; }

            /// <summary>
            /// <para>The SQL statement of the query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Select * from t1,t2 where t1.id=t2.id;</para>
            /// </summary>
            [NameInMap("SQLStmt")]
            [Validation(Required=false)]
            public string SQLStmt { get; set; }

            /// <summary>
            /// <para>The ID of the session that contains the query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("SessionID")]
            [Validation(Required=false)]
            public string SessionID { get; set; }

            /// <summary>
            /// <para>The start time of the query. This value is in the timestamp format. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1660902033374</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The waiting state of the query. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>LockWaiting</b></description></item>
            /// <item><description><b>ResourceWaiting</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>LockWaiting</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The database account that is used to perform the query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testUser</para>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

            /// <summary>
            /// <para>The waiting period of the query. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>26911000</para>
            /// </summary>
            [NameInMap("WaitingTime")]
            [Validation(Required=false)]
            public long? WaitingTime { get; set; }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4CAF581-2AC7-41AD-8940-D56DF7AADF5B</para>
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
        public int? TotalCount { get; set; }

    }

}
