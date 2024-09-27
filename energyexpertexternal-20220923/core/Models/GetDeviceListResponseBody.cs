// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetDeviceListResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetDeviceListResponseBodyData Data { get; set; }
        public class GetDeviceListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The code returned for the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The devices.</para>
            /// </summary>
            [NameInMap("deviceList")]
            [Validation(Required=false)]
            public List<GetDeviceListResponseBodyDataDeviceList> DeviceList { get; set; }
            public class GetDeviceListResponseBodyDataDeviceList : TeaModel {
                /// <summary>
                /// <para>The device ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pn_69873</para>
                /// </summary>
                [NameInMap("deviceId")]
                [Validation(Required=false)]
                public string DeviceId { get; set; }

                /// <summary>
                /// <para>The device name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Main transformer 4#</para>
                /// </summary>
                [NameInMap("deviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                /// <summary>
                /// <para>The level 1 meter type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Electric meter</para>
                /// </summary>
                [NameInMap("firstTypeName")]
                [Validation(Required=false)]
                public string FirstTypeName { get; set; }

                /// <summary>
                /// <para>The device information.</para>
                /// </summary>
                [NameInMap("info")]
                [Validation(Required=false)]
                public GetDeviceListResponseBodyDataDeviceListInfo Info { get; set; }
                public class GetDeviceListResponseBodyDataDeviceListInfo : TeaModel {
                    /// <summary>
                    /// <para>The rated capacity.
                    /// Unit is kVA.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("constKva")]
                    [Validation(Required=false)]
                    public int? ConstKva { get; set; }

                    /// <summary>
                    /// <para>The transformation ratio of current.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ct")]
                    [Validation(Required=false)]
                    public int? Ct { get; set; }

                    /// <summary>
                    /// <para>The magnification ratio.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80</para>
                    /// </summary>
                    [NameInMap("magnification")]
                    [Validation(Required=false)]
                    public int? Magnification { get; set; }

                    /// <summary>
                    /// <para>The high and low voltage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("pressure")]
                    [Validation(Required=false)]
                    public int? Pressure { get; set; }

                    /// <summary>
                    /// <para>The transformation ratio of voltage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80</para>
                    /// </summary>
                    [NameInMap("pt")]
                    [Validation(Required=false)]
                    public int? Pt { get; set; }

                }

                /// <summary>
                /// <para>The ID of the parent device.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pn_6987</para>
                /// </summary>
                [NameInMap("parentDevice")]
                [Validation(Required=false)]
                public string ParentDevice { get; set; }

                /// <summary>
                /// <para>The level 2 meter type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Gateway meter</para>
                /// </summary>
                [NameInMap("secondTypeName")]
                [Validation(Required=false)]
                public string SecondTypeName { get; set; }

            }

            /// <summary>
            /// <para>The ID of the site.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pn_95</para>
            /// </summary>
            [NameInMap("factoryId")]
            [Validation(Required=false)]
            public string FactoryId { get; set; }

            /// <summary>
            /// <para>The HTTP status code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("httpCode")]
            [Validation(Required=false)]
            public int? HttpCode { get; set; }

            /// <summary>
            /// <para>Indicates whether the request was successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>83A5A7DD-8974-5769-952E-590A97BEA34E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
