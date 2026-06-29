// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class TaskTemplateOptionConfig : TeaModel {
        /// <summary>
        /// <para>The default value must be adapted according to the question type. For a Radio or text box question, directly enter the tag value. For a Multiple Choice question, configure it as [&quot;{tag 1}&quot;, &quot;{tag 2}&quot;].</para>
        /// 
        /// <b>Example:</b>
        /// <para>猫咪</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("DefaultResult")]
        [Validation(Required=false)]
        public string DefaultResult { get; set; }

        /// <summary>
        /// <para>Select the list of question options.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public List<QuestionOption> Options { get; set; }

        /// <summary>
        /// <para>List of preset options for text-type questions.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("PreOptions")]
        [Validation(Required=false)]
        public List<string> PreOptions { get; set; }

        /// <summary>
        /// <para>Validation rule item; valid only for fill-in-the-blank text-type questions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>\w+</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public string Rule { get; set; }

    }

}
