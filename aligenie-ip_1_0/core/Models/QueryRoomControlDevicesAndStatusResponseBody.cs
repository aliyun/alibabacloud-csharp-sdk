// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class QueryRoomControlDevicesAndStatusResponseBody : TeaModel {
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
        /// <para>73C67***6FA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryRoomControlDevicesAndStatusResponseBodyResult> Result { get; set; }
        public class QueryRoomControlDevicesAndStatusResponseBodyResult : TeaModel {
            [NameInMap("Devices")]
            [Validation(Required=false)]
            public List<QueryRoomControlDevicesAndStatusResponseBodyResultDevices> Devices { get; set; }
            public class QueryRoomControlDevicesAndStatusResponseBodyResultDevices : TeaModel {
                [NameInMap("AliasList")]
                [Validation(Required=false)]
                public List<string> AliasList { get; set; }

                [NameInMap("Brand")]
                [Validation(Required=false)]
                public string Brand { get; set; }

                [NameInMap("City")]
                [Validation(Required=false)]
                public string City { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>rcu</para>
                /// </summary>
                [NameInMap("ConnectType")]
                [Validation(Required=false)]
                public string ConnectType { get; set; }

                [NameInMap("DeviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;powerstate&quot;: &quot;1&quot;}</para>
                /// </summary>
                [NameInMap("DeviceStatus")]
                [Validation(Required=false)]
                public string DeviceStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3c5d***9ec</para>
                /// </summary>
                [NameInMap("Dn")]
                [Validation(Required=false)]
                public string Dn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>9**7</para>
                /// </summary>
                [NameInMap("InfraredId")]
                [Validation(Required=false)]
                public string InfraredId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("InfraredIndex")]
                [Validation(Required=false)]
                public string InfraredIndex { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3.0</para>
                /// </summary>
                [NameInMap("InfraredVersion")]
                [Validation(Required=false)]
                public string InfraredVersion { get; set; }

                [NameInMap("MultiKeySwitchExt")]
                [Validation(Required=false)]
                public QueryRoomControlDevicesAndStatusResponseBodyResultDevicesMultiKeySwitchExt MultiKeySwitchExt { get; set; }
                public class QueryRoomControlDevicesAndStatusResponseBodyResultDevicesMultiKeySwitchExt : TeaModel {
                    [NameInMap("SwitchList")]
                    [Validation(Required=false)]
                    public List<QueryRoomControlDevicesAndStatusResponseBodyResultDevicesMultiKeySwitchExtSwitchList> SwitchList { get; set; }
                    public class QueryRoomControlDevicesAndStatusResponseBodyResultDevicesMultiKeySwitchExtSwitchList : TeaModel {
                        [NameInMap("AliasList")]
                        [Validation(Required=false)]
                        public List<string> AliasList { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>light</para>
                        /// </summary>
                        [NameInMap("Category")]
                        [Validation(Required=false)]
                        public string Category { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("DeviceIndex")]
                        [Validation(Required=false)]
                        public int? DeviceIndex { get; set; }

                        [NameInMap("DeviceName")]
                        [Validation(Required=false)]
                        public string DeviceName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>{
                        ///       &quot;powerstate&quot;: &quot;0&quot;
                        /// }</para>
                        /// </summary>
                        [NameInMap("DeviceStatus")]
                        [Validation(Required=false)]
                        public string DeviceStatus { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>e2</para>
                        /// </summary>
                        [NameInMap("ElementCode")]
                        [Validation(Required=false)]
                        public string ElementCode { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>room</para>
                        /// </summary>
                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public string Location { get; set; }

                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public Dictionary<string, string> Status { get; set; }

                        [NameInMap("Tags")]
                        [Validation(Required=false)]
                        public List<string> Tags { get; set; }

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

                /// <summary>
                /// <b>Example:</b>
                /// <para>50255129</para>
                /// </summary>
                [NameInMap("Pk")]
                [Validation(Required=false)]
                public string Pk { get; set; }

                [NameInMap("Province")]
                [Validation(Required=false)]
                public string Province { get; set; }

                [NameInMap("ServiceProvider")]
                [Validation(Required=false)]
                public string ServiceProvider { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public Dictionary<string, string> Status { get; set; }

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

            /// <summary>
            /// <b>Example:</b>
            /// <para>1211</para>
            /// </summary>
            [NameInMap("RoomNo")]
            [Validation(Required=false)]
            public string RoomNo { get; set; }

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
