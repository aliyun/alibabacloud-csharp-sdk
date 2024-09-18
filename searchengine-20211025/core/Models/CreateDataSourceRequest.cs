// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class CreateDataSourceRequest : TeaModel {
        /// <summary>
        /// Specifies whether to automatically rebuild the index.
        /// </summary>
        [NameInMap("autoBuildIndex")]
        [Validation(Required=false)]
        public bool? AutoBuildIndex { get; set; }

        /// <summary>
        /// The configuration information.
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public CreateDataSourceRequestConfig Config { get; set; }
        public class CreateDataSourceRequestConfig : TeaModel {
            /// <summary>
            /// The AccessKey ID of the MaxCompute data source.
            /// </summary>
            [NameInMap("accessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            /// <summary>
            /// The AccessKey secret of the MaxCompute data source.
            /// </summary>
            [NameInMap("accessSecret")]
            [Validation(Required=false)]
            public string AccessSecret { get; set; }

            /// <summary>
            /// The name of the OSS bucket.
            /// </summary>
            [NameInMap("bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            [NameInMap("catalog")]
            [Validation(Required=false)]
            public string Catalog { get; set; }

            [NameInMap("database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            /// <summary>
            /// The endpoint of the MaxCompute or Object Storage Service (OSS) data source.
            /// </summary>
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// The namespace.
            /// </summary>
            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// The path of the OSS object.
            /// </summary>
            [NameInMap("ossPath")]
            [Validation(Required=false)]
            public string OssPath { get; set; }

            /// <summary>
            /// The partition in the MaxCompute table.
            /// </summary>
            [NameInMap("partition")]
            [Validation(Required=false)]
            public string Partition { get; set; }

            /// <summary>
            /// The file path in the Apsara File Storage for HDFS file system.
            /// </summary>
            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// The name of the MaxCompute project that is used as the data source.
            /// </summary>
            [NameInMap("project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            /// <summary>
            /// The name of the MaxCompute table that is used as the data source.
            /// </summary>
            [NameInMap("table")]
            [Validation(Required=false)]
            public string Table { get; set; }

            [NameInMap("tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        /// <summary>
        /// The data center in which the data source is deployed.
        /// </summary>
        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// The name of the data source.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The configurations of the SARO data source.
        /// </summary>
        [NameInMap("saroConfig")]
        [Validation(Required=false)]
        public CreateDataSourceRequestSaroConfig SaroConfig { get; set; }
        public class CreateDataSourceRequestSaroConfig : TeaModel {
            /// <summary>
            /// The namespace of the SARO data source.
            /// </summary>
            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// The name of the SARO table.
            /// </summary>
            [NameInMap("tableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

        /// <summary>
        /// The type of the data source. Valid values: odps, oss, and swift.
        /// </summary>
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
