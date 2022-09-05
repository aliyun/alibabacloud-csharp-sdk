// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeCloudDrivePermissionsResponseBody : TeaModel {
        [NameInMap("CloudDrivePermissionModels")]
        [Validation(Required=false)]
        public List<DescribeCloudDrivePermissionsResponseBodyCloudDrivePermissionModels> CloudDrivePermissionModels { get; set; }
        public class DescribeCloudDrivePermissionsResponseBodyCloudDrivePermissionModels : TeaModel {
            [NameInMap("EndUsers")]
            [Validation(Required=false)]
            public List<string> EndUsers { get; set; }

            [NameInMap("Permission")]
            [Validation(Required=false)]
            public string Permission { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
