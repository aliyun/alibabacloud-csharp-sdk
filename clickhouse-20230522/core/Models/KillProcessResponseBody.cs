// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class KillProcessResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public KillProcessResponseBodyData Data { get; set; }
        public class KillProcessResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of queries that are terminated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cc-xxxxxxx</para>
            /// </summary>
            [NameInMap("DBInstanceID")]
            [Validation(Required=false)]
            public int? DBInstanceID { get; set; }

            /// <summary>
            /// <para>The cluster name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cc-xxxxxxx</para>
            /// </summary>
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx-xxx-xxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
