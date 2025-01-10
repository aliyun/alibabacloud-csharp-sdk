// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class QueryRoomControlDevicesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>fdsgfdscvre</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryRoomControlDevicesResponseBodyResult> Result { get; set; }
        public class QueryRoomControlDevicesResponseBodyResult : TeaModel {
            [NameInMap("Devices")]
            [Validation(Required=false)]
            public List<QueryRoomControlDevicesResponseBodyResultDevices> Devices { get; set; }
            public class QueryRoomControlDevicesResponseBodyResultDevices : TeaModel {
                [NameInMap("AliasList")]
                [Validation(Required=false)]
                public List<string> AliasList { get; set; }

                [NameInMap("ConnectType")]
                [Validation(Required=false)]
                public string ConnectType { get; set; }

                [NameInMap("DN")]
                [Validation(Required=false)]
                public string DN { get; set; }

                [NameInMap("DeviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                [NameInMap("DeviceStatus")]
                [Validation(Required=false)]
                public string DeviceStatus { get; set; }

                [NameInMap("MultiKeySwitchExt")]
                [Validation(Required=false)]
                public QueryRoomControlDevicesResponseBodyResultDevicesMultiKeySwitchExt MultiKeySwitchExt { get; set; }
                public class QueryRoomControlDevicesResponseBodyResultDevicesMultiKeySwitchExt : TeaModel {
                    [NameInMap("SwitchList")]
                    [Validation(Required=false)]
                    public List<QueryRoomControlDevicesResponseBodyResultDevicesMultiKeySwitchExtSwitchList> SwitchList { get; set; }
                    public class QueryRoomControlDevicesResponseBodyResultDevicesMultiKeySwitchExtSwitchList : TeaModel {
                        [NameInMap("AliasList")]
                        [Validation(Required=false)]
                        public List<string> AliasList { get; set; }

                        [NameInMap("Category")]
                        [Validation(Required=false)]
                        public string Category { get; set; }

                        [NameInMap("DeviceIndex")]
                        [Validation(Required=false)]
                        public int? DeviceIndex { get; set; }

                        [NameInMap("DeviceName")]
                        [Validation(Required=false)]
                        public string DeviceName { get; set; }

                        [NameInMap("DeviceStatus")]
                        [Validation(Required=false)]
                        public string DeviceStatus { get; set; }

                        [NameInMap("ElementCode")]
                        [Validation(Required=false)]
                        public string ElementCode { get; set; }

                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public string Location { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>light</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>night_light</para>
                /// </summary>
                [NameInMap("Number")]
                [Validation(Required=false)]
                public string Number { get; set; }

                [NameInMap("PK")]
                [Validation(Required=false)]
                public string PK { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>room</para>
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            [NameInMap("LocationName")]
            [Validation(Required=false)]
            public string LocationName { get; set; }

        }

    }

}
