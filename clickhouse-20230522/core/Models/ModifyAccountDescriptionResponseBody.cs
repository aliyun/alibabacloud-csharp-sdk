// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class ModifyAccountDescriptionResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ModifyAccountDescriptionResponseBodyData Data { get; set; }
        public class ModifyAccountDescriptionResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>testuser</para>
            /// </summary>
            [NameInMap("Account")]
            [Validation(Required=false)]
            public string Account { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cc-xxxxx</para>
            /// </summary>
            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

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
