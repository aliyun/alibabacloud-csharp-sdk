// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetDeviceInfoResponseBody : TeaModel {
        /// <summary>
        /// The code returned for the request. A value of Success indicates that the request was successful. Other values indicate that the request failed. You can troubleshoot the error by viewing the error message returned.
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetDeviceInfoResponseBodyData Data { get; set; }
        public class GetDeviceInfoResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the device.
            /// </summary>
            [NameInMap("deviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// The name of the device.
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
            /// The device parameters.
            /// </summary>
            [NameInMap("recordList")]
            [Validation(Required=false)]
            public List<GetDeviceInfoResponseBodyDataRecordList> RecordList { get; set; }
            public class GetDeviceInfoResponseBodyDataRecordList : TeaModel {
                /// <summary>
                /// The device identifier.
                /// </summary>
                [NameInMap("identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                /// <summary>
                /// The parameter name.
                /// </summary>
                [NameInMap("paramName")]
                [Validation(Required=false)]
                public string ParamName { get; set; }

                /// <summary>
                /// The date on which the statistics were collected.
                /// </summary>
                [NameInMap("statisticsDate")]
                [Validation(Required=false)]
                public string StatisticsDate { get; set; }

                /// <summary>
                /// The type of the measuring point.
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The unit of the parameter value.
                /// </summary>
                [NameInMap("unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

                /// <summary>
                /// The value of the measuring point.
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public double? Value { get; set; }

            }

            /// <summary>
            /// The level 2 meter type.
            /// </summary>
            [NameInMap("secondTypeName")]
            [Validation(Required=false)]
            public string SecondTypeName { get; set; }

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
