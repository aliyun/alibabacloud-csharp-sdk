// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class QuestionPlugin : TeaModel {
        /// <summary>
        /// <para>Whether it can be selected</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("CanSelect")]
        [Validation(Required=false)]
        public bool? CanSelect { get; set; }

        /// <summary>
        /// <para>List of child widgets</para>
        /// </summary>
        [NameInMap("Children")]
        [Validation(Required=false)]
        public List<QuestionPlugin> Children { get; set; }

        /// <summary>
        /// <para>Default result</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DefaultResult")]
        [Validation(Required=false)]
        public string DefaultResult { get; set; }

        /// <summary>
        /// <para>Whether it is displayed</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Display")]
        [Validation(Required=false)]
        public bool? Display { get; set; }

        /// <summary>
        /// <para>Additional remarks</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Exif")]
        [Validation(Required=false)]
        public Dictionary<string, object> Exif { get; set; }

        /// <summary>
        /// <para>Keyboard shortcut map</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("HotKeyMap")]
        [Validation(Required=false)]
        public string HotKeyMap { get; set; }

        /// <summary>
        /// <para>Widget title</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>内部单选</para>
        /// </summary>
        [NameInMap("MarkTitle")]
        [Validation(Required=false)]
        public string MarkTitle { get; set; }

        /// <summary>
        /// <para>Question alias</para>
        /// 
        /// <b>Example:</b>
        /// <para>单选</para>
        /// </summary>
        [NameInMap("MarkTitleAlias")]
        [Validation(Required=false)]
        public string MarkTitleAlias { get; set; }

        /// <summary>
        /// <para>Whether it is required</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("MustFill")]
        [Validation(Required=false)]
        public bool? MustFill { get; set; }

        /// <summary>
        /// <para>List of options configuration</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public List<QuestionOption> Options { get; set; }

        /// <summary>
        /// <para>List of predefined options for fill-in-the-blank questions</para>
        /// </summary>
        [NameInMap("PreOptions")]
        [Validation(Required=false)]
        public List<string> PreOptions { get; set; }

        /// <summary>
        /// <para>Question widget ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("QuestionId")]
        [Validation(Required=false)]
        public string QuestionId { get; set; }

        /// <summary>
        /// <para>Regular expression, validation rule</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public string Rule { get; set; }

        /// <summary>
        /// <para>Selection group</para>
        /// 
        /// <b>Example:</b>
        /// <para>g1</para>
        /// </summary>
        [NameInMap("SelectGroup")]
        [Validation(Required=false)]
        public string SelectGroup { get; set; }

        /// <summary>
        /// <para>Whether it is selected</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("Selected")]
        [Validation(Required=false)]
        public bool? Selected { get; set; }

        /// <summary>
        /// <para>Widget type</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RADIO</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
