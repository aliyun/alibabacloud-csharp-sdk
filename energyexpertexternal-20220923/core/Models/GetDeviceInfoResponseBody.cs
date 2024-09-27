// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetDeviceInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The code returned for the request. A value of Success indicates that the request was successful. Other values indicate that the request failed. You can troubleshoot the error by viewing the error message returned.</para>
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
        public GetDeviceInfoResponseBodyData Data { get; set; }
        public class GetDeviceInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pn_69873</para>
            /// </summary>
            [NameInMap("deviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// <para>The name of the device.</para>
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
            /// <para>The device parameters.</para>
            /// </summary>
            [NameInMap("recordList")]
            [Validation(Required=false)]
            public List<GetDeviceInfoResponseBodyDataRecordList> RecordList { get; set; }
            public class GetDeviceInfoResponseBodyDataRecordList : TeaModel {
                /// <summary>
                /// <para>The device identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Ia</para>
                /// </summary>
                [NameInMap("identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                /// <summary>
                /// <para>The parameter name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Phase A current</para>
                /// </summary>
                [NameInMap("paramName")]
                [Validation(Required=false)]
                public string ParamName { get; set; }

                /// <summary>
                /// <para>The date on which the statistics were collected.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-07-26 00:00:00</para>
                /// </summary>
                [NameInMap("statisticsDate")]
                [Validation(Required=false)]
                public string StatisticsDate { get; set; }

                /// <summary>
                /// <para>The type of the measuring point.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DOUBLE</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The unit of the parameter value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>A</para>
                /// </summary>
                [NameInMap("unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

                /// <summary>
                /// <para>The value of the measuring point.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20.00</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public double? Value { get; set; }

            }

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
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
