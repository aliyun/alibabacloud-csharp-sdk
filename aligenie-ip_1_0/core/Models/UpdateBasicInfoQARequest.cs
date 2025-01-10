// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class UpdateBasicInfoQARequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11:11</para>
        /// </summary>
        [NameInMap("CheckInTime")]
        [Validation(Required=false)]
        public string CheckInTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11:11</para>
        /// </summary>
        [NameInMap("CheckOutTime")]
        [Validation(Required=false)]
        public string CheckOutTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("HotelAddress")]
        [Validation(Required=false)]
        public string HotelAddress { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>af7***536</para>
        /// </summary>
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        [NameInMap("HotelIntroduction")]
        [Validation(Required=false)]
        public string HotelIntroduction { get; set; }

        [NameInMap("HotelMember")]
        [Validation(Required=false)]
        public string HotelMember { get; set; }

        [NameInMap("HotelService")]
        [Validation(Required=false)]
        public string HotelService { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ParkingExpenses")]
        [Validation(Required=false)]
        public string ParkingExpenses { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ParkingPosition")]
        [Validation(Required=false)]
        public string ParkingPosition { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123***</para>
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("WifiName")]
        [Validation(Required=false)]
        public string WifiName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("WifiPassword")]
        [Validation(Required=false)]
        public string WifiPassword { get; set; }

    }

}
