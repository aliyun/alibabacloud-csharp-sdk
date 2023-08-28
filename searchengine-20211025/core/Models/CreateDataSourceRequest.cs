// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class CreateDataSourceRequest : TeaModel {
        [NameInMap("autoBuildIndex")]
        [Validation(Required=false)]
        public bool? AutoBuildIndex { get; set; }

        [NameInMap("config")]
        [Validation(Required=false)]
        public CreateDataSourceRequestConfig Config { get; set; }
        public class CreateDataSourceRequestConfig : TeaModel {
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

        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("saroConfig")]
        [Validation(Required=false)]
        public CreateDataSourceRequestSaroConfig SaroConfig { get; set; }
        public class CreateDataSourceRequestSaroConfig : TeaModel {
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

        /// <summary>
        /// Specifies whether to perform a dry run. This parameter is only used to check whether the data source is valid. Valid values: true and false.
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
