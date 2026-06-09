// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class UpdateTableShrinkRequest : TeaModel {
        /// <summary>
        /// <para>新增列定义（JSON 对象）。包含 Name（列名，必填）、Type（数据类型，必填，如 STRING、INT32、INT64、FLOAT、DOUBLE、BOOLEAN、TIMESTAMP）、Comment（列备注，选填）。每次调用只能新增一列</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Name&quot;:&quot;id&quot;,&quot;Type&quot;:&quot;bigint&quot;,&quot;Comment&quot;:&quot;主键&quot;}</para>
        /// </summary>
        [NameInMap("AddColumn")]
        [Validation(Required=false)]
        public string AddColumnShrink { get; set; }

        /// <summary>
        /// <para>表所属的数据目录名称。可通过 ListCatalogs 获取</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_catalog</para>
        /// </summary>
        [NameInMap("Catalog")]
        [Validation(Required=false)]
        public string Catalog { get; set; }

        /// <summary>
        /// <para>用于保证请求幂等性的Token。建议使用 UUID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1e9b8f60-3a2c-4d7e-9f1b-8c3d5e7a2b4f</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>删除列定义（JSON 对象）。包含 Name（要删除的列名，必填）。删除后不可恢复，已有数据中该列的值将丢失。每次调用只能删除一列</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Name&quot;:&quot;old_column&quot;}</para>
        /// </summary>
        [NameInMap("DeleteColumn")]
        [Validation(Required=false)]
        public string DeleteColumnShrink { get; set; }

        /// <summary>
        /// <para>要修改的事件表名称。名称本身不可修改，此处用于定位目标表。需同时指定所属 Catalog 和 Namespace。可通过 ListTables 获取</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_table</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>表所属的命名空间名称。可通过 ListNamespaces 获取</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_namespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>重命名列（JSON 对象）。包含 Name（原列名，必填）、NewName（新列名，必填）。每次调用只能重命名一列</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Name&quot;:&quot;old_name&quot;,&quot;NewName&quot;:&quot;new_name&quot;}</para>
        /// </summary>
        [NameInMap("RenameColumn")]
        [Validation(Required=false)]
        public string RenameColumnShrink { get; set; }

        /// <summary>
        /// <para>修改列的备注信息（JSON 对象）。包含 Name（目标列名，必填）、Comment（新备注内容，必填，传空字符串可清除备注）。每次调用只能修改一列</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Name&quot;:&quot;id&quot;,&quot;Comment&quot;:&quot;主键ID&quot;}</para>
        /// </summary>
        [NameInMap("UpdateColumnComment")]
        [Validation(Required=false)]
        public string UpdateColumnCommentShrink { get; set; }

        /// <summary>
        /// <para>修改列的数据类型（JSON 对象）。包含 Name（目标列名，必填）、Type（新数据类型，必填）。仅支持兼容类型转换，每次调用只能修改一列</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Name&quot;:&quot;id&quot;,&quot;Type&quot;:&quot;bigint&quot;}</para>
        /// </summary>
        [NameInMap("UpdateColumnType")]
        [Validation(Required=false)]
        public string UpdateColumnTypeShrink { get; set; }

        /// <summary>
        /// <para>修改表的备注描述。传入新的备注内容替换原有备注，传空字符串可清除备注</para>
        /// 
        /// <b>Example:</b>
        /// <para>更新后的备注</para>
        /// </summary>
        [NameInMap("UpdateComment")]
        [Validation(Required=false)]
        public string UpdateComment { get; set; }

        /// <summary>
        /// <para>修改数据保留策略（JSON 对象）。包含 HotTTL（热数据保留天数）、ColdTTL（冷数据保留天数）。传入后会替换原有策略</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;HotTTL&quot;:7,&quot;ColdTTL&quot;:30}</para>
        /// </summary>
        [NameInMap("UpdateRetentionPolicy")]
        [Validation(Required=false)]
        public string UpdateRetentionPolicyShrink { get; set; }

    }

}
