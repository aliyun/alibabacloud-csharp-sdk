// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchCheckDeviceNamesResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public BatchCheckDeviceNamesResponseData Data { get; set; }
        public class BatchCheckDeviceNamesResponseData : TeaModel {
            [NameInMap("ApplyId")]
            [Validation(Required=true)]
            public long? ApplyId { get; set; }

            [NameInMap("InvalidDeviceNameList")]
            [Validation(Required=true)]
            public BatchCheckDeviceNamesResponseDataInvalidDeviceNameList InvalidDeviceNameList { get; set; }
            public class BatchCheckDeviceNamesResponseDataInvalidDeviceNameList : TeaModel {
                /// <summary>
                /// InvalidDeviceName
                /// </summary>
                [NameInMap("InvalidDeviceName")]
                [Validation(Required=true)]
                public List<string> InvalidDeviceName { get; set; }

            }

            [NameInMap("InvalidDeviceNicknameList")]
            [Validation(Required=true)]
            public BatchCheckDeviceNamesResponseDataInvalidDeviceNicknameList InvalidDeviceNicknameList { get; set; }
            public class BatchCheckDeviceNamesResponseDataInvalidDeviceNicknameList : TeaModel {
                /// <summary>
                /// InvalidDeviceNickname
                /// </summary>
                [NameInMap("InvalidDeviceNickname")]
                [Validation(Required=true)]
                public List<string> InvalidDeviceNickname { get; set; }

            }

        }

    }

}
