// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class UpdateTableMetaRequest : TeaModel {
        /// <summary>
        /// <para>The description of the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a test table</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The list of table fields.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public List<UpdateTableMetaRequestFields> Fields { get; set; }
        public class UpdateTableMetaRequestFields : TeaModel {
            /// <summary>
            /// <para>The data type of the field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>primary_key</para>
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            /// <summary>
            /// <para>Specifies whether the field is a dimension field.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsDimensionField")]
            [Validation(Required=false)]
            public bool? IsDimensionField { get; set; }

            /// <summary>
            /// <para>Specifies whether the field is a partition field.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsPartitionField")]
            [Validation(Required=false)]
            public string IsPartitionField { get; set; }

            /// <summary>
            /// <para>The meaning of the field.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Name field</para>
            /// </summary>
            [NameInMap("Meaning")]
            [Validation(Required=false)]
            public string Meaning { get; set; }

            /// <summary>
            /// <para>The name of the field.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The type of the field.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BIGINT</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The instance ID. You can call the <a href="https://help.aliyun.com/document_detail/2411819.html">ListInstances</a> operation to obtain the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-cn-test1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The module of the data table.</para>
        /// <list type="bullet">
        /// <item><description><para>ABTest: experiment data table.</para>
        /// </description></item>
        /// <item><description><para>ExperimentTool: experiment tool table.</para>
        /// </description></item>
        /// <item><description><para>DataDiagnosis: data diagnosis.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABTest</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public string Module { get; set; }

        /// <summary>
        /// <para>The name of the data table.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table_test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The resource ID. You can call the <a href="https://help.aliyun.com/document_detail/2672886.html">ListInstanceResource</a> operation to obtain the resource ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>reso-2s416t***</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The name of the table in the database.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table_mysql</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
