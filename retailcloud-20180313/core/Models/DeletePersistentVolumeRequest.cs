// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class DeletePersistentVolumeRequest : TeaModel {
        [NameInMap("ClusterInstanceId")]
        [Validation(Required=false)]
        public string ClusterInstanceId { get; set; }

        [NameInMap("PersistentVolumeName")]
        [Validation(Required=false)]
        public string PersistentVolumeName { get; set; }

    }

}
