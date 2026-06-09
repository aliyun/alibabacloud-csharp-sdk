// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class Catalog : TeaModel {
        /// <summary>
        /// <para>数据目录的备注描述信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试数据目录</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>挂载类型 Catalog 关联的连接名称。仅 Provider 为 MySQL/PostgreSQL/Elasticsearch 时有值</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_connection</para>
        /// </summary>
        [NameInMap("ConnectionName")]
        [Validation(Required=false)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// <para>数据目录的唯一标识名称</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_catalog</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>扩展属性（JSON 对象）。Elasticsearch 类型包含 IndexPattern 等信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;IndexPattern&quot;:&quot;my-index-*&quot;}</para>
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public Dictionary<string, object> Properties { get; set; }

        /// <summary>
        /// <para>数据源提供方。EventHouse 为内置存储，MySQL/PostgreSQL/Elasticsearch 为外部挂载</para>
        /// 
        /// <b>Example:</b>
        /// <para>EventHouse</para>
        /// </summary>
        [NameInMap("Provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <para>数据目录类型，如 RELATIONAL</para>
        /// 
        /// <b>Example:</b>
        /// <para>RELATIONAL</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
