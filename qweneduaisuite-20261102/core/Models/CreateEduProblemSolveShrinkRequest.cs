// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QwenEduAiSuite20261102.Models
{
    public class CreateEduProblemSolveShrinkRequest : TeaModel {
        /// <summary>
        /// <para><b>The question image container.</b></para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string QueryShrink { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019F593F-D6EE-5F44-819A-6CDA127D1637</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
