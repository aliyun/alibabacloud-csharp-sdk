// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ConfigureResultExportRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> operation to view the cluster IDs of all AnalyticDB for MySQL clusters in the destination region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-wz9509beptiz****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The export type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SLS: Exports data to SLS.</description></item>
        /// <item><description>OSS: Exports data to OSS.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SLS</para>
        /// </summary>
        [NameInMap("ExportType")]
        [Validation(Required=false)]
        public string ExportType { get; set; }

        /// <summary>
        /// <para>The OSS configuration information when the export destination is OSS.</para>
        /// </summary>
        [NameInMap("OssInfo")]
        [Validation(Required=false)]
        public ConfigureResultExportRequestOssInfo OssInfo { get; set; }
        public class ConfigureResultExportRequestOssInfo : TeaModel {
            /// <summary>
            /// <para>The OSS path where the export results are stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://testBucketName/data_result</para>
            /// </summary>
            [NameInMap("ExportBasePath")]
            [Validation(Required=false)]
            public string ExportBasePath { get; set; }

            /// <summary>
            /// <para>The name of the resource group in which the export SQL statement is executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aps</para>
            /// </summary>
            [NameInMap("ResourceGroup")]
            [Validation(Required=false)]
            public string ResourceGroup { get; set; }

            /// <summary>
            /// <para>The expiration time of the OSS file. Unit: days. The minimum value is 1 day and the maximum value is 30 days. An error is returned if the value is out of range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ResultFileTtl")]
            [Validation(Required=false)]
            public int? ResultFileTtl { get; set; }

        }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The SLS configuration information when the export destination is SLS.</para>
        /// </summary>
        [NameInMap("SlsInfo")]
        [Validation(Required=false)]
        public ConfigureResultExportRequestSlsInfo SlsInfo { get; set; }
        public class ConfigureResultExportRequestSlsInfo : TeaModel {
            /// <summary>
            /// <para>The expiration time of the temporary Logstore generated for result set export. Unit: days. The Logstore is automatically deleted after expiration. The minimum value is 1 day and the maximum value is 30 days. An error is returned if the value is out of range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("LogstoreTtl")]
            [Validation(Required=false)]
            public int? LogstoreTtl { get; set; }

            /// <summary>
            /// <para>The name of the resource group in which the export SQL statement is executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aps</para>
            /// </summary>
            [NameInMap("ResourceGroup")]
            [Validation(Required=false)]
            public string ResourceGroup { get; set; }

            /// <summary>
            /// <para>The name of the SLS project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-project</para>
            /// </summary>
            [NameInMap("SlsProject")]
            [Validation(Required=false)]
            public string SlsProject { get; set; }

        }

    }

}
