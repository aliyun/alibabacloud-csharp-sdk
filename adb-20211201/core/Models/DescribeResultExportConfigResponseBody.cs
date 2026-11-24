// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeResultExportConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The operation status code or POP error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidInput</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeResultExportConfigResponseBodyData Data { get; set; }
        public class DescribeResultExportConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The export type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SLS: The export destination is SLS.</description></item>
            /// <item><description>OSS: The export destination is OSS.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("ExportType")]
            [Validation(Required=false)]
            public string ExportType { get; set; }

            /// <summary>
            /// <para>The OSS information when the export type is OSS.</para>
            /// </summary>
            [NameInMap("OssInfo")]
            [Validation(Required=false)]
            public DescribeResultExportConfigResponseBodyDataOssInfo OssInfo { get; set; }
            public class DescribeResultExportConfigResponseBodyDataOssInfo : TeaModel {
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
                /// <para>The expiration time of the OSS files. Unit: days. Minimum value: 1. Maximum value: 30.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ResultFileTtl")]
                [Validation(Required=false)]
                public int? ResultFileTtl { get; set; }

            }

            /// <summary>
            /// <para>The SLS configurations when the export type is SLS.</para>
            /// </summary>
            [NameInMap("SlsInfo")]
            [Validation(Required=false)]
            public DescribeResultExportConfigResponseBodyDataSlsInfo SlsInfo { get; set; }
            public class DescribeResultExportConfigResponseBodyDataSlsInfo : TeaModel {
                /// <summary>
                /// <para>The expiration time of the temporarily generated Logstore for result set export. Unit: days. The Logstore is automatically deleted after it expires. Minimum value: 1. Maximum value: 30.</para>
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

        /// <summary>
        /// <para>The HTTP status code returned. A status code of 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The message returned for the call result.</para>
        /// <list type="bullet">
        /// <item><description>If the request is successful, <b>OK</b> is returned. </description></item>
        /// <item><description>If an exception occurs, the specific error message is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b>: The request is successful.</description></item>
        /// <item><description><b>False</b>: The request failed.</description></item>
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
