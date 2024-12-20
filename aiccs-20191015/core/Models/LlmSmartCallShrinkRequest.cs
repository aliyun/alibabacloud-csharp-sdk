// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class LlmSmartCallShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F32XXX2CF9</para>
        /// </summary>
        [NameInMap("ApplicationCode")]
        [Validation(Required=false)]
        public string ApplicationCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>137****0000</para>
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>057188040000</para>
        /// </summary>
        [NameInMap("CallerNumber")]
        [Validation(Required=false)]
        public string CallerNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>222356****</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("PromptParam")]
        [Validation(Required=false)]
        public string PromptParamShrink { get; set; }

        [NameInMap("StartWordParam")]
        [Validation(Required=false)]
        public string StartWordParamShrink { get; set; }

    }

}
