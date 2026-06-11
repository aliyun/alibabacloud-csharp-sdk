// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class TransformerForView : TeaModel {
        /// <summary>
        /// <para>The transform operations.</para>
        /// </summary>
        [NameInMap("actions")]
        [Validation(Required=false)]
        public List<TransformAction> Actions { get; set; }

        /// <summary>
        /// <para>The time when the converter was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-11T08:21:58Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Indicates whether the converter is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The filter settings.</para>
        /// </summary>
        [NameInMap("filterSetting")]
        [Validation(Required=false)]
        public FilterSetting FilterSetting { get; set; }

        /// <summary>
        /// <para>Indicates whether to exit after a match is processed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("quitAfterMatch")]
        [Validation(Required=false)]
        public bool? QuitAfterMatch { get; set; }

        /// <summary>
        /// <para>The sort ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("sortId")]
        [Validation(Required=false)]
        public int? SortId { get; set; }

        /// <summary>
        /// <para>The transformer ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1123123123123</para>
        /// </summary>
        [NameInMap("transformerId")]
        [Validation(Required=false)]
        public string TransformerId { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试处理流</para>
        /// </summary>
        [NameInMap("transformerName")]
        [Validation(Required=false)]
        public string TransformerName { get; set; }

        /// <summary>
        /// <para>The time when the converter was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-16T02:27:01Z</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123123123**</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace-test</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
