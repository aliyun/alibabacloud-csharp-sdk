// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchCheckDeviceNamesResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
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

            [NameInMap("InvalidDetailList")]
            [Validation(Required=false)]
            public BatchCheckDeviceNamesResponseBodyDataInvalidDetailList InvalidDetailList { get; set; }
            public class BatchCheckDeviceNamesResponseBodyDataInvalidDetailList : TeaModel {
                [NameInMap("InvalidDetailList")]
                [Validation(Required=false)]
                public List<BatchCheckDeviceNamesResponseBodyDataInvalidDetailListInvalidDetailList> InvalidDetailList { get; set; }
                public class BatchCheckDeviceNamesResponseBodyDataInvalidDetailListInvalidDetailList : TeaModel {
                    [NameInMap("DeviceName")]
                    [Validation(Required=false)]
                    public string DeviceName { get; set; }

                    [NameInMap("ErrorMsg")]
                    [Validation(Required=false)]
                    public string ErrorMsg { get; set; }

                    [NameInMap("NickName")]
                    [Validation(Required=false)]
                    public string NickName { get; set; }

                }

            }

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

            [NameInMap("RepeatedDeviceNameList")]
            [Validation(Required=false)]
            public BatchCheckDeviceNamesResponseBodyDataRepeatedDeviceNameList RepeatedDeviceNameList { get; set; }
            public class BatchCheckDeviceNamesResponseBodyDataRepeatedDeviceNameList : TeaModel {
                [NameInMap("RepeatDevieNameList")]
                [Validation(Required=false)]
                public List<string> RepeatDevieNameList { get; set; }

            }

        }

        /// <summary>
        /// The application ID (ApplyId) returned if the call is successful. When you call the [BatchRegisterDeviceWithApplyId](~~69514~~) operation to register the devices, this parameter is required.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The list of invalid device aliases returned if the call fails.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of invalid DeviceNames returned if the call fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
