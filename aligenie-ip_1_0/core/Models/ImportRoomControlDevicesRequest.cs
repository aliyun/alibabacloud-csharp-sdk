// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class ImportRoomControlDevicesRequest : TeaModel {
        [NameInMap("EnableInfraredDeviceImport")]
        [Validation(Required=false)]
        public string EnableInfraredDeviceImport { get; set; }

        [NameInMap("EnableMeshDeviceImport")]
        [Validation(Required=false)]
        public string EnableMeshDeviceImport { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vdgrefds</para>
        /// </summary>
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("LocationDevices")]
        [Validation(Required=false)]
        public List<ImportRoomControlDevicesRequestLocationDevices> LocationDevices { get; set; }
        public class ImportRoomControlDevicesRequestLocationDevices : TeaModel {
            [NameInMap("Devices")]
            [Validation(Required=false)]
            public List<ImportRoomControlDevicesRequestLocationDevicesDevices> Devices { get; set; }
            public class ImportRoomControlDevicesRequestLocationDevicesDevices : TeaModel {
                [NameInMap("AliasList")]
                [Validation(Required=false)]
                public List<string> AliasList { get; set; }

                [NameInMap("Brand")]
                [Validation(Required=false)]
                public string Brand { get; set; }

                [NameInMap("City")]
                [Validation(Required=false)]
                public string City { get; set; }

                [NameInMap("ConnectType")]
                [Validation(Required=false)]
                public string ConnectType { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("DeviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                [NameInMap("Dn")]
                [Validation(Required=false)]
                public string Dn { get; set; }

                [NameInMap("InfraredId")]
                [Validation(Required=false)]
                public string InfraredId { get; set; }

                [NameInMap("InfraredIndex")]
                [Validation(Required=false)]
                public string InfraredIndex { get; set; }

                [NameInMap("InfraredVersion")]
                [Validation(Required=false)]
                public string InfraredVersion { get; set; }

                [NameInMap("MultiKeySwitchExt")]
                [Validation(Required=false)]
                public ImportRoomControlDevicesRequestLocationDevicesDevicesMultiKeySwitchExt MultiKeySwitchExt { get; set; }
                public class ImportRoomControlDevicesRequestLocationDevicesDevicesMultiKeySwitchExt : TeaModel {
                    [NameInMap("SwitchList")]
                    [Validation(Required=false)]
                    public List<ImportRoomControlDevicesRequestLocationDevicesDevicesMultiKeySwitchExtSwitchList> SwitchList { get; set; }
                    public class ImportRoomControlDevicesRequestLocationDevicesDevicesMultiKeySwitchExtSwitchList : TeaModel {
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

                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public string Location { get; set; }

                    }

                }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
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

                [NameInMap("Pk")]
                [Validation(Required=false)]
                public string Pk { get; set; }

                [NameInMap("Province")]
                [Validation(Required=false)]
                public string Province { get; set; }

                [NameInMap("ServiceProvider")]
                [Validation(Required=false)]
                public string ServiceProvider { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
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

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1211</para>
        /// </summary>
        [NameInMap("RoomNo")]
        [Validation(Required=false)]
        public string RoomNo { get; set; }

    }

}
