// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ConfigureResultExportResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The path where the result sets are stored.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ConfigureResultExportResponseBodyData Data { get; set; }
        public class ConfigureResultExportResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The export type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SLS: Indicates that the export destination is SLS.</description></item>
            /// <item><description>OSS: Indicates that the export destination is OSS.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SLS</para>
            /// </summary>
            [NameInMap("ExportType")]
            [Validation(Required=false)]
            public string ExportType { get; set; }

            /// <summary>
            /// <para>The OSS configuration if the destination is of the OSS type.</para>
            /// </summary>
            [NameInMap("OssInfo")]
            [Validation(Required=false)]
            public ConfigureResultExportResponseBodyDataOssInfo OssInfo { get; set; }
            public class ConfigureResultExportResponseBodyDataOssInfo : TeaModel {
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
                /// <para>The expiration time of the OSS file. Unit: days. Minimum: 1 day, maximum: 30 days.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ResultFileTtl")]
                [Validation(Required=false)]
                public int? ResultFileTtl { get; set; }

            }

            /// <summary>
            /// <para>The SLS configuration if the destination is of the SLS type.</para>
            /// </summary>
            [NameInMap("SlsInfo")]
            [Validation(Required=false)]
            public ConfigureResultExportResponseBodyDataSlsInfo SlsInfo { get; set; }
            public class ConfigureResultExportResponseBodyDataSlsInfo : TeaModel {
                /// <summary>
                /// <para>The expiration time of the Logstore temporarily generated during the result set export. Unit: days. The Logstore is automatically deleted after it expires. Minimum value: 1 day. Maximum value: 30 days.</para>
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

        /// <summary>
        /// <para>The HTTP status code. A value of 200 indicates that the request is successful.</para>
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
        /// <item><description>OK is returned if the request is normal.</description></item>
        /// <item><description>The specific error code is returned if the request is abnormal,</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
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
        /// <item><description><b>true</b>: Succeeded.</description></item>
        /// <item><description><b>false</b>: Failed.</description></item>
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
