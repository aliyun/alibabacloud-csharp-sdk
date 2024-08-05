// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListFeatureConsistencyCheckJobConfigsResponseBody : TeaModel {
        [NameInMap("FeatureConsistencyCheckConfigs")]
        [Validation(Required=false)]
        public List<ListFeatureConsistencyCheckJobConfigsResponseBodyFeatureConsistencyCheckConfigs> FeatureConsistencyCheckConfigs { get; set; }
        public class ListFeatureConsistencyCheckJobConfigsResponseBodyFeatureConsistencyCheckConfigs : TeaModel {
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

            [NameInMap("FeatureConsistencyCheckJobConfigId")]
            [Validation(Required=false)]
            public string FeatureConsistencyCheckJobConfigId { get; set; }

            [NameInMap("FeatureDisplayExclude")]
            [Validation(Required=false)]
            public string FeatureDisplayExclude { get; set; }

            [NameInMap("FeatureLandingResourceId")]
            [Validation(Required=false)]
            public string FeatureLandingResourceId { get; set; }

            [NameInMap("FeatureLandingResourceUri")]
            [Validation(Required=false)]
            public string FeatureLandingResourceUri { get; set; }

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

            [NameInMap("FgJsonFileName")]
            [Validation(Required=false)]
            public string FgJsonFileName { get; set; }

            [NameInMap("GenerateZip")]
            [Validation(Required=false)]
            public bool? GenerateZip { get; set; }

            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

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

            [NameInMap("LatestJobGmtSamplingEndTime")]
            [Validation(Required=false)]
            public string LatestJobGmtSamplingEndTime { get; set; }

            [NameInMap("LatestJobGmtSamplingStartTime")]
            [Validation(Required=false)]
            public string LatestJobGmtSamplingStartTime { get; set; }

            [NameInMap("LatestJobId")]
            [Validation(Required=false)]
            public string LatestJobId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OssBucket")]
            [Validation(Required=false)]
            public string OssBucket { get; set; }

            [NameInMap("OssResourceId")]
            [Validation(Required=false)]
            public string OssResourceId { get; set; }

            [NameInMap("SampleRate")]
            [Validation(Required=false)]
            public string SampleRate { get; set; }

            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UseFeatureStore")]
            [Validation(Required=false)]
            public string UseFeatureStore { get; set; }

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

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
