// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class UpdateFeatureConsistencyCheckJobConfigRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("CompareFeature")]
        [Validation(Required=false)]
        public bool? CompareFeature { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("EasServiceName")]
        [Validation(Required=false)]
        public string EasServiceName { get; set; }

        [NameInMap("EasyRecPackagePath")]
        [Validation(Required=false)]
        public string EasyRecPackagePath { get; set; }

        [NameInMap("EasyRecVersion")]
        [Validation(Required=false)]
        public string EasyRecVersion { get; set; }

        [NameInMap("FeatureDisplayExclude")]
        [Validation(Required=false)]
        public string FeatureDisplayExclude { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("FeatureLandingResourceId")]
        [Validation(Required=false)]
        public string FeatureLandingResourceId { get; set; }

        [NameInMap("FeaturePriority")]
        [Validation(Required=false)]
        public string FeaturePriority { get; set; }

        [NameInMap("FeatureStoreItemId")]
        [Validation(Required=false)]
        public string FeatureStoreItemId { get; set; }

        [NameInMap("FeatureStoreModelId")]
        [Validation(Required=false)]
        public string FeatureStoreModelId { get; set; }

        [NameInMap("FeatureStoreProjectId")]
        [Validation(Required=false)]
        public string FeatureStoreProjectId { get; set; }

        [NameInMap("FeatureStoreProjectName")]
        [Validation(Required=false)]
        public string FeatureStoreProjectName { get; set; }

        [NameInMap("FeatureStoreSeqFeatureView")]
        [Validation(Required=false)]
        public string FeatureStoreSeqFeatureView { get; set; }

        [NameInMap("FeatureStoreUserId")]
        [Validation(Required=false)]
        public string FeatureStoreUserId { get; set; }

        [NameInMap("FgJarVersion")]
        [Validation(Required=false)]
        public string FgJarVersion { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("FgJsonFileName")]
        [Validation(Required=false)]
        public string FgJsonFileName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("GenerateZip")]
        [Validation(Required=false)]
        public bool? GenerateZip { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("IsUseFeatureStore")]
        [Validation(Required=false)]
        public bool? IsUseFeatureStore { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ItemIdField")]
        [Validation(Required=false)]
        public string ItemIdField { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ItemTable")]
        [Validation(Required=false)]
        public string ItemTable { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ItemTablePartitionField")]
        [Validation(Required=false)]
        public string ItemTablePartitionField { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ItemTablePartitionFieldFormat")]
        [Validation(Required=false)]
        public string ItemTablePartitionFieldFormat { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OssResourceId")]
        [Validation(Required=false)]
        public string OssResourceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SampleRate")]
        [Validation(Required=false)]
        public double? SampleRate { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("UserIdField")]
        [Validation(Required=false)]
        public string UserIdField { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("UserTable")]
        [Validation(Required=false)]
        public string UserTable { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("UserTablePartitionField")]
        [Validation(Required=false)]
        public string UserTablePartitionField { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("UserTablePartitionFieldFormat")]
        [Validation(Required=false)]
        public string UserTablePartitionFieldFormat { get; set; }

        [NameInMap("WorkflowName")]
        [Validation(Required=false)]
        public string WorkflowName { get; set; }

    }

}
