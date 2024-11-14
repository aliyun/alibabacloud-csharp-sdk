// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20240712.Models
{
    public class RoadTrafficStatusRequest : TeaModel {
        [NameInMap("city")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>HIGHWAY</para>
        /// </summary>
        [NameInMap("roadLevel")]
        [Validation(Required=false)]
        public string RoadLevel { get; set; }

        [NameInMap("roadName")]
        [Validation(Required=false)]
        public string RoadName { get; set; }

    }

}
