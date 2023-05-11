// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchGrayMigrationDeviceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public BatchGrayMigrationDeviceResponseBodyData Data { get; set; }
        public class BatchGrayMigrationDeviceResponseBodyData : TeaModel {
            [NameInMap("Details")]
            [Validation(Required=false)]
            public BatchGrayMigrationDeviceResponseBodyDataDetails Details { get; set; }
            public class BatchGrayMigrationDeviceResponseBodyDataDetails : TeaModel {
                [NameInMap("item")]
                [Validation(Required=false)]
                public List<BatchGrayMigrationDeviceResponseBodyDataDetailsItem> Item { get; set; }
                public class BatchGrayMigrationDeviceResponseBodyDataDetailsItem : TeaModel {
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }

                    [NameInMap("DeviceName")]
                    [Validation(Required=false)]
                    public string DeviceName { get; set; }

                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

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
