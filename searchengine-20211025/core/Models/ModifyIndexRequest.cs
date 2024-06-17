// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ModifyIndexRequest : TeaModel {
        [NameInMap("buildParallelNum")]
        [Validation(Required=false)]
        public int? BuildParallelNum { get; set; }

        [NameInMap("cluster")]
        [Validation(Required=false)]
        public Dictionary<string, Dictionary<string, object>> Cluster { get; set; }

        [NameInMap("clusterConfigName")]
        [Validation(Required=false)]
        public string ClusterConfigName { get; set; }

        [NameInMap("config")]
        [Validation(Required=false)]
        public Dictionary<string, ConfigValue> Config { get; set; }

        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("dataSource")]
        [Validation(Required=false)]
        public string DataSource { get; set; }

        [NameInMap("dataSourceInfo")]
        [Validation(Required=false)]
        public ModifyIndexRequestDataSourceInfo DataSourceInfo { get; set; }
        public class ModifyIndexRequestDataSourceInfo : TeaModel {
            [NameInMap("autoBuildIndex")]
            [Validation(Required=false)]
            public bool? AutoBuildIndex { get; set; }

            [NameInMap("buildMode")]
            [Validation(Required=false)]
            public string BuildMode { get; set; }

            [NameInMap("config")]
            [Validation(Required=false)]
            public ModifyIndexRequestDataSourceInfoConfig Config { get; set; }
            public class ModifyIndexRequestDataSourceInfoConfig : TeaModel {
                [NameInMap("accessKey")]
                [Validation(Required=false)]
                public string AccessKey { get; set; }

                [NameInMap("accessSecret")]
                [Validation(Required=false)]
                public string AccessSecret { get; set; }

                [NameInMap("bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                [NameInMap("ossPath")]
                [Validation(Required=false)]
                public string OssPath { get; set; }

                [NameInMap("partition")]
                [Validation(Required=false)]
                public string Partition { get; set; }

                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                [NameInMap("table")]
                [Validation(Required=false)]
                public string Table { get; set; }

            }

            [NameInMap("dataTimeSec")]
            [Validation(Required=false)]
            public int? DataTimeSec { get; set; }

            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("generation")]
            [Validation(Required=false)]
            public long? Generation { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("processParallelNum")]
            [Validation(Required=false)]
            public int? ProcessParallelNum { get; set; }

            [NameInMap("processPartitionCount")]
            [Validation(Required=false)]
            public int? ProcessPartitionCount { get; set; }

            [NameInMap("saroConfig")]
            [Validation(Required=false)]
            public ModifyIndexRequestDataSourceInfoSaroConfig SaroConfig { get; set; }
            public class ModifyIndexRequestDataSourceInfoSaroConfig : TeaModel {
                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                [NameInMap("tableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("mergeParallelNum")]
        [Validation(Required=false)]
        public int? MergeParallelNum { get; set; }

        [NameInMap("partition")]
        [Validation(Required=false)]
        public int? Partition { get; set; }

        [NameInMap("pushMode")]
        [Validation(Required=false)]
        public string PushMode { get; set; }

        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
