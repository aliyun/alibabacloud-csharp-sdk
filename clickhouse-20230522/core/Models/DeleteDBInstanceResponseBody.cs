// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class DeleteDBInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeleteDBInstanceResponseBodyData Data { get; set; }
        public class DeleteDBInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cc-bp100p4q1g9z3****</para>
            /// </summary>
            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D0CEC6AC-7760-409A-A0D5-E6CD8660E9CC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
