// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cityvisual20181030.Models
{
    public class CreateCameraRequest : TeaModel {
        [NameInMap("CameraName")]
        [Validation(Required=false)]
        public string CameraName { get; set; }

        [NameInMap("WorkGroupId")]
        [Validation(Required=false)]
        public string WorkGroupId { get; set; }

        [NameInMap("CameraId")]
        [Validation(Required=false)]
        public string CameraId { get; set; }

        [NameInMap("LocationInfo")]
        [Validation(Required=false)]
        public string LocationInfo { get; set; }

        [NameInMap("InviteUri")]
        [Validation(Required=false)]
        public string InviteUri { get; set; }

        [NameInMap("OssPath")]
        [Validation(Required=false)]
        public string OssPath { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
