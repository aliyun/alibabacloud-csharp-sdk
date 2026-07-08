// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ListCloudAppInstallationsResponseBody : TeaModel {
        /// <summary>
        /// <para>List of installation records.</para>
        /// </summary>
        [NameInMap("InstallationInfos")]
        [Validation(Required=false)]
        public List<ListCloudAppInstallationsResponseBodyInstallationInfos> InstallationInfos { get; set; }
        public class ListCloudAppInstallationsResponseBodyInstallationInfos : TeaModel {
            /// <summary>
            /// <para>Application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cap-b06b26edfhytbn b94a75ae1a79efc90eb</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>Application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>com.aaa.bbb</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>Application version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.5.0</para>
            /// </summary>
            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            /// <summary>
            /// <para>Installation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-05-28T14:48:34+08:00</para>
            /// </summary>
            [NameInMap("InstallationTime")]
            [Validation(Required=false)]
            public string InstallationTime { get; set; }

            /// <summary>
            /// <para>Patch package ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>patch-7bdf679812484df08a956b73e0b3bdf6</para>
            /// </summary>
            [NameInMap("PatchId")]
            [Validation(Required=false)]
            public string PatchId { get; set; }

            /// <summary>
            /// <para>Cloud application service instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>render-9f8c57355d224ad7beaf95e145f22111</para>
            /// </summary>
            [NameInMap("RenderingInstanceId")]
            [Validation(Required=false)]
            public string RenderingInstanceId { get; set; }

            /// <summary>
            /// <para>Cloud application installation status. Valid values:</para>
            /// <ol>
            /// <item><description><para>Intermediate states: install-init, installing</para>
            /// </description></item>
            /// <item><description><para>Final states: installed, install-failed</para>
            /// </description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>installed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Status description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>install success</para>
            /// </summary>
            [NameInMap("StatusDescription")]
            [Validation(Required=false)]
            public string StatusDescription { get; set; }

            /// <summary>
            /// <para>Time when the status was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-05-28T14:50:04+08:00</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>Page number of the returned list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>Number of entries per page for paged queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of installation records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
