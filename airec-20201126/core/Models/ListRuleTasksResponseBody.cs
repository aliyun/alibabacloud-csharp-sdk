// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class ListRuleTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>Queries the status of a rule-specific task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalServerError</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The ID of the scene.</para>
        /// 
        /// <b>Example:</b>
        /// <para>An internal server error occurred</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8F81A922-6C81-46D6-B78C-CC35E16B1691</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public ListRuleTasksResponseBodyResult Result { get; set; }
        public class ListRuleTasksResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("finishRate")]
            [Validation(Required=false)]
            public int? FinishRate { get; set; }

            /// <summary>
            /// <para>The ID of the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1588240081</para>
            /// </summary>
            [NameInMap("finishTime")]
            [Validation(Required=false)]
            public int? FinishTime { get; set; }

        }

    }

}
