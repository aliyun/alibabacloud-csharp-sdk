// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeCloudDrivePermissionsResponseBody : TeaModel {
        /// <summary>
        /// <para>List of enterprise cloud drive permission information.</para>
        /// </summary>
        [NameInMap("CloudDrivePermissionModels")]
        [Validation(Required=false)]
        public List<DescribeCloudDrivePermissionsResponseBodyCloudDrivePermissionModels> CloudDrivePermissionModels { get; set; }
        public class DescribeCloudDrivePermissionsResponseBodyCloudDrivePermissionModels : TeaModel {
            /// <summary>
            /// <para>List of end user IDs.</para>
            /// </summary>
            [NameInMap("EndUsers")]
            [Validation(Required=false)]
            public List<string> EndUsers { get; set; }

            /// <summary>
            /// <para>File transfer permission between the enterprise cloud drive and on-premises devices for the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CDS_DOWNLOAD</para>
            /// </summary>
            [NameInMap("Permission")]
            [Validation(Required=false)]
            public string Permission { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A87DBB05-653A-5E4B-B72B-5F4A1E07E5B3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
