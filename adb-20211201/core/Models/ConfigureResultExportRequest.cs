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
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> operation to query the information about all AnalyticDB for MySQL clusters within a region, including cluster IDs.</para>
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
        /// <item><description>SLS: Specifies that the export destination is SLS.</description></item>
        /// <item><description>OSS: Specifies that the export destination is OSS.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SLS</para>
        /// </summary>
        [NameInMap("ExportType")]
        [Validation(Required=false)]
        public string ExportType { get; set; }

        /// <summary>
        /// <para>The OSS configuration details if the destination is of the OSS type.</para>
        /// </summary>
        [NameInMap("OssInfo")]
        [Validation(Required=false)]
        public ConfigureResultExportRequestOssInfo OssInfo { get; set; }
        public class ConfigureResultExportRequestOssInfo : TeaModel {
            /// <summary>
            /// <para>The OSS path where the result sets are stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://testBucketName/data_result</para>
            /// </summary>
            [NameInMap("ExportBasePath")]
            [Validation(Required=false)]
            public string ExportBasePath { get; set; }

            /// <summary>
            /// <para>The name of the resource group that runs the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aps</para>
            /// </summary>
            [NameInMap("ResourceGroup")]
            [Validation(Required=false)]
            public string ResourceGroup { get; set; }

            /// <summary>
            /// <para>The expiration time of the OSS file. Unit: days. Minimum: 1 day, maximum: 30 days. Values outside this range will result in an error.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ResultFileTtl")]
            [Validation(Required=false)]
            public int? ResultFileTtl { get; set; }

        }

        /// <summary>
        /// <para>The ID of the region where the instance resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The SLS configuration details if the destination is of the SLS type.</para>
        /// </summary>
        [NameInMap("SlsInfo")]
        [Validation(Required=false)]
        public ConfigureResultExportRequestSlsInfo SlsInfo { get; set; }
        public class ConfigureResultExportRequestSlsInfo : TeaModel {
            /// <summary>
            /// <para>The expiration time of the Logstore temporarily generated during the result set export. Unit: days. The Logstore is automatically deleted after it expires. Minimum value: 1 day, maximum: 30 days. Values outside this range will result in an error.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("LogstoreTtl")]
            [Validation(Required=false)]
            public int? LogstoreTtl { get; set; }

            /// <summary>
            /// <para>The name of the resource group that runs the job.</para>
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
