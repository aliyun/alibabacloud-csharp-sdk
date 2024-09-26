// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateMetaTableRequest : TeaModel {
        /// <summary>
        /// <para>The names of the labels that you want to add. Separate the labels with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>a,b,c</para>
        /// </summary>
        [NameInMap("AddedLabels")]
        [Validation(Required=false)]
        public string AddedLabels { get; set; }

        /// <summary>
        /// <para>The display name of the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Caption")]
        [Validation(Required=false)]
        public string Caption { get; set; }

        /// <summary>
        /// <para>The ID of the category that you want to associate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public long? CategoryId { get; set; }

        /// <summary>
        /// <para>The environment of the DataWorks workspace. Valid values: 0 and 1. The value 0 indicates the development environment. The value 1 indicates the production environment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public int? EnvType { get; set; }

        /// <summary>
        /// <para>The new owner ID. If you leave this parameter empty, the owner ID is not updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("NewOwnerId")]
        [Validation(Required=false)]
        public string NewOwnerId { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The names of labels that you want to remove. Separate the labels with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>a,b,c</para>
        /// </summary>
        [NameInMap("RemovedLabels")]
        [Validation(Required=false)]
        public string RemovedLabels { get; set; }

        /// <summary>
        /// <para>The schema information about the table. You must configure this parameter if you enable the three-layer model of MaxCompute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Schema")]
        [Validation(Required=false)]
        public string Schema { get; set; }

        /// <summary>
        /// <para>The GUID of the table. Specify the GUID in the format of odps.{projectName}.{tableName}.</para>
        /// 
        /// <b>Example:</b>
        /// <para>odps.test.table1</para>
        /// </summary>
        [NameInMap("TableGuid")]
        [Validation(Required=false)]
        public string TableGuid { get; set; }

        /// <summary>
        /// <para>The name of the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table1</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The scope in which the table is visible. Valid values: 0, 1, and 2. The value 0 indicates that the table is invisible to all members. The value 1 indicates that the table is visible to all members. The value 2 indicates that the table is visible to workspace members.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public int? Visibility { get; set; }

    }

}
