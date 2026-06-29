// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class QuestionOption : TeaModel {
        /// <summary>
        /// <para>List of child options.</para>
        /// </summary>
        [NameInMap("Children")]
        [Validation(Required=false)]
        public List<QuestionOption> Children { get; set; }

        /// <summary>
        /// <para>Color.</para>
        /// 
        /// <b>Example:</b>
        /// <para>#239125</para>
        /// </summary>
        [NameInMap("Color")]
        [Validation(Required=false)]
        public string Color { get; set; }

        /// <summary>
        /// <para>Tag Name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>Label display name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dog</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// <para>Remark.</para>
        /// 
        /// <b>Example:</b>
        /// <para>第一道题目</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>Keyboard shortcut.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Shortcut")]
        [Validation(Required=false)]
        public string Shortcut { get; set; }

    }

}
