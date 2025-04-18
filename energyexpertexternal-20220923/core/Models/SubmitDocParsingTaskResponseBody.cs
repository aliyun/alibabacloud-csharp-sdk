// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class SubmitDocParsingTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>Return result.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public SubmitDocParsingTaskResponseBodyData Data { get; set; }
        public class SubmitDocParsingTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>TaskID</para>
            /// 
            /// <b>Example:</b>
            /// <para>ae9d07be-1a11-4d30-be75-cc962b98279c</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>83A5A7DD-8974-5769-952E-590A97BEA34E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
