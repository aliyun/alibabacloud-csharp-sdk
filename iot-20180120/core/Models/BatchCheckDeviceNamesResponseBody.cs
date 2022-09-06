// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchCheckDeviceNamesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public BatchCheckDeviceNamesResponseBodyData Data { get; set; }
        public class BatchCheckDeviceNamesResponseBodyData : TeaModel {
            [NameInMap("ApplyId")]
            [Validation(Required=false)]
            public long? ApplyId { get; set; }

            [NameInMap("InvalidDeviceNameList")]
            [Validation(Required=false)]
            public BatchCheckDeviceNamesResponseBodyDataInvalidDeviceNameList InvalidDeviceNameList { get; set; }
            public class BatchCheckDeviceNamesResponseBodyDataInvalidDeviceNameList : TeaModel {
                [NameInMap("InvalidDeviceName")]
                [Validation(Required=false)]
                public List<string> InvalidDeviceName { get; set; }

            }

            [NameInMap("InvalidDeviceNicknameList")]
            [Validation(Required=false)]
            public BatchCheckDeviceNamesResponseBodyDataInvalidDeviceNicknameList InvalidDeviceNicknameList { get; set; }
            public class BatchCheckDeviceNamesResponseBodyDataInvalidDeviceNicknameList : TeaModel {
                [NameInMap("InvalidDeviceNickname")]
                [Validation(Required=false)]
                public List<string> InvalidDeviceNickname { get; set; }

            }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
