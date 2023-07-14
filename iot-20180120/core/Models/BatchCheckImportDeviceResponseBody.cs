// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchCheckImportDeviceResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned if the request succeeds. The data includes the information about devices that failed to be verified.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public BatchCheckImportDeviceResponseBodyData Data { get; set; }
        public class BatchCheckImportDeviceResponseBodyData : TeaModel {
            [NameInMap("InvalidDetailList")]
            [Validation(Required=false)]
            public List<BatchCheckImportDeviceResponseBodyDataInvalidDetailList> InvalidDetailList { get; set; }
            public class BatchCheckImportDeviceResponseBodyDataInvalidDetailList : TeaModel {
                [NameInMap("DeviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                [NameInMap("DeviceSecret")]
                [Validation(Required=false)]
                public string DeviceSecret { get; set; }

                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                [NameInMap("Sn")]
                [Validation(Required=false)]
                public string Sn { get; set; }

            }

            [NameInMap("InvalidDeviceNameList")]
            [Validation(Required=false)]
            public List<string> InvalidDeviceNameList { get; set; }

            [NameInMap("InvalidDeviceSecretList")]
            [Validation(Required=false)]
            public List<string> InvalidDeviceSecretList { get; set; }

            [NameInMap("InvalidSnList")]
            [Validation(Required=false)]
            public List<string> InvalidSnList { get; set; }

            [NameInMap("RepeatedDeviceNameList")]
            [Validation(Required=false)]
            public List<string> RepeatedDeviceNameList { get; set; }

        }

        /// <summary>
        /// The error message returned if the request fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
