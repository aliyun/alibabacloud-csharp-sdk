// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ConfigureResultExportRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-wz9509beptiz****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SLS</para>
        /// </summary>
        [NameInMap("ExportType")]
        [Validation(Required=false)]
        public string ExportType { get; set; }

        [NameInMap("OssInfo")]
        [Validation(Required=false)]
        public ConfigureResultExportRequestOssInfo OssInfo { get; set; }
        public class ConfigureResultExportRequestOssInfo : TeaModel {
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

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SlsInfo")]
        [Validation(Required=false)]
        public ConfigureResultExportRequestSlsInfo SlsInfo { get; set; }
        public class ConfigureResultExportRequestSlsInfo : TeaModel {
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

}
