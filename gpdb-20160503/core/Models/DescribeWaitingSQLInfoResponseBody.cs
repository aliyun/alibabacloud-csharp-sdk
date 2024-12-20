// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeWaitingSQLInfoResponseBody : TeaModel {
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
        /// <para>The queried lock-waiting query.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeWaitingSQLInfoResponseBodyItems> Items { get; set; }
        public class DescribeWaitingSQLInfoResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The application that sent the query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DataGrip 2022.1.5</para>
            /// </summary>
            [NameInMap("Application")]
            [Validation(Required=false)]
            public string Application { get; set; }

            /// <summary>
            /// <para>The application that sent the blocking query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DataGrip 2022.1.5</para>
            /// </summary>
            [NameInMap("BlockedByApplication")]
            [Validation(Required=false)]
            public string BlockedByApplication { get; set; }

            /// <summary>
            /// <para>The process ID of the blocking query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>110</para>
            /// </summary>
            [NameInMap("BlockedByPID")]
            [Validation(Required=false)]
            public string BlockedByPID { get; set; }

            /// <summary>
            /// <para>The SQL statement of the blocking query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Select * from t1;</para>
            /// </summary>
            [NameInMap("BlockedBySQLStmt")]
            [Validation(Required=false)]
            public string BlockedBySQLStmt { get; set; }

            /// <summary>
            /// <para>The database account that is used to perform the blocking query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testUser1</para>
            /// </summary>
            [NameInMap("BlockedByUser")]
            [Validation(Required=false)]
            public string BlockedByUser { get; set; }

            /// <summary>
            /// <para>The authorized locks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ShareLock,AccessExclusiveLock</para>
            /// </summary>
            [NameInMap("GrantLocks")]
            [Validation(Required=false)]
            public string GrantLocks { get; set; }

            /// <summary>
            /// <para>The unauthorized locks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AccessShareLock</para>
            /// </summary>
            [NameInMap("NotGrantLocks")]
            [Validation(Required=false)]
            public string NotGrantLocks { get; set; }

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
            /// <para>The database account that is used to perform the query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testUser</para>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4CAF581-2AC7-41AD-8940-D56DF7AADF5B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
