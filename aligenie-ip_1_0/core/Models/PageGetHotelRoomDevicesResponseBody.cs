// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class PageGetHotelRoomDevicesResponseBody : TeaModel {
        [NameInMap("Extentions")]
        [Validation(Required=false)]
        public Dictionary<string, object> Extentions { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public PageGetHotelRoomDevicesResponseBodyPage Page { get; set; }
        public class PageGetHotelRoomDevicesResponseBodyPage : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public int? End { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("HasNext")]
            [Validation(Required=false)]
            public bool? HasNext { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Start")]
            [Validation(Required=false)]
            public int? Start { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public int? TotalPage { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4EFBDDF4-B19D-526C-8C3D-CD8AB51974EE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<PageGetHotelRoomDevicesResponseBodyResult> Result { get; set; }
        public class PageGetHotelRoomDevicesResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>V21.10.00.313</para>
            /// </summary>
            [NameInMap("FirmwareVersion")]
            [Validation(Required=false)]
            public string FirmwareVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>a7***83</para>
            /// </summary>
            [NameInMap("HotelId")]
            [Validation(Required=false)]
            public string HotelId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>b4:xx:xx:xx:65:2b</para>
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
            /// <para>2001</para>
            /// </summary>
            [NameInMap("RoomNo")]
            [Validation(Required=false)]
            public string RoomNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1200xxx048</para>
            /// </summary>
            [NameInMap("Sn")]
            [Validation(Required=false)]
            public string Sn { get; set; }

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
