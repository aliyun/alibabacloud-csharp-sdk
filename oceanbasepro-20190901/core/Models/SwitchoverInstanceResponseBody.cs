// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class SwitchoverInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of data for the switchover.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SwitchoverInstanceResponseBodyData Data { get; set; }
        public class SwitchoverInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The message of the switchover.</para>
            /// 
            /// <b>Example:</b>
            /// <para>delete tag-value success</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>Whether the switchover is successful.</para>
            /// <list type="bullet">
            /// <item><description>true: the switchover succeeded.</description></item>
            /// <item><description>false: the switchover failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469**-AA6F-4D**-B3DB-A***********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
