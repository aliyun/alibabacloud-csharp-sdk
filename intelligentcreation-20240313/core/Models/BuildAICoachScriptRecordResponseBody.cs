// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class BuildAICoachScriptRecordResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public BuildAICoachScriptRecordResponseBodyData Data { get; set; }
        public class BuildAICoachScriptRecordResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1234567</para>
            /// </summary>
            [NameInMap("scriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PARAM_ERROR</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Deduct task already success,Please do not resubmit.token \&quot;369e8f2c-d283-424a-96c4-c83efe08c89e\&quot;</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>4830493A-728F-5F19-BBCC-1443292E9C49</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("scriptRecordId")]
        [Validation(Required=false)]
        public string ScriptRecordId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
