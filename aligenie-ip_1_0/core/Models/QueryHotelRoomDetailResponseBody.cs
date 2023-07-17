// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class QueryHotelRoomDetailResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryHotelRoomDetailResponseBodyResult Result { get; set; }
        public class QueryHotelRoomDetailResponseBodyResult : TeaModel {
            [NameInMap("AuthAccounts")]
            [Validation(Required=false)]
            public List<QueryHotelRoomDetailResponseBodyResultAuthAccounts> AuthAccounts { get; set; }
            public class QueryHotelRoomDetailResponseBodyResultAuthAccounts : TeaModel {
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                [NameInMap("AuthTime")]
                [Validation(Required=false)]
                public string AuthTime { get; set; }

            }

            [NameInMap("ConnectType")]
            [Validation(Required=false)]
            public string ConnectType { get; set; }

            [NameInMap("CreatorAccountName")]
            [Validation(Required=false)]
            public string CreatorAccountName { get; set; }

            [NameInMap("DeviceInfos")]
            [Validation(Required=false)]
            public List<QueryHotelRoomDetailResponseBodyResultDeviceInfos> DeviceInfos { get; set; }
            public class QueryHotelRoomDetailResponseBodyResultDeviceInfos : TeaModel {
                [NameInMap("ActiveTime")]
                [Validation(Required=false)]
                public string ActiveTime { get; set; }

                [NameInMap("DeviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                [NameInMap("FirmwareVersion")]
                [Validation(Required=false)]
                public string FirmwareVersion { get; set; }

                [NameInMap("Mac")]
                [Validation(Required=false)]
                public string Mac { get; set; }

                [NameInMap("OnlineStatus")]
                [Validation(Required=false)]
                public int? OnlineStatus { get; set; }

                [NameInMap("Sn")]
                [Validation(Required=false)]
                public string Sn { get; set; }

                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            [NameInMap("HotelId")]
            [Validation(Required=false)]
            public string HotelId { get; set; }

            [NameInMap("HotelName")]
            [Validation(Required=false)]
            public string HotelName { get; set; }

            [NameInMap("OtherService")]
            [Validation(Required=false)]
            public QueryHotelRoomDetailResponseBodyResultOtherService OtherService { get; set; }
            public class QueryHotelRoomDetailResponseBodyResultOtherService : TeaModel {
                [NameInMap("OpenCall")]
                [Validation(Required=false)]
                public bool? OpenCall { get; set; }

                [NameInMap("UnhandleTickets")]
                [Validation(Required=false)]
                public int? UnhandleTickets { get; set; }

            }

            [NameInMap("RoomControlInfo")]
            [Validation(Required=false)]
            public QueryHotelRoomDetailResponseBodyResultRoomControlInfo RoomControlInfo { get; set; }
            public class QueryHotelRoomDetailResponseBodyResultRoomControlInfo : TeaModel {
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public long? AppId { get; set; }

                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("DeviceInfos")]
                [Validation(Required=false)]
                public List<QueryHotelRoomDetailResponseBodyResultRoomControlInfoDeviceInfos> DeviceInfos { get; set; }
                public class QueryHotelRoomDetailResponseBodyResultRoomControlInfoDeviceInfos : TeaModel {
                    [NameInMap("CategoryEnName")]
                    [Validation(Required=false)]
                    public string CategoryEnName { get; set; }

                    [NameInMap("CategoryId")]
                    [Validation(Required=false)]
                    public long? CategoryId { get; set; }

                    [NameInMap("CategoryName")]
                    [Validation(Required=false)]
                    public string CategoryName { get; set; }

                    [NameInMap("DeviceConnectType")]
                    [Validation(Required=false)]
                    public string DeviceConnectType { get; set; }

                    [NameInMap("DeviceCount")]
                    [Validation(Required=false)]
                    public int? DeviceCount { get; set; }

                    [NameInMap("DeviceId")]
                    [Validation(Required=false)]
                    public string DeviceId { get; set; }

                    [NameInMap("DeviceName")]
                    [Validation(Required=false)]
                    public string DeviceName { get; set; }

                    [NameInMap("LocationEnName")]
                    [Validation(Required=false)]
                    public string LocationEnName { get; set; }

                    [NameInMap("LocationId")]
                    [Validation(Required=false)]
                    public long? LocationId { get; set; }

                    [NameInMap("LocationName")]
                    [Validation(Required=false)]
                    public string LocationName { get; set; }

                    [NameInMap("ProductKey")]
                    [Validation(Required=false)]
                    public string ProductKey { get; set; }

                }

                [NameInMap("RcuUrl")]
                [Validation(Required=false)]
                public string RcuUrl { get; set; }

                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public long? TemplateId { get; set; }

                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

            }

            [NameInMap("RoomNo")]
            [Validation(Required=false)]
            public string RoomNo { get; set; }

            [NameInMap("RoomServiceInfo")]
            [Validation(Required=false)]
            public QueryHotelRoomDetailResponseBodyResultRoomServiceInfo RoomServiceInfo { get; set; }
            public class QueryHotelRoomDetailResponseBodyResultRoomServiceInfo : TeaModel {
                [NameInMap("BookServiceCnt")]
                [Validation(Required=false)]
                public int? BookServiceCnt { get; set; }

                [NameInMap("GoodsServiceCnt")]
                [Validation(Required=false)]
                public int? GoodsServiceCnt { get; set; }

                [NameInMap("RepairServiceCnt")]
                [Validation(Required=false)]
                public int? RepairServiceCnt { get; set; }

                [NameInMap("RoomServiceCnt")]
                [Validation(Required=false)]
                public int? RoomServiceCnt { get; set; }

            }

        }

        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

    }

}
