// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeCloudDrivePermissionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of permission settings for the enterprise cloud drive.</para>
        /// </summary>
        [NameInMap("CloudDrivePermissionModels")]
        [Validation(Required=false)]
        public List<DescribeCloudDrivePermissionsResponseBodyCloudDrivePermissionModels> CloudDrivePermissionModels { get; set; }
        public class DescribeCloudDrivePermissionsResponseBodyCloudDrivePermissionModels : TeaModel {
            /// <summary>
            /// <para>The list of end user IDs.</para>
            /// </summary>
            [NameInMap("EndUsers")]
            [Validation(Required=false)]
            public List<string> EndUsers { get; set; }

            /// <summary>
            /// <para>The file transfer permission between the enterprise cloud drive and the on-premises device for the user. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CDS_CREATE_DOWNLOAD: has both upload and download permissions.</description></item>
            /// <item><description>CDS_DOWNLOAD: has only download permission.</description></item>
            /// <item><description>CDS_CREATE: has only upload permission.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CDS_DOWNLOAD</para>
            /// </summary>
            [NameInMap("Permission")]
            [Validation(Required=false)]
            public string Permission { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A87DBB05-653A-5E4B-B72B-5F4A1E07E5B3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
