// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class DeleteAccountResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeleteAccountResponseBodyData Data { get; set; }
        public class DeleteAccountResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The name of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test1</para>
            /// </summary>
            [NameInMap("Account")]
            [Validation(Required=false)]
            public string Account { get; set; }

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
        /// <para>21D06907-CEA5-561D-B6B1-198BCCE99ED1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
