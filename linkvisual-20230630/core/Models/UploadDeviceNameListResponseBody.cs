// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20230630.Models
{
    public class UploadDeviceNameListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public UploadDeviceNameListResponseBodyData Data { get; set; }
        public class UploadDeviceNameListResponseBodyData : TeaModel {
            [NameInMap("BatchId")]
            [Validation(Required=false)]
            public string BatchId { get; set; }

            [NameInMap("InvalidDetailList")]
            [Validation(Required=false)]
            public List<UploadDeviceNameListResponseBodyDataInvalidDetailList> InvalidDetailList { get; set; }
            public class UploadDeviceNameListResponseBodyDataInvalidDetailList : TeaModel {
                [NameInMap("DeviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

            }

            [NameInMap("InvalidDeviceNameList")]
            [Validation(Required=false)]
            public List<string> InvalidDeviceNameList { get; set; }

            [NameInMap("RepeatedDeviceNameList")]
            [Validation(Required=false)]
            public List<string> RepeatedDeviceNameList { get; set; }

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
