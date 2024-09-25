// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class VehicleQueryRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("ParamType")]
        [Validation(Required=false)]
        public string ParamType { get; set; }

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

    }

}
