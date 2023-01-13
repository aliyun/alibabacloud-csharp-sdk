// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class DeleteDeviceSpeechRequest : TeaModel {
        [NameInMap("DeviceSpeechList")]
        [Validation(Required=true)]
        public List<DeleteDeviceSpeechRequestDeviceSpeechList> DeviceSpeechList { get; set; }
        public class DeleteDeviceSpeechRequestDeviceSpeechList : TeaModel {
            [NameInMap("AudioFormat")]
            [Validation(Required=true)]
            public string AudioFormat { get; set; }

            [NameInMap("BizCode")]
            [Validation(Required=true)]
            public string BizCode { get; set; }

        }

        [NameInMap("IotId")]
        [Validation(Required=true)]
        public string IotId { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

    }

}
