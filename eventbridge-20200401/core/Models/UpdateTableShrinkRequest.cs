// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class UpdateTableShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Add column</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Name&quot;:&quot;id&quot;,&quot;Type&quot;:&quot;bigint&quot;,&quot;Comment&quot;:&quot;主键&quot;}</para>
        /// </summary>
        [NameInMap("AddColumn")]
        [Validation(Required=false)]
        public string AddColumnShrink { get; set; }

        /// <summary>
        /// <para>Data catalog to which it belongs</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_catalog</para>
        /// </summary>
        [NameInMap("Catalog")]
        [Validation(Required=false)]
        public string Catalog { get; set; }

        /// <summary>
        /// <para>Idempotency token</para>
        /// 
        /// <b>Example:</b>
        /// <para>1e9b8f60-3a2c-4d7e-9f1b-8c3d5e7a2b4f</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Delete column</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Name&quot;:&quot;old_column&quot;}</para>
        /// </summary>
        [NameInMap("DeleteColumn")]
        [Validation(Required=false)]
        public string DeleteColumnShrink { get; set; }

        /// <summary>
        /// <para>Table name</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_table</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Namespace to which it belongs</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_namespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>Rename column</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Name&quot;:&quot;old_name&quot;,&quot;NewName&quot;:&quot;new_name&quot;}</para>
        /// </summary>
        [NameInMap("RenameColumn")]
        [Validation(Required=false)]
        public string RenameColumnShrink { get; set; }

        /// <summary>
        /// <para>Update column comment</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Name&quot;:&quot;id&quot;,&quot;Comment&quot;:&quot;主键ID&quot;}</para>
        /// </summary>
        [NameInMap("UpdateColumnComment")]
        [Validation(Required=false)]
        public string UpdateColumnCommentShrink { get; set; }

        /// <summary>
        /// <para>Update column type</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Name&quot;:&quot;id&quot;,&quot;Type&quot;:&quot;bigint&quot;}</para>
        /// </summary>
        [NameInMap("UpdateColumnType")]
        [Validation(Required=false)]
        public string UpdateColumnTypeShrink { get; set; }

        /// <summary>
        /// <para>Update table comment</para>
        /// 
        /// <b>Example:</b>
        /// <para>更新后的备注</para>
        /// </summary>
        [NameInMap("UpdateComment")]
        [Validation(Required=false)]
        public string UpdateComment { get; set; }

        /// <summary>
        /// <para>Update retention policy</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;HotTTL&quot;:7,&quot;ColdTTL&quot;:30}</para>
        /// </summary>
        [NameInMap("UpdateRetentionPolicy")]
        [Validation(Required=false)]
        public string UpdateRetentionPolicyShrink { get; set; }

    }

}
