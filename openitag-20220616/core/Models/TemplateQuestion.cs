// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class TemplateQuestion : TeaModel {
        /// <summary>
        /// <para>List of child nodes</para>
        /// </summary>
        [NameInMap("Children")]
        [Validation(Required=false)]
        public List<TemplateQuestion> Children { get; set; }

        /// <summary>
        /// <para>Additional properties</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Exif")]
        [Validation(Required=false)]
        public Dictionary<string, object> Exif { get; set; }

        /// <summary>
        /// <para>Title</para>
        /// 
        /// <b>Example:</b>
        /// <para>题目1</para>
        /// </summary>
        [NameInMap("MarkTitle")]
        [Validation(Required=false)]
        public string MarkTitle { get; set; }

        /// <summary>
        /// <para>List of options</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public List<QuestionOption> Options { get; set; }

        /// <summary>
        /// <para>List of pre-filled values</para>
        /// </summary>
        [NameInMap("PreOptions")]
        [Validation(Required=false)]
        public List<string> PreOptions { get; set; }

        /// <summary>
        /// <para>Question ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("QuestionId")]
        [Validation(Required=false)]
        public long? QuestionId { get; set; }

        /// <summary>
        /// <para>Type, including the following:  </para>
        /// <list type="bullet">
        /// <item><description>TEXT_EDIT  </description></item>
        /// <item><description>CHECKBOX  </description></item>
        /// <item><description>INPUT  </description></item>
        /// <item><description>PICTURE  </description></item>
        /// <item><description>VIDEO  </description></item>
        /// <item><description>OPEN_ENDED  </description></item>
        /// <item><description>SLOT  </description></item>
        /// <item><description>RADIO</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RADIO</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
