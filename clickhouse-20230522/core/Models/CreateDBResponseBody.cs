// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class CreateDBResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateDBResponseBodyData Data { get; set; }
        public class CreateDBResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cc-bp100p4q1g9z3****</para>
            /// </summary>
            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testdb001</para>
            /// </summary>
            [NameInMap("DBName")]
            [Validation(Required=false)]
            public string DBName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>94F92113-FF63-5E57-8401-6FE123AD11DD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
