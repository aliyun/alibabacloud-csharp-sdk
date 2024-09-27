// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class EditProhibitedDevicesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("factoryId")]
        [Validation(Required=false)]
        public string FactoryId { get; set; }

        [NameInMap("hvacDeviceConfigVOList")]
        [Validation(Required=false)]
        public List<EditProhibitedDevicesRequestHvacDeviceConfigVOList> HvacDeviceConfigVOList { get; set; }
        public class EditProhibitedDevicesRequestHvacDeviceConfigVOList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>build_01</para>
            /// </summary>
            [NameInMap("buildingId")]
            [Validation(Required=false)]
            public string BuildingId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>id1</para>
            /// </summary>
            [NameInMap("deviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>name1</para>
            /// </summary>
            [NameInMap("deviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("deviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>fence_01</para>
            /// </summary>
            [NameInMap("fenceId")]
            [Validation(Required=false)]
            public string FenceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>floor_01</para>
            /// </summary>
            [NameInMap("floorId")]
            [Validation(Required=false)]
            public string FloorId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("isForbidden")]
            [Validation(Required=false)]
            public int? IsForbidden { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("isUnfavorableArea")]
            [Validation(Required=false)]
            public int? IsUnfavorableArea { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>system1</para>
        /// </summary>
        [NameInMap("systemId")]
        [Validation(Required=false)]
        public string SystemId { get; set; }

    }

}
