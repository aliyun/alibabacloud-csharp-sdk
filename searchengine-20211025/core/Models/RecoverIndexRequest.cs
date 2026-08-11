// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class RecoverIndexRequest : TeaModel {
        /// <summary>
        /// <para>Required when exporting to OSS.</para>
        /// </summary>
        [NameInMap("bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        /// <summary>
        /// <para>The offline deployment ID of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>277</para>
        /// </summary>
        [NameInMap("buildDeployId")]
        [Validation(Required=false)]
        public int? BuildDeployId { get; set; }

        /// <summary>
        /// <para>The data source name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ha-cn-pl32rf0****_test_api</para>
        /// </summary>
        [NameInMap("dataSourceName")]
        [Validation(Required=false)]
        public string DataSourceName { get; set; }

        /// <summary>
        /// <para>The full index version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1653018575</para>
        /// </summary>
        [NameInMap("generation")]
        [Validation(Required=false)]
        public string Generation { get; set; }

        /// <summary>
        /// <para>The index name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_api</para>
        /// </summary>
        [NameInMap("indexName")]
        [Validation(Required=false)]
        public string IndexName { get; set; }

        /// <summary>
        /// <para>Required when exporting to MaxCompute.</para>
        /// </summary>
        [NameInMap("odpsAccessId")]
        [Validation(Required=false)]
        public string OdpsAccessId { get; set; }

        /// <summary>
        /// <para>Required when exporting to MaxCompute.</para>
        /// </summary>
        [NameInMap("odpsAccessKey")]
        [Validation(Required=false)]
        public string OdpsAccessKey { get; set; }

        /// <summary>
        /// <para>Optional when exporting to MaxCompute. Example: pt=20240101.</para>
        /// </summary>
        [NameInMap("odpsPartition")]
        [Validation(Required=false)]
        public string OdpsPartition { get; set; }

        /// <summary>
        /// <para>Required when exporting to MaxCompute.</para>
        /// </summary>
        [NameInMap("odpsProject")]
        [Validation(Required=false)]
        public string OdpsProject { get; set; }

        /// <summary>
        /// <para>Required when exporting to MaxCompute.</para>
        /// </summary>
        [NameInMap("odpsTable")]
        [Validation(Required=false)]
        public string OdpsTable { get; set; }

        /// <summary>
        /// <para>The export type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>api: exports data to HDFS. This is the default value.</description></item>
        /// <item><description>oss: exports data to OSS.</description></item>
        /// <item><description>odps: exports data to MaxCompute.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("outPutType")]
        [Validation(Required=false)]
        public string OutPutType { get; set; }

        /// <summary>
        /// <para>Required when exporting to OSS. The path must start with a forward slash (/) and must contain &quot;opensearch&quot; or the bucket must have the opensearch tag.</para>
        /// </summary>
        [NameInMap("path")]
        [Validation(Required=false)]
        public string Path { get; set; }

    }

}
