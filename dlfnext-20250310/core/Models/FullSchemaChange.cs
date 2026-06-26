// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class FullSchemaChange : TeaModel {
        /// <summary>
        /// <para>The type of change.</para>
        /// 
        /// <b>Example:</b>
        /// <para>setOption</para>
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <para>The description. This parameter is required when <c>action</c> is <c>UpdateComment</c> or <c>AddColumn</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>col_comment</para>
        /// </summary>
        [NameInMap("comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The column type. This parameter is required when <c>action</c> is <c>AddColumn</c>.</para>
        /// </summary>
        [NameInMap("dataType")]
        [Validation(Required=false)]
        public FullDataType DataType { get; set; }

        /// <summary>
        /// <para>The table column names. This parameter is required when <c>action</c> is <c>AddColumn</c>, <c>RenameColumn</c>, <c>DropColumn</c>, <c>UpdateColumnComment</c>, <c>UpdateColumnType</c>, or <c>UpdateColumnNullability</c>.</para>
        /// </summary>
        [NameInMap("fieldNames")]
        [Validation(Required=false)]
        public List<string> FieldNames { get; set; }

        /// <summary>
        /// <para>Specifies whether the column is nullable. This parameter is required when the <c>action</c> is <c>UpdateColumnType</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("keepNullability")]
        [Validation(Required=false)]
        public bool? KeepNullability { get; set; }

        /// <summary>
        /// <para>The key for the configuration. This parameter is required when <c>action</c> is <c>SetOption</c> or <c>RemoveOption</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>\&quot;true\&quot;</para>
        /// </summary>
        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The column to move. This parameter is required when <c>action</c> is <c>AddColumn</c> or <c>UpdateColumnPosition</c>.</para>
        /// </summary>
        [NameInMap("move")]
        [Validation(Required=false)]
        public Move Move { get; set; }

        /// <summary>
        /// <para>The new description for the column. This parameter is required when <c>action</c> is <c>UpdateColumnComment</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>col_comment_test</para>
        /// </summary>
        [NameInMap("newComment")]
        [Validation(Required=false)]
        public string NewComment { get; set; }

        /// <summary>
        /// <para>The new column type. This parameter is required when <c>action</c> is <c>UpdateColumnType</c>.</para>
        /// </summary>
        [NameInMap("newDataType")]
        [Validation(Required=false)]
        public FullDataType NewDataType { get; set; }

        /// <summary>
        /// <para>The new name of the column. This parameter is required when <c>action</c> is <c>RenameColumn</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>new_col_test</para>
        /// </summary>
        [NameInMap("newName")]
        [Validation(Required=false)]
        public string NewName { get; set; }

        /// <summary>
        /// <para>Specifies whether the new column is nullable. This parameter is required when <c>action</c> is <c>UpdateColumnType</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("newNullability")]
        [Validation(Required=false)]
        public bool? NewNullability { get; set; }

        /// <summary>
        /// <para>The value of the configuration. This parameter is required when <c>action</c> is <c>SetOption</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>\&quot;manifest.delete-file-drop-stats\&quot;</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
