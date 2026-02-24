// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class TransformerForView : TeaModel {
        /// <summary>
        /// <para>Transformation operation.</para>
        /// </summary>
        [NameInMap("actions")]
        [Validation(Required=false)]
        public List<TransformAction> Actions { get; set; }

        /// <summary>
        /// <para>Create Time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-11T08:21:58Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>Description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Whether enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>Filter Setting.</para>
        /// </summary>
        [NameInMap("filterSetting")]
        [Validation(Required=false)]
        public FilterSetting FilterSetting { get; set; }

        /// <summary>
        /// <para>Exit after matching processing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("quitAfterMatch")]
        [Validation(Required=false)]
        public bool? QuitAfterMatch { get; set; }

        /// <summary>
        /// <para>Sort order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("sortId")]
        [Validation(Required=false)]
        public int? SortId { get; set; }

        /// <summary>
        /// <para>transformer Id</para>
        /// 
        /// <b>Example:</b>
        /// <para>1123123123123</para>
        /// </summary>
        [NameInMap("transformerId")]
        [Validation(Required=false)]
        public string TransformerId { get; set; }

        /// <summary>
        /// <para>Name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test processing flow.</para>
        /// </summary>
        [NameInMap("transformerName")]
        [Validation(Required=false)]
        public string TransformerName { get; set; }

        /// <summary>
        /// <para>Update Time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-16T02:27:01Z</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>User ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123123123**</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>workspace</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace-test</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
