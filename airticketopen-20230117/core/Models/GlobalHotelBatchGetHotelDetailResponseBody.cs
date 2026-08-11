// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class GlobalHotelBatchGetHotelDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The business data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GlobalHotelBatchGetHotelDetailResponseBodyData Data { get; set; }
        public class GlobalHotelBatchGetHotelDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of hotel details.</para>
            /// </summary>
            [NameInMap("Hotels")]
            [Validation(Required=false)]
            public List<GlobalHotelBatchGetHotelDetailResponseBodyDataHotels> Hotels { get; set; }
            public class GlobalHotelBatchGetHotelDetailResponseBodyDataHotels : TeaModel {
                /// <summary>
                /// <para>The address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>No.33 East Chang An Avenue</para>
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <para>The default check-in time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>14:00</para>
                /// </summary>
                [NameInMap("CheckInTime")]
                [Validation(Required=false)]
                public string CheckInTime { get; set; }

                /// <summary>
                /// <para>The default check-out time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12:00</para>
                /// </summary>
                [NameInMap("CheckOutTime")]
                [Validation(Required=false)]
                public string CheckOutTime { get; set; }

                /// <summary>
                /// <para>The city name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Beijing</para>
                /// </summary>
                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                /// <summary>
                /// <para>The country name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>China</para>
                /// </summary>
                [NameInMap("CountryName")]
                [Validation(Required=false)]
                public string CountryName { get; set; }

                /// <summary>
                /// <para>The hotel description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Five-star luxury hotel</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The error code for the individual hotel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HOTEL_NOT_FOUND</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The error message for the individual hotel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hotel does not exist</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The list of facilities.</para>
                /// </summary>
                [NameInMap("Facilities")]
                [Validation(Required=false)]
                public List<GlobalHotelBatchGetHotelDetailResponseBodyDataHotelsFacilities> Facilities { get; set; }
                public class GlobalHotelBatchGetHotelDetailResponseBodyDataHotelsFacilities : TeaModel {
                    /// <summary>
                    /// <para>The facility description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Outdoor heated swimming pool</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The facility name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Swimming Pool</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The facility type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>parkade</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The hotel name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Beijing Hotel</para>
                /// </summary>
                [NameInMap("HotelName")]
                [Validation(Required=false)]
                public string HotelName { get; set; }

                /// <summary>
                /// <para>The Chinese hotel name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>北京饭店</para>
                /// </summary>
                [NameInMap("HotelNameCn")]
                [Validation(Required=false)]
                public string HotelNameCn { get; set; }

                /// <summary>
                /// <para>The hotel type (LUXURY/DELUXE/COMFORT).</para>
                /// 
                /// <b>Example:</b>
                /// <para>LUXURY</para>
                /// </summary>
                [NameInMap("HotelType")]
                [Validation(Required=false)]
                public string HotelType { get; set; }

                /// <summary>
                /// <para>The latitude.</para>
                /// 
                /// <b>Example:</b>
                /// <para>39.9042</para>
                /// </summary>
                [NameInMap("Latitude")]
                [Validation(Required=false)]
                public string Latitude { get; set; }

                /// <summary>
                /// <para>The longitude.</para>
                /// 
                /// <b>Example:</b>
                /// <para>116.4074</para>
                /// </summary>
                [NameInMap("Longitude")]
                [Validation(Required=false)]
                public string Longitude { get; set; }

                /// <summary>
                /// <para>The opening year.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018</para>
                /// </summary>
                [NameInMap("OpeningTime")]
                [Validation(Required=false)]
                public int? OpeningTime { get; set; }

                /// <summary>
                /// <para>The list of pictures.</para>
                /// </summary>
                [NameInMap("Pictures")]
                [Validation(Required=false)]
                public List<GlobalHotelBatchGetHotelDetailResponseBodyDataHotelsPictures> Pictures { get; set; }
                public class GlobalHotelBatchGetHotelDetailResponseBodyDataHotelsPictures : TeaModel {
                    /// <summary>
                    /// <para>The picture description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Hotel lobby</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The first-level category code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HOTEL</para>
                    /// </summary>
                    [NameInMap("FirstCategoryCode")]
                    [Validation(Required=false)]
                    public string FirstCategoryCode { get; set; }

                    /// <summary>
                    /// <para>The first-level category name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Hotel</para>
                    /// </summary>
                    [NameInMap("FirstCategoryName")]
                    [Validation(Required=false)]
                    public string FirstCategoryName { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the picture is the cover image.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("IsHeadPic")]
                    [Validation(Required=false)]
                    public bool? IsHeadPic { get; set; }

                    /// <summary>
                    /// <para>The picture ID (subject to the URL).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PIC001</para>
                    /// </summary>
                    [NameInMap("PictureId")]
                    [Validation(Required=false)]
                    public string PictureId { get; set; }

                    /// <summary>
                    /// <para>The second-level category code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>LOBBY</para>
                    /// </summary>
                    [NameInMap("SecondCategoryCode")]
                    [Validation(Required=false)]
                    public string SecondCategoryCode { get; set; }

                    /// <summary>
                    /// <para>The second-level category name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Lobby</para>
                    /// </summary>
                    [NameInMap("SecondCategoryName")]
                    [Validation(Required=false)]
                    public string SecondCategoryName { get; set; }

                    /// <summary>
                    /// <para>The picture URL.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://img.example.com/1.jpg">https://img.example.com/1.jpg</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <para>The hotel policy information.</para>
                /// </summary>
                [NameInMap("Policies")]
                [Validation(Required=false)]
                public List<GlobalHotelBatchGetHotelDetailResponseBodyDataHotelsPolicies> Policies { get; set; }
                public class GlobalHotelBatchGetHotelDetailResponseBodyDataHotelsPolicies : TeaModel {
                    /// <summary>
                    /// <para>The group name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Check-in Policy</para>
                    /// </summary>
                    [NameInMap("GroupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    /// <summary>
                    /// <para>The group type ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CHECK_IN</para>
                    /// </summary>
                    [NameInMap("GroupTypeId")]
                    [Validation(Required=false)]
                    public string GroupTypeId { get; set; }

                    /// <summary>
                    /// <para>The list of policy items.</para>
                    /// </summary>
                    [NameInMap("Items")]
                    [Validation(Required=false)]
                    public List<GlobalHotelBatchGetHotelDetailResponseBodyDataHotelsPoliciesItems> Items { get; set; }
                    public class GlobalHotelBatchGetHotelDetailResponseBodyDataHotelsPoliciesItems : TeaModel {
                        /// <summary>
                        /// <para>The list of sub-items.</para>
                        /// </summary>
                        [NameInMap("Children")]
                        [Validation(Required=false)]
                        public List<object> Children { get; set; }

                        /// <summary>
                        /// <para>The item name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Check-in Time</para>
                        /// </summary>
                        [NameInMap("ItemName")]
                        [Validation(Required=false)]
                        public string ItemName { get; set; }

                        /// <summary>
                        /// <para>The item type ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CHECK_IN_TIME</para>
                        /// </summary>
                        [NameInMap("ItemTypeId")]
                        [Validation(Required=false)]
                        public string ItemTypeId { get; set; }

                        /// <summary>
                        /// <para>The text value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>14:00</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The source of the coordinates.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GOOGLE</para>
                /// </summary>
                [NameInMap("PositionType")]
                [Validation(Required=false)]
                public string PositionType { get; set; }

                /// <summary>
                /// <para>The renovation year.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021</para>
                /// </summary>
                [NameInMap("RenovationTime")]
                [Validation(Required=false)]
                public int? RenovationTime { get; set; }

                /// <summary>
                /// <para>The list of room types.</para>
                /// </summary>
                [NameInMap("RoomTypes")]
                [Validation(Required=false)]
                public List<GlobalHotelBatchGetHotelDetailResponseBodyDataHotelsRoomTypes> RoomTypes { get; set; }
                public class GlobalHotelBatchGetHotelDetailResponseBodyDataHotelsRoomTypes : TeaModel {
                    /// <summary>
                    /// <para>The list of bed types.</para>
                    /// </summary>
                    [NameInMap("BedType")]
                    [Validation(Required=false)]
                    public List<GlobalHotelBatchGetHotelDetailResponseBodyDataHotelsRoomTypesBedType> BedType { get; set; }
                    public class GlobalHotelBatchGetHotelDetailResponseBodyDataHotelsRoomTypesBedType : TeaModel {
                        /// <summary>
                        /// <para>The number of beds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("BedCount")]
                        [Validation(Required=false)]
                        public int? BedCount { get; set; }

                        /// <summary>
                        /// <para>The bed width in meters.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1.8</para>
                        /// </summary>
                        [NameInMap("BedSize")]
                        [Validation(Required=false)]
                        public string BedSize { get; set; }

                        /// <summary>
                        /// <para>The bed type name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>King Bed</para>
                        /// </summary>
                        [NameInMap("BedType")]
                        [Validation(Required=false)]
                        public string BedType { get; set; }

                    }

                    /// <summary>
                    /// <para>The list of room type pictures.</para>
                    /// </summary>
                    [NameInMap("Pictures")]
                    [Validation(Required=false)]
                    public List<GlobalHotelBatchGetHotelDetailResponseBodyDataHotelsRoomTypesPictures> Pictures { get; set; }
                    public class GlobalHotelBatchGetHotelDetailResponseBodyDataHotelsRoomTypesPictures : TeaModel {
                        /// <summary>
                        /// <para>The picture description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Hotel lobby</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The first-level category code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HOTEL</para>
                        /// </summary>
                        [NameInMap("FirstCategoryCode")]
                        [Validation(Required=false)]
                        public string FirstCategoryCode { get; set; }

                        /// <summary>
                        /// <para>The first-level category name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Hotel</para>
                        /// </summary>
                        [NameInMap("FirstCategoryName")]
                        [Validation(Required=false)]
                        public string FirstCategoryName { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the picture is the cover image.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("IsHeadPic")]
                        [Validation(Required=false)]
                        public bool? IsHeadPic { get; set; }

                        /// <summary>
                        /// <para>The picture ID (subject to the URL).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PIC001</para>
                        /// </summary>
                        [NameInMap("PictureId")]
                        [Validation(Required=false)]
                        public string PictureId { get; set; }

                        /// <summary>
                        /// <para>The second-level category code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>LOBBY</para>
                        /// </summary>
                        [NameInMap("SecondCategoryCode")]
                        [Validation(Required=false)]
                        public string SecondCategoryCode { get; set; }

                        /// <summary>
                        /// <para>The second-level category name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Lobby</para>
                        /// </summary>
                        [NameInMap("SecondCategoryName")]
                        [Validation(Required=false)]
                        public string SecondCategoryName { get; set; }

                        /// <summary>
                        /// <para>The picture URL.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="https://img.example.com/1.jpg">https://img.example.com/1.jpg</a></para>
                        /// </summary>
                        [NameInMap("Url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                    }

                    /// <summary>
                    /// <para>The room type name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Deluxe King Room</para>
                    /// </summary>
                    [NameInMap("RoomName")]
                    [Validation(Required=false)]
                    public string RoomName { get; set; }

                    /// <summary>
                    /// <para>The Chinese room type name (always in Chinese, regardless of the language parameter).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>豪华大床房</para>
                    /// </summary>
                    [NameInMap("RoomNameCn")]
                    [Validation(Required=false)]
                    public string RoomNameCn { get; set; }

                    /// <summary>
                    /// <para>The room area (passed through as-is, may be a range value).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>35.0</para>
                    /// </summary>
                    [NameInMap("RoomSize")]
                    [Validation(Required=false)]
                    public string RoomSize { get; set; }

                    /// <summary>
                    /// <para>The area unit. Valid values: SQM (square meters) and SQFT (square feet). Default value: SQM.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SQM</para>
                    /// </summary>
                    [NameInMap("RoomSizeUnit")]
                    [Validation(Required=false)]
                    public string RoomSizeUnit { get; set; }

                    /// <summary>
                    /// <para>The platform standard room type ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>R001</para>
                    /// </summary>
                    [NameInMap("StandardRoomId")]
                    [Validation(Required=false)]
                    public string StandardRoomId { get; set; }

                    /// <summary>
                    /// <para>The window type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: no window</description></item>
                    /// <item><description>1: with window</description></item>
                    /// <item><description>2: partially with window</description></item>
                    /// <item><description>3: opaque window</description></item>
                    /// <item><description>4: partially opaque window</description></item>
                    /// <item><description>5: floor-to-ceiling window</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>WINDOW</para>
                    /// </summary>
                    [NameInMap("WindowType")]
                    [Validation(Required=false)]
                    public string WindowType { get; set; }

                    /// <summary>
                    /// <para>The window defect code. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: window cannot be opened for ventilation</description></item>
                    /// <item><description>1: view is obstructed outside the window</description></item>
                    /// <item><description>2: window faces the interior of the hotel</description></item>
                    /// <item><description>3: window is located in a corridor or hallway</description></item>
                    /// <item><description>4: window can be opened for ventilation and faces an outdoor open environment</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SMALL_WINDOW</para>
                    /// </summary>
                    [NameInMap("WindowTypeDefect")]
                    [Validation(Required=false)]
                    public string WindowTypeDefect { get; set; }

                }

                /// <summary>
                /// <para>The platform standard hotel ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>H001</para>
                /// </summary>
                [NameInMap("StandardHotelId")]
                [Validation(Required=false)]
                public string StandardHotelId { get; set; }

                /// <summary>
                /// <para>The star rating.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Star")]
                [Validation(Required=false)]
                public string Star { get; set; }

                /// <summary>
                /// <para>The hotel status (ONLINE/OFFLINE).</para>
                /// 
                /// <b>Example:</b>
                /// <para>ONLINE</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>+86-10-65137766</para>
                /// </summary>
                [NameInMap("Tel")]
                [Validation(Required=false)]
                public string Tel { get; set; }

                /// <summary>
                /// <para>The hotel time zone (IANA ID).</para>
                /// 
                /// <b>Example:</b>
                /// <para>Asia/Shanghai</para>
                /// </summary>
                [NameInMap("Timezone")]
                [Validation(Required=false)]
                public string Timezone { get; set; }

            }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CityCodeRequired</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>City code cannot be empty</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>260E4F99-983D-1919-834C-5C42E98E5B2B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>traceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>traceId</para>
        /// </summary>
        [NameInMap("TracerId")]
        [Validation(Required=false)]
        public string TracerId { get; set; }

    }

}
