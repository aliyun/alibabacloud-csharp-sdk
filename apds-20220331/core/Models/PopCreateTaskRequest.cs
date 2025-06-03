// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Apds20220331.Models
{
    public class PopCreateTaskRequest : TeaModel {
        [NameInMap("dataTypeMappingFile")]
        [Validation(Required=false)]
        public object DataTypeMappingFile { get; set; }

        [NameInMap("dataTypeOssFileName")]
        [Validation(Required=false)]
        public string DataTypeOssFileName { get; set; }

        [NameInMap("dataTypeOssObjectName")]
        [Validation(Required=false)]
        public string DataTypeOssObjectName { get; set; }

        [NameInMap("dataTypeRealFileName")]
        [Validation(Required=false)]
        public string DataTypeRealFileName { get; set; }

        [NameInMap("dqlAssociationDDLTaskList")]
        [Validation(Required=false)]
        public string DqlAssociationDDLTaskList { get; set; }

        [NameInMap("dqlRelateTargetDatasourceId")]
        [Validation(Required=false)]
        public string DqlRelateTargetDatasourceId { get; set; }

        [NameInMap("dqlTestDatasourceId")]
        [Validation(Required=false)]
        public string DqlTestDatasourceId { get; set; }

        [NameInMap("dqlTestProject")]
        [Validation(Required=false)]
        public string DqlTestProject { get; set; }

        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        [NameInMap("globalParams")]
        [Validation(Required=false)]
        public string GlobalParams { get; set; }

        [NameInMap("identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        [NameInMap("ossObjectName")]
        [Validation(Required=false)]
        public string OssObjectName { get; set; }

        [NameInMap("realFileName")]
        [Validation(Required=false)]
        public string RealFileName { get; set; }

        [NameInMap("relatedDdlContentOssFileName")]
        [Validation(Required=false)]
        public string RelatedDdlContentOssFileName { get; set; }

        [NameInMap("relatedDdlContentOssObjectName")]
        [Validation(Required=false)]
        public string RelatedDdlContentOssObjectName { get; set; }

        [NameInMap("relatedDdlContentRealFileName")]
        [Validation(Required=false)]
        public string RelatedDdlContentRealFileName { get; set; }

        [NameInMap("sourceDatasourceId")]
        [Validation(Required=false)]
        public string SourceDatasourceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sourceDialect")]
        [Validation(Required=false)]
        public string SourceDialect { get; set; }

        [NameInMap("sourceProject")]
        [Validation(Required=false)]
        public string SourceProject { get; set; }

        [NameInMap("tableNameMappingFile")]
        [Validation(Required=false)]
        public object TableNameMappingFile { get; set; }

        [NameInMap("tableNameOssFileName")]
        [Validation(Required=false)]
        public string TableNameOssFileName { get; set; }

        [NameInMap("tableNameOssObjectName")]
        [Validation(Required=false)]
        public string TableNameOssObjectName { get; set; }

        [NameInMap("tableNameRealFileName")]
        [Validation(Required=false)]
        public string TableNameRealFileName { get; set; }

        [NameInMap("targetDatasourceId")]
        [Validation(Required=false)]
        public string TargetDatasourceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("targetDialect")]
        [Validation(Required=false)]
        public string TargetDialect { get; set; }

        [NameInMap("targetProject")]
        [Validation(Required=false)]
        public string TargetProject { get; set; }

        [NameInMap("taskDescription")]
        [Validation(Required=false)]
        public string TaskDescription { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("taskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("taskType")]
        [Validation(Required=false)]
        public int? TaskType { get; set; }

        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("transformSchema")]
        [Validation(Required=false)]
        public string TransformSchema { get; set; }

        [NameInMap("uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
