// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ConfigureResultExportResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ConfigureResultExportResponseBodyData Data { get; set; }
        public class ConfigureResultExportResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>SLS</para>
            /// </summary>
            [NameInMap("ExportType")]
            [Validation(Required=false)]
            public string ExportType { get; set; }

            [NameInMap("OssInfo")]
            [Validation(Required=false)]
            public ConfigureResultExportResponseBodyDataOssInfo OssInfo { get; set; }
            public class ConfigureResultExportResponseBodyDataOssInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>oss://testBucketName/data_result</para>
                /// </summary>
                [NameInMap("ExportBasePath")]
                [Validation(Required=false)]
                public string ExportBasePath { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>aps</para>
                /// </summary>
                [NameInMap("ResourceGroup")]
                [Validation(Required=false)]
                public string ResourceGroup { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ResultFileTtl")]
                [Validation(Required=false)]
                public int? ResultFileTtl { get; set; }

            }

            [NameInMap("SlsInfo")]
            [Validation(Required=false)]
            public ConfigureResultExportResponseBodyDataSlsInfo SlsInfo { get; set; }
            public class ConfigureResultExportResponseBodyDataSlsInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("LogstoreTtl")]
                [Validation(Required=false)]
                public int? LogstoreTtl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>aps</para>
                /// </summary>
                [NameInMap("ResourceGroup")]
                [Validation(Required=false)]
                public string ResourceGroup { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test-project</para>
                /// </summary>
                [NameInMap("SlsProject")]
                [Validation(Required=false)]
                public string SlsProject { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
