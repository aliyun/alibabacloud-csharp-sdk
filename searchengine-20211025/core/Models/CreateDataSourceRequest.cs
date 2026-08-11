// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class CreateDataSourceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically rebuild indexes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoBuildIndex")]
        [Validation(Required=false)]
        public bool? AutoBuildIndex { get; set; }

        /// <summary>
        /// <para>The configuration information.</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public CreateDataSourceRequestConfig Config { get; set; }
        public class CreateDataSourceRequestConfig : TeaModel {
            /// <summary>
            /// <para>The AccessKey ID of the ODPS data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>L***p</para>
            /// </summary>
            [NameInMap("accessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            /// <summary>
            /// <para>The AccessKey secret of the ODPS data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5**9a6</para>
            /// </summary>
            [NameInMap("accessSecret")]
            [Validation(Required=false)]
            public string AccessSecret { get; set; }

            /// <summary>
            /// <para>oss bucket</para>
            /// 
            /// <b>Example:</b>
            /// <para>opensearch</para>
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
            /// <para>The endpoint of the ODPS data source or the OSS data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://service.cn-hangzhou.maxcompute.aliyun-inc.com/api">http://service.cn-hangzhou.maxcompute.aliyun-inc.com/api</a></para>
            /// </summary>
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aegis-ops</para>
            /// </summary>
            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The OSS file path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/opensearch/search</para>
            /// </summary>
            [NameInMap("ossPath")]
            [Validation(Required=false)]
            public string OssPath { get; set; }

            /// <summary>
            /// <para>The ODPS partition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds=20220713</para>
            /// </summary>
            [NameInMap("partition")]
            [Validation(Required=false)]
            public string Partition { get; set; }

            /// <summary>
            /// <para>The HDFS file path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-hdfs-path</para>
            /// </summary>
            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The project name of the ODPS data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kubenest</para>
            /// </summary>
            [NameInMap("project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            /// <summary>
            /// <para>The ODPS table name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>item</para>
            /// </summary>
            [NameInMap("table")]
            [Validation(Required=false)]
            public string Table { get; set; }

            [NameInMap("tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        /// <summary>
        /// <para>The data center where the data source resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc_hz_domain_1</para>
        /// </summary>
        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The name of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ha-cn-pl32rf0****_test_api</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The Saro datasource config.</para>
        /// </summary>
        [NameInMap("saroConfig")]
        [Validation(Required=false)]
        public CreateDataSourceRequestSaroConfig SaroConfig { get; set; }
        public class CreateDataSourceRequestSaroConfig : TeaModel {
            /// <summary>
            /// <para>The namespace of the Saro data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>igraph-cn-x0r3e3abe02</para>
            /// </summary>
            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The Saro data table name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>index_hdfs</para>
            /// </summary>
            [NameInMap("tableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

        /// <summary>
        /// <para>The type of the data source. Valid values: odps, oss, and swift.</para>
        /// 
        /// <b>Example:</b>
        /// <para>odps</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run (only validates whether the data source is valid). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs a dry run.</description></item>
        /// <item><description>false: does not perform a dry run.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
