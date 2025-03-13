// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class StopDBInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public StopDBInstanceResponseBodyData Data { get; set; }
        public class StopDBInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cc-bp100p4q1g9z3****</para>
            /// </summary>
            [NameInMap("DBInstanceID")]
            [Validation(Required=false)]
            public long? DBInstanceID { get; set; }

            /// <summary>
            /// <para>The cluster name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test1</para>
            /// </summary>
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100000785</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2FED790E-FB61-4721-8C1C-07C627FA5A19</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
