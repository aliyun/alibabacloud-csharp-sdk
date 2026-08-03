// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class GlobalHotelBatchGetHotelDetailResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GlobalHotelBatchGetHotelDetailResponseBodyData Data { get; set; }
        public class GlobalHotelBatchGetHotelDetailResponseBodyData : TeaModel {
            [NameInMap("Hotels")]
            [Validation(Required=false)]
            public List<GlobalHotelBatchGetHotelDetailResponseBodyDataHotels> Hotels { get; set; }
            public class GlobalHotelBatchGetHotelDetailResponseBodyDataHotels : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>No.33 East Chang An Avenue</para>
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>14:00</para>
                /// </summary>
                [NameInMap("CheckInTime")]
                [Validation(Required=false)]
                public string CheckInTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12:00</para>
                /// </summary>
                [NameInMap("CheckOutTime")]
                [Validation(Required=false)]
                public string CheckOutTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Beijing</para>
                /// </summary>
                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>China</para>
                /// </summary>
                [NameInMap("CountryName")]
                [Validation(Required=false)]
                public string CountryName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>五星级豪华酒店</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HOTEL_NOT_FOUND</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>酒店不存在</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("Facilities")]
                [Validation(Required=false)]
                public List<GlobalHotelBatchGetHotelDetailResponseBodyDataHotelsFacilities> Facilities { get; set; }
                public class GlobalHotelBatchGetHotelDetailResponseBodyDataHotelsFacilities : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>室外恒温泳池</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>F001</para>
                    /// </summary>
                    [NameInMap("FacilityId")]
                    [Validation(Required=false)]
                    public string FacilityId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>游泳池</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Beijing Hotel</para>
                /// </summary>
                [NameInMap("HotelName")]
                [Validation(Required=false)]
                public string HotelName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>北京饭店</para>
                /// </summary>
                [NameInMap("HotelNameCn")]
                [Validation(Required=false)]
                public string HotelNameCn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>LUXURY</para>
                /// </summary>
                [NameInMap("HotelType")]
                [Validation(Required=false)]
                public string HotelType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>39.9042</para>
                /// </summary>
                [NameInMap("Latitude")]
                [Validation(Required=false)]
                public string Latitude { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>116.4074</para>
                /// </summary>
                [NameInMap("Longitude")]
                [Validation(Required=false)]
                public string Longitude { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2018</para>
                /// </summary>
                [NameInMap("OpeningTime")]
                [Validation(Required=false)]
                public int? OpeningTime { get; set; }

                [NameInMap("Pictures")]
                [Validation(Required=false)]
                public List<GlobalHotelBatchGetHotelDetailResponseBodyDataHotelsPictures> Pictures { get; set; }
                public class GlobalHotelBatchGetHotelDetailResponseBodyDataHotelsPictures : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>酒店大堂</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>HOTEL</para>
                    /// </summary>
                    [NameInMap("FirstCategoryCode")]
                    [Validation(Required=false)]
                    public string FirstCategoryCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>酒店</para>
                    /// </summary>
                    [NameInMap("FirstCategoryName")]
                    [Validation(Required=false)]
                    public string FirstCategoryName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("IsHeadPic")]
                    [Validation(Required=false)]
                    public bool? IsHeadPic { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>PIC001</para>
                    /// </summary>
                    [NameInMap("PictureId")]
                    [Validation(Required=false)]
                    public string PictureId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>LOBBY</para>
                    /// </summary>
                    [NameInMap("SecondCategoryCode")]
                    [Validation(Required=false)]
                    public string SecondCategoryCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>大堂</para>
                    /// </summary>
                    [NameInMap("SecondCategoryName")]
                    [Validation(Required=false)]
                    public string SecondCategoryName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://img.example.com/1.jpg">https://img.example.com/1.jpg</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                [NameInMap("Policies")]
                [Validation(Required=false)]
                public List<GlobalHotelBatchGetHotelDetailResponseBodyDataHotelsPolicies> Policies { get; set; }
                public class GlobalHotelBatchGetHotelDetailResponseBodyDataHotelsPolicies : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>入住政策</para>
                    /// </summary>
                    [NameInMap("GroupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CHECK_IN</para>
                    /// </summary>
                    [NameInMap("GroupTypeId")]
                    [Validation(Required=false)]
                    public string GroupTypeId { get; set; }

                    [NameInMap("Items")]
                    [Validation(Required=false)]
                    public List<GlobalHotelBatchGetHotelDetailResponseBodyDataHotelsPoliciesItems> Items { get; set; }
                    public class GlobalHotelBatchGetHotelDetailResponseBodyDataHotelsPoliciesItems : TeaModel {
                        [NameInMap("Children")]
                        [Validation(Required=false)]
                        public List<object> Children { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>入住时间</para>
                        /// </summary>
                        [NameInMap("ItemName")]
                        [Validation(Required=false)]
                        public string ItemName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>CHECK_IN_TIME</para>
                        /// </summary>
                        [NameInMap("ItemTypeId")]
                        [Validation(Required=false)]
                        public string ItemTypeId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>14:00</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>GOOGLE</para>
                /// </summary>
                [NameInMap("PositionType")]
                [Validation(Required=false)]
                public string PositionType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021</para>
                /// </summary>
                [NameInMap("RenovationTime")]
                [Validation(Required=false)]
                public int? RenovationTime { get; set; }

                [NameInMap("RoomTypes")]
                [Validation(Required=false)]
                public List<GlobalHotelBatchGetHotelDetailResponseBodyDataHotelsRoomTypes> RoomTypes { get; set; }
                public class GlobalHotelBatchGetHotelDetailResponseBodyDataHotelsRoomTypes : TeaModel {
                    [NameInMap("BedType")]
                    [Validation(Required=false)]
                    public List<GlobalHotelBatchGetHotelDetailResponseBodyDataHotelsRoomTypesBedType> BedType { get; set; }
                    public class GlobalHotelBatchGetHotelDetailResponseBodyDataHotelsRoomTypesBedType : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("BedCount")]
                        [Validation(Required=false)]
                        public int? BedCount { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1.8</para>
                        /// </summary>
                        [NameInMap("BedSize")]
                        [Validation(Required=false)]
                        public string BedSize { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>大床</para>
                        /// </summary>
                        [NameInMap("BedType")]
                        [Validation(Required=false)]
                        public string BedType { get; set; }

                    }

                    [NameInMap("Pictures")]
                    [Validation(Required=false)]
                    public List<GlobalHotelBatchGetHotelDetailResponseBodyDataHotelsRoomTypesPictures> Pictures { get; set; }
                    public class GlobalHotelBatchGetHotelDetailResponseBodyDataHotelsRoomTypesPictures : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>酒店大堂</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>HOTEL</para>
                        /// </summary>
                        [NameInMap("FirstCategoryCode")]
                        [Validation(Required=false)]
                        public string FirstCategoryCode { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>酒店</para>
                        /// </summary>
                        [NameInMap("FirstCategoryName")]
                        [Validation(Required=false)]
                        public string FirstCategoryName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("IsHeadPic")]
                        [Validation(Required=false)]
                        public bool? IsHeadPic { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>PIC001</para>
                        /// </summary>
                        [NameInMap("PictureId")]
                        [Validation(Required=false)]
                        public string PictureId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>LOBBY</para>
                        /// </summary>
                        [NameInMap("SecondCategoryCode")]
                        [Validation(Required=false)]
                        public string SecondCategoryCode { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>大堂</para>
                        /// </summary>
                        [NameInMap("SecondCategoryName")]
                        [Validation(Required=false)]
                        public string SecondCategoryName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para><a href="https://img.example.com/1.jpg">https://img.example.com/1.jpg</a></para>
                        /// </summary>
                        [NameInMap("Url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Deluxe King Room</para>
                    /// </summary>
                    [NameInMap("RoomName")]
                    [Validation(Required=false)]
                    public string RoomName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>豪华大床房</para>
                    /// </summary>
                    [NameInMap("RoomNameCn")]
                    [Validation(Required=false)]
                    public string RoomNameCn { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>35.0</para>
                    /// </summary>
                    [NameInMap("RoomSize")]
                    [Validation(Required=false)]
                    public double? RoomSize { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>SQM</para>
                    /// </summary>
                    [NameInMap("RoomSizeUnit")]
                    [Validation(Required=false)]
                    public string RoomSizeUnit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>R001</para>
                    /// </summary>
                    [NameInMap("StandardRoomId")]
                    [Validation(Required=false)]
                    public string StandardRoomId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>WINDOW</para>
                    /// </summary>
                    [NameInMap("WindowType")]
                    [Validation(Required=false)]
                    public string WindowType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>SMALL_WINDOW</para>
                    /// </summary>
                    [NameInMap("WindowTypeDefect")]
                    [Validation(Required=false)]
                    public string WindowTypeDefect { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>H001</para>
                /// </summary>
                [NameInMap("StandardHotelId")]
                [Validation(Required=false)]
                public string StandardHotelId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Star")]
                [Validation(Required=false)]
                public string Star { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ONLINE</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>+86-10-65137766</para>
                /// </summary>
                [NameInMap("Tel")]
                [Validation(Required=false)]
                public string Tel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Asia/Shanghai</para>
                /// </summary>
                [NameInMap("Timezone")]
                [Validation(Required=false)]
                public string Timezone { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CityCodeRequired</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>城市编码不能为空</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>260E4F99-983D-1919-834C-5C42E98E5B2B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>traceId</para>
        /// </summary>
        [NameInMap("TracerId")]
        [Validation(Required=false)]
        public string TracerId { get; set; }

    }

}
