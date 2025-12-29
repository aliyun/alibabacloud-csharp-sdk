// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class ImportRoomControlDevicesShrinkRequest : TeaModel {
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
        public string LocationDevicesShrink { get; set; }

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
