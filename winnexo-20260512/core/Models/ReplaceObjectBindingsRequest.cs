// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ReplaceObjectBindingsRequest : TeaModel {
        /// <summary>
        /// <para>新的对象绑定列表（全量替换；传空列表表示清空所有绑定）</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("objectBindings")]
        [Validation(Required=false)]
        public List<ReplaceObjectBindingsRequestObjectBindings> ObjectBindings { get; set; }
        public class ReplaceObjectBindingsRequestObjectBindings : TeaModel {
            /// <summary>
            /// <para>绑定对象归属的语义图谱名（object_id 在该 graph 下唯一，必填）</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("graphName")]
            [Validation(Required=false)]
            public string GraphName { get; set; }

            /// <summary>
            /// <para>绑定对象 ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleObjectId</para>
            /// </summary>
            [NameInMap("objectId")]
            [Validation(Required=false)]
            public string ObjectId { get; set; }

            /// <summary>
            /// <para>绑定对象类型（如 customer / project）</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("objectType")]
            [Validation(Required=false)]
            public string ObjectType { get; set; }

        }

        /// <summary>
        /// <para>数据源 ID（租户内唯一）</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleSourceId</para>
        /// </summary>
        [NameInMap("sourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>租户ID，公共参数；winnexo-cli 通过 --tenant-id 显式传入</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
