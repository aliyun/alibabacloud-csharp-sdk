// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchImportVehicleDeviceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public BatchImportVehicleDeviceResponseBodyData Data { get; set; }
        public class BatchImportVehicleDeviceResponseBodyData : TeaModel {
            [NameInMap("ApplyId")]
            [Validation(Required=false)]
            public long? ApplyId { get; set; }

            [NameInMap("InvalidDetailList")]
            [Validation(Required=false)]
            public BatchImportVehicleDeviceResponseBodyDataInvalidDetailList InvalidDetailList { get; set; }
            public class BatchImportVehicleDeviceResponseBodyDataInvalidDetailList : TeaModel {
                [NameInMap("InvalidDetailList")]
                [Validation(Required=false)]
                public List<BatchImportVehicleDeviceResponseBodyDataInvalidDetailListInvalidDetailList> InvalidDetailList { get; set; }
                public class BatchImportVehicleDeviceResponseBodyDataInvalidDetailListInvalidDetailList : TeaModel {
                    [NameInMap("DeviceId")]
                    [Validation(Required=false)]
                    public string DeviceId { get; set; }

                    [NameInMap("DeviceModel")]
                    [Validation(Required=false)]
                    public string DeviceModel { get; set; }

                    [NameInMap("DeviceName")]
                    [Validation(Required=false)]
                    public string DeviceName { get; set; }

                    [NameInMap("ErrorMsg")]
                    [Validation(Required=false)]
                    public string ErrorMsg { get; set; }

                    [NameInMap("Manufacturer")]
                    [Validation(Required=false)]
                    public string Manufacturer { get; set; }

                }

            }

            [NameInMap("InvalidDeviceIdList")]
            [Validation(Required=false)]
            public BatchImportVehicleDeviceResponseBodyDataInvalidDeviceIdList InvalidDeviceIdList { get; set; }
            public class BatchImportVehicleDeviceResponseBodyDataInvalidDeviceIdList : TeaModel {
                [NameInMap("invalidDeviceIdList")]
                [Validation(Required=false)]
                public List<string> InvalidDeviceIdList { get; set; }

            }

            [NameInMap("InvalidDeviceModelList")]
            [Validation(Required=false)]
            public BatchImportVehicleDeviceResponseBodyDataInvalidDeviceModelList InvalidDeviceModelList { get; set; }
            public class BatchImportVehicleDeviceResponseBodyDataInvalidDeviceModelList : TeaModel {
                [NameInMap("invalidDeviceModelList")]
                [Validation(Required=false)]
                public List<string> InvalidDeviceModelList { get; set; }

            }

            [NameInMap("InvalidDeviceNameList")]
            [Validation(Required=false)]
            public BatchImportVehicleDeviceResponseBodyDataInvalidDeviceNameList InvalidDeviceNameList { get; set; }
            public class BatchImportVehicleDeviceResponseBodyDataInvalidDeviceNameList : TeaModel {
                [NameInMap("InvalidDeviceNameList")]
                [Validation(Required=false)]
                public List<string> InvalidDeviceNameList { get; set; }

            }

            [NameInMap("InvalidManufacturerList")]
            [Validation(Required=false)]
            public BatchImportVehicleDeviceResponseBodyDataInvalidManufacturerList InvalidManufacturerList { get; set; }
            public class BatchImportVehicleDeviceResponseBodyDataInvalidManufacturerList : TeaModel {
                [NameInMap("invalidManufacturerList")]
                [Validation(Required=false)]
                public List<string> InvalidManufacturerList { get; set; }

            }

            [NameInMap("RepeatedDeviceIdList")]
            [Validation(Required=false)]
            public BatchImportVehicleDeviceResponseBodyDataRepeatedDeviceIdList RepeatedDeviceIdList { get; set; }
            public class BatchImportVehicleDeviceResponseBodyDataRepeatedDeviceIdList : TeaModel {
                [NameInMap("repeatedDeviceIdList")]
                [Validation(Required=false)]
                public List<string> RepeatedDeviceIdList { get; set; }

            }

            [NameInMap("RepeatedDeviceNameList")]
            [Validation(Required=false)]
            public BatchImportVehicleDeviceResponseBodyDataRepeatedDeviceNameList RepeatedDeviceNameList { get; set; }
            public class BatchImportVehicleDeviceResponseBodyDataRepeatedDeviceNameList : TeaModel {
                [NameInMap("RepeatedDeviceNameList")]
                [Validation(Required=false)]
                public List<string> RepeatedDeviceNameList { get; set; }

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
