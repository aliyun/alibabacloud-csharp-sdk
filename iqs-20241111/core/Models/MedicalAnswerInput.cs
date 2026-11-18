// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class MedicalAnswerInput : TeaModel {
        /// <summary>
        /// <para>The medical question to be answered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>What should I do for a stomachache?</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

    }

}
