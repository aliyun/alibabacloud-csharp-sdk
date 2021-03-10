// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchAddDeviceGroupRelationsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ValidDeviceCount")]
        [Validation(Required=true)]
        public int? ValidDeviceCount { get; set; }

        [NameInMap("ExceedTenGroupDeviceCount")]
        [Validation(Required=true)]
        public int? ExceedTenGroupDeviceCount { get; set; }

        [NameInMap("AlreadyRelatedGroupDeviceCount")]
        [Validation(Required=true)]
        public int? AlreadyRelatedGroupDeviceCount { get; set; }

        [NameInMap("SuccessAddedDeviceCount")]
        [Validation(Required=true)]
        public int? SuccessAddedDeviceCount { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

    }

}
