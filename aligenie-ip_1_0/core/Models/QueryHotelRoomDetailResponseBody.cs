// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class QueryHotelRoomDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0EC7*726E</para>
        /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-01-01 12:00:00</para>
                /// </summary>
                [NameInMap("AuthTime")]
                [Validation(Required=false)]
                public string AuthTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rcu</para>
            /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-01-01 12:00:00</para>
                /// </summary>
                [NameInMap("ActiveTime")]
                [Validation(Required=false)]
                public string ActiveTime { get; set; }

                [NameInMap("DeviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>6.1.8-RS-20230425.1806</para>
                /// </summary>
                [NameInMap("FirmwareVersion")]
                [Validation(Required=false)]
                public string FirmwareVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>fa:03:23:58:c3:00</para>
                /// </summary>
                [NameInMap("Mac")]
                [Validation(Required=false)]
                public string Mac { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("OnlineStatus")]
                [Validation(Required=false)]
                public int? OnlineStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>sag42dlz4qf</para>
                /// </summary>
                [NameInMap("Sn")]
                [Validation(Required=false)]
                public string Sn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>41c95c18a0a643bcb58edf438877def5</para>
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>a7***83</para>
            /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("OpenCall")]
                [Validation(Required=false)]
                public bool? OpenCall { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("UnhandleTickets")]
                [Validation(Required=false)]
                public int? UnhandleTickets { get; set; }

            }

            [NameInMap("RoomControlInfo")]
            [Validation(Required=false)]
            public QueryHotelRoomDetailResponseBodyResultRoomControlInfo RoomControlInfo { get; set; }
            public class QueryHotelRoomDetailResponseBodyResultRoomControlInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>78</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public long? AppId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>app</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("DeviceInfos")]
                [Validation(Required=false)]
                public List<QueryHotelRoomDetailResponseBodyResultRoomControlInfoDeviceInfos> DeviceInfos { get; set; }
                public class QueryHotelRoomDetailResponseBodyResultRoomControlInfoDeviceInfos : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>light</para>
                    /// </summary>
                    [NameInMap("CategoryEnName")]
                    [Validation(Required=false)]
                    public string CategoryEnName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("CategoryId")]
                    [Validation(Required=false)]
                    public long? CategoryId { get; set; }

                    [NameInMap("CategoryName")]
                    [Validation(Required=false)]
                    public string CategoryName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>rcu</para>
                    /// </summary>
                    [NameInMap("DeviceConnectType")]
                    [Validation(Required=false)]
                    public string DeviceConnectType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("DeviceCount")]
                    [Validation(Required=false)]
                    public int? DeviceCount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>readLight</para>
                    /// </summary>
                    [NameInMap("DeviceId")]
                    [Validation(Required=false)]
                    public string DeviceId { get; set; }

                    [NameInMap("DeviceName")]
                    [Validation(Required=false)]
                    public string DeviceName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>room</para>
                    /// </summary>
                    [NameInMap("LocationEnName")]
                    [Validation(Required=false)]
                    public string LocationEnName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("LocationId")]
                    [Validation(Required=false)]
                    public long? LocationId { get; set; }

                    [NameInMap("LocationName")]
                    [Validation(Required=false)]
                    public string LocationName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>a1ueWGP6W2L</para>
                    /// </summary>
                    [NameInMap("ProductKey")]
                    [Validation(Required=false)]
                    public string ProductKey { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://www.xxx.com">http://www.xxx.com</a></para>
                /// </summary>
                [NameInMap("RcuUrl")]
                [Validation(Required=false)]
                public string RcuUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1170</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public long? TemplateId { get; set; }

                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2001</para>
            /// </summary>
            [NameInMap("RoomNo")]
            [Validation(Required=false)]
            public string RoomNo { get; set; }

            [NameInMap("RoomServiceInfo")]
            [Validation(Required=false)]
            public QueryHotelRoomDetailResponseBodyResultRoomServiceInfo RoomServiceInfo { get; set; }
            public class QueryHotelRoomDetailResponseBodyResultRoomServiceInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("BookServiceCnt")]
                [Validation(Required=false)]
                public int? BookServiceCnt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("GoodsServiceCnt")]
                [Validation(Required=false)]
                public int? GoodsServiceCnt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("RepairServiceCnt")]
                [Validation(Required=false)]
                public int? RepairServiceCnt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("RoomServiceCnt")]
                [Validation(Required=false)]
                public int? RoomServiceCnt { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

    }

}
