// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeResultExportConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>API status or POP error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidInput</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeResultExportConfigResponseBodyData Data { get; set; }
        public class DescribeResultExportConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The export type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SLS: Indicates that the export destination is SLS.</description></item>
            /// <item><description>OSS: Indicates that the export destination is OSS.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("ExportType")]
            [Validation(Required=false)]
            public string ExportType { get; set; }

            /// <summary>
            /// <para>The configured OSS export settings, returned when the export destination is OSS.</para>
            /// </summary>
            [NameInMap("OssInfo")]
            [Validation(Required=false)]
            public DescribeResultExportConfigResponseBodyDataOssInfo OssInfo { get; set; }
            public class DescribeResultExportConfigResponseBodyDataOssInfo : TeaModel {
                /// <summary>
                /// <para>The path of the OSS bucket to which the result sets are exported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss://testBucketName/data_result</para>
                /// </summary>
                [NameInMap("ExportBasePath")]
                [Validation(Required=false)]
                public string ExportBasePath { get; set; }

                /// <summary>
                /// <para>The name of the resource group that runs the export SQL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aps</para>
                /// </summary>
                [NameInMap("ResourceGroup")]
                [Validation(Required=false)]
                public string ResourceGroup { get; set; }

                /// <summary>
                /// <para>The expiration period (in days) for the OSS file. The returned value is between 1 and 30 days (inclusive).</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ResultFileTtl")]
                [Validation(Required=false)]
                public int? ResultFileTtl { get; set; }

            }

            /// <summary>
            /// <para>The configured SLS export settings, returned when the export destination is SLS.</para>
            /// </summary>
            [NameInMap("SlsInfo")]
            [Validation(Required=false)]
            public DescribeResultExportConfigResponseBodyDataSlsInfo SlsInfo { get; set; }
            public class DescribeResultExportConfigResponseBodyDataSlsInfo : TeaModel {
                /// <summary>
                /// <para>The expiration period (in days) for the temporary Logstore automatically created during result set export. The Logstore is automatically deleted after expiration. The returned value is between 1 and 30 days (inclusive).</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("LogstoreTtl")]
                [Validation(Required=false)]
                public int? LogstoreTtl { get; set; }

                /// <summary>
                /// <para>The name of the resource group that runs the export SQL.</para>
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

        /// <summary>
        /// <para>The HTTP response status code. A value of 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The returned message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>The request succeeded, and the server returns <b>OK</b>.</description></item>
        /// <item><description>The request failed, and the server returns an error message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values: Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True: Succeeded.</b></description></item>
        /// <item><description>**False: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
