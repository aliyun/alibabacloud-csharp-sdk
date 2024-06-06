// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetDeviceListResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetDeviceListResponseBodyData Data { get; set; }
        public class GetDeviceListResponseBodyData : TeaModel {
            /// <summary>
            /// The code returned for the request.
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// The devices.
            /// </summary>
            [NameInMap("deviceList")]
            [Validation(Required=false)]
            public List<GetDeviceListResponseBodyDataDeviceList> DeviceList { get; set; }
            public class GetDeviceListResponseBodyDataDeviceList : TeaModel {
                /// <summary>
                /// The device ID.
                /// </summary>
                [NameInMap("deviceId")]
                [Validation(Required=false)]
                public string DeviceId { get; set; }

                /// <summary>
                /// The device name.
                /// </summary>
                [NameInMap("deviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                /// <summary>
                /// The level 1 meter type.
                /// </summary>
                [NameInMap("firstTypeName")]
                [Validation(Required=false)]
                public string FirstTypeName { get; set; }

                /// <summary>
                /// The device information.
                /// </summary>
                [NameInMap("info")]
                [Validation(Required=false)]
                public GetDeviceListResponseBodyDataDeviceListInfo Info { get; set; }
                public class GetDeviceListResponseBodyDataDeviceListInfo : TeaModel {
                    /// <summary>
                    /// The rated capacity.
                    /// Unit is kVA.
                    /// </summary>
                    [NameInMap("constKva")]
                    [Validation(Required=false)]
                    public int? ConstKva { get; set; }

                    /// <summary>
                    /// The transformation ratio of current.
                    /// </summary>
                    [NameInMap("ct")]
                    [Validation(Required=false)]
                    public int? Ct { get; set; }

                    /// <summary>
                    /// The magnification ratio.
                    /// </summary>
                    [NameInMap("magnification")]
                    [Validation(Required=false)]
                    public int? Magnification { get; set; }

                    /// <summary>
                    /// The high and low voltage.
                    /// </summary>
                    [NameInMap("pressure")]
                    [Validation(Required=false)]
                    public int? Pressure { get; set; }

                    /// <summary>
                    /// The transformation ratio of voltage.
                    /// </summary>
                    [NameInMap("pt")]
                    [Validation(Required=false)]
                    public int? Pt { get; set; }

                }

                /// <summary>
                /// The ID of the parent device.
                /// </summary>
                [NameInMap("parentDevice")]
                [Validation(Required=false)]
                public string ParentDevice { get; set; }

                /// <summary>
                /// The level 2 meter type.
                /// </summary>
                [NameInMap("secondTypeName")]
                [Validation(Required=false)]
                public string SecondTypeName { get; set; }

            }

            /// <summary>
            /// The ID of the site.
            /// </summary>
            [NameInMap("factoryId")]
            [Validation(Required=false)]
            public string FactoryId { get; set; }

            /// <summary>
            /// The HTTP status code.
            /// </summary>
            [NameInMap("httpCode")]
            [Validation(Required=false)]
            public int? HttpCode { get; set; }

            /// <summary>
            /// Indicates whether the request was successful.
            /// </summary>
            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
