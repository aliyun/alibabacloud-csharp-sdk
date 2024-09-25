// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class VehicleMetaVerifyRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>4****************1</para>
        /// </summary>
        [NameInMap("IdentifyNum")]
        [Validation(Required=false)]
        public string IdentifyNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("ParamType")]
        [Validation(Required=false)]
        public string ParamType { get; set; }

        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        [NameInMap("VehicleNum")]
        [Validation(Required=false)]
        public string VehicleNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>02</para>
        /// </summary>
        [NameInMap("VehicleType")]
        [Validation(Required=false)]
        public string VehicleType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>VEHICLE_2_META</para>
        /// </summary>
        [NameInMap("VerifyMetaType")]
        [Validation(Required=false)]
        public string VerifyMetaType { get; set; }

    }

}
