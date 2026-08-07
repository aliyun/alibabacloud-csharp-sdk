// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class ListScriptsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>实例ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b04</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>搜索关键词</para>
        /// 
        /// <b>Example:</b>
        /// <para>满意度调研</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>页码，从1开始</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>每页记录数</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>是否仅返回已发布的场景</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PublishOnly")]
        [Validation(Required=false)]
        public bool? PublishOnly { get; set; }

        /// <summary>
        /// <para>场景ID列表</para>
        /// </summary>
        [NameInMap("ScriptIds")]
        [Validation(Required=false)]
        public string ScriptIdsShrink { get; set; }

    }

}
