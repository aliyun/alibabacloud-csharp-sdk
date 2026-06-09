// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class UpdateNamespaceRequest : TeaModel {
        /// <summary>
        /// <para>命名空间所属的数据目录名称。可通过 ListCatalogs 接口获取已有目录列表</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_catalog</para>
        /// </summary>
        [NameInMap("Catalog")]
        [Validation(Required=false)]
        public string Catalog { get; set; }

        /// <summary>
        /// <para>用于保证请求幂等性的Token，防止因网络重试导致重复操作。建议使用 UUID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1e9b8f60-3a2c-4d7e-9f1b-8c3d5e7a2b4f</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>命名空间的备注描述信息。传空字符串可清除原有备注，无格式限制</para>
        /// 
        /// <b>Example:</b>
        /// <para>更新后的备注</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>要修改的命名空间名称。名称本身不可修改，此处用于定位目标命名空间。需同时指定所属 Catalog。可通过 ListNamespaces 获取</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_namespace</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
