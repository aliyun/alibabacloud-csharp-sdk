// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class SaveGraphDraftResourceRequest : TeaModel {
        /// <summary>
        /// <para>资源小类：resourceType=object 时固定 object_type；resourceType=element 时为 indicator / logic / process / rule / analysis 之一</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>object_type</para>
        /// </summary>
        [NameInMap("elementType")]
        [Validation(Required=false)]
        public string ElementType { get; set; }

        /// <summary>
        /// <para>图谱名称，须已存在（active 记录）</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crm_graph</para>
        /// </summary>
        [NameInMap("graphName")]
        [Validation(Required=false)]
        public string GraphName { get; set; }

        /// <summary>
        /// <para>资源名（创建后不可改名，底层校验）</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>customer</para>
        /// </summary>
        [NameInMap("resourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// <para>资源大类：object（对象）/ element（业务元素）</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>object</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>租户ID，公共参数，缺省时使用调用方默认租户</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>单资源 YAML 文本</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name: customer\ndisplay_name: 客户</para>
        /// </summary>
        [NameInMap("yamlEdit")]
        [Validation(Required=false)]
        public string YamlEdit { get; set; }

    }

}
