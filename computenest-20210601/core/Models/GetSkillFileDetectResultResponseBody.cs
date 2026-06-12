// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class GetSkillFileDetectResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. A value of &quot;200&quot; indicates success. Other values indicate an error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The unique identifier for the detection task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8cfb1102cc5f56fe752f6e9b8c6f7f3d</para>
        /// </summary>
        [NameInMap("HashKey")]
        [Validation(Required=false)]
        public string HashKey { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3F976EF8-C10A-57DC-917C-BB7BEB508FFB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The file detection result. Valid values:</para>
        /// <para>0: safe file</para>
        /// <para>1: suspicious file</para>
        /// <para>3: The detection is in progress.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public int? Result { get; set; }

        /// <summary>
        /// <para>The file detection score. The score ranges correspond to the following threat levels:</para>
        /// <para>0–60: safe</para>
        /// <para>61–70: risk</para>
        /// <para>71–80: suspicious</para>
        /// <para>81–100: malicious</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Score")]
        [Validation(Required=false)]
        public int? Score { get; set; }

    }

}
