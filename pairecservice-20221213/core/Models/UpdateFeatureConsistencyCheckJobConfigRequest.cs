// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class UpdateFeatureConsistencyCheckJobConfigRequest : TeaModel {
        [NameInMap("CompareFeature")]
        [Validation(Required=false)]
        public bool? CompareFeature { get; set; }

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

        [NameInMap("FeatureLandingResourceId")]
        [Validation(Required=false)]
        public string FeatureLandingResourceId { get; set; }

        [NameInMap("FeaturePriority")]
        [Validation(Required=false)]
        public string FeaturePriority { get; set; }

        [NameInMap("FgJarVersion")]
        [Validation(Required=false)]
        public string FgJarVersion { get; set; }

        [NameInMap("FgJsonFileName")]
        [Validation(Required=false)]
        public string FgJsonFileName { get; set; }

        [NameInMap("GenerateZip")]
        [Validation(Required=false)]
        public bool? GenerateZip { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("ItemIdField")]
        [Validation(Required=false)]
        public string ItemIdField { get; set; }

        [NameInMap("ItemTable")]
        [Validation(Required=false)]
        public string ItemTable { get; set; }

        [NameInMap("ItemTablePartitionField")]
        [Validation(Required=false)]
        public string ItemTablePartitionField { get; set; }

        [NameInMap("ItemTablePartitionFieldFormat")]
        [Validation(Required=false)]
        public string ItemTablePartitionFieldFormat { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OssResourceId")]
        [Validation(Required=false)]
        public string OssResourceId { get; set; }

        [NameInMap("SampleRate")]
        [Validation(Required=false)]
        public double? SampleRate { get; set; }

        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        [NameInMap("UserIdField")]
        [Validation(Required=false)]
        public string UserIdField { get; set; }

        [NameInMap("UserTable")]
        [Validation(Required=false)]
        public string UserTable { get; set; }

        [NameInMap("UserTablePartitionField")]
        [Validation(Required=false)]
        public string UserTablePartitionField { get; set; }

        [NameInMap("UserTablePartitionFieldFormat")]
        [Validation(Required=false)]
        public string UserTablePartitionFieldFormat { get; set; }

        [NameInMap("WorkflowName")]
        [Validation(Required=false)]
        public string WorkflowName { get; set; }

    }

}
