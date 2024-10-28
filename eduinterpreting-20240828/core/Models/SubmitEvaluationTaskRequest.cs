// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EduInterpreting20240828.Models
{
    public class SubmitEvaluationTaskRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://xx.com/abc.mp3">http://xx.com/abc.mp3</a></para>
        /// </summary>
        [NameInMap("AudioUrl")]
        [Validation(Required=false)]
        public string AudioUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://abc.edu.org.cn/en/callback">https://abc.edu.org.cn/en/callback</a></para>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>As flame of fire we gather, as skyful of stars we scatter.</para>
        /// </summary>
        [NameInMap("MaterialText")]
        [Validation(Required=false)]
        public string MaterialText { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>433c1361-0f6e-48fc-ad51</para>
        /// </summary>
        [NameInMap("OuterBizId")]
        [Validation(Required=false)]
        public string OuterBizId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SuggestedAnswer")]
        [Validation(Required=false)]
        public string SuggestedAnswer { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EN_TO_ZH</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
