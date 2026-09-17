// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ListCloudAppsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of cloud application information.</para>
        /// </summary>
        [NameInMap("CloudApps")]
        [Validation(Required=false)]
        public List<ListCloudAppsResponseBodyCloudApps> CloudApps { get; set; }
        public class ListCloudAppsResponseBodyCloudApps : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cap-b06b26edfhytbn b94a75ae1a79efc90eb</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>com.aaa.bbb</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The application version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.5.0</para>
            /// </summary>
            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            /// <summary>
            /// <para>The application description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The installation package format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apk</para>
            /// </summary>
            [NameInMap("PkgFormat")]
            [Validation(Required=false)]
            public string PkgFormat { get; set; }

            /// <summary>
            /// <para>The installation package type. Valid values: android and win.</para>
            /// 
            /// <b>Example:</b>
            /// <para>android</para>
            /// </summary>
            [NameInMap("PkgType")]
            [Validation(Required=false)]
            public string PkgType { get; set; }

            /// <summary>
            /// <para>The relative path of the post-command within the application package. Only win type applications are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>install.ps1</para>
            /// </summary>
            [NameInMap("PostCommandPath")]
            [Validation(Required=false)]
            public string PostCommandPath { get; set; }

            /// <summary>
            /// <para>The timeout period for post-command execution, in seconds. Only win type applications are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PostCommandTimeoutSec")]
            [Validation(Required=false)]
            public int? PostCommandTimeoutSec { get; set; }

            /// <summary>
            /// <para>The ID of the stable version patch package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>patch-7bdf679812484df08a956b73e0b3bdf6</para>
            /// </summary>
            [NameInMap("StablePatchId")]
            [Validation(Required=false)]
            public string StablePatchId { get; set; }

            /// <summary>
            /// <para>The application upload status. Valid values:</para>
            /// <ol>
            /// <item><description>Created</description></item>
            /// <item><description>Doing</description></item>
            /// <item><description>Success: desired state.</description></item>
            /// <item><description>Failed: desired state.</description></item>
            /// <item><description>Deleting</description></item>
            /// <item><description>DeleteFailed: desired state.</description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The status description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>upload success</para>
            /// </summary>
            [NameInMap("StatusDescription")]
            [Validation(Required=false)]
            public string StatusDescription { get; set; }

            /// <summary>
            /// <para>The latest status update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-05-28T14:48:34+08:00</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The application upload time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-05-28T14:28:14+08:00</para>
            /// </summary>
            [NameInMap("UploadTime")]
            [Validation(Required=false)]
            public string UploadTime { get; set; }

        }

        /// <summary>
        /// <para>The page number of the query list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for the paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of matched cloud applications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
