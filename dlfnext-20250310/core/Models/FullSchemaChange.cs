// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class FullSchemaChange : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>setOption</para>
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <para>required in UpdateComment/AddColumn</para>
        /// 
        /// <b>Example:</b>
        /// <para>col_comment</para>
        /// </summary>
        [NameInMap("comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        [NameInMap("dataType")]
        [Validation(Required=false)]
        public FullDataType DataType { get; set; }

        /// <summary>
        /// <para>required in AddColumn/RenameColumn/DropColumn/UpdateColumnComment/UpdateColumnType/UpdateColumnNullability</para>
        /// </summary>
        [NameInMap("fieldNames")]
        [Validation(Required=false)]
        public List<string> FieldNames { get; set; }

        /// <summary>
        /// <para>required in UpdateColumnType</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("keepNullability")]
        [Validation(Required=false)]
        public bool? KeepNullability { get; set; }

        /// <summary>
        /// <para>required in SetOption/RemoveOption</para>
        /// 
        /// <b>Example:</b>
        /// <para>\&quot;true\&quot;</para>
        /// </summary>
        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        [NameInMap("move")]
        [Validation(Required=false)]
        public Move Move { get; set; }

        /// <summary>
        /// <para>required in UpdateColumnComment</para>
        /// 
        /// <b>Example:</b>
        /// <para>col_comment_test</para>
        /// </summary>
        [NameInMap("newComment")]
        [Validation(Required=false)]
        public string NewComment { get; set; }

        [NameInMap("newDataType")]
        [Validation(Required=false)]
        public FullDataType NewDataType { get; set; }

        /// <summary>
        /// <para>required in RenameColumn</para>
        /// 
        /// <b>Example:</b>
        /// <para>new_col_test</para>
        /// </summary>
        [NameInMap("newName")]
        [Validation(Required=false)]
        public string NewName { get; set; }

        /// <summary>
        /// <para>required in UpdateColumnNullability</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("newNullability")]
        [Validation(Required=false)]
        public bool? NewNullability { get; set; }

        /// <summary>
        /// <para>required in SetOption</para>
        /// 
        /// <b>Example:</b>
        /// <para>\&quot;manifest.delete-file-drop-stats\&quot;</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
