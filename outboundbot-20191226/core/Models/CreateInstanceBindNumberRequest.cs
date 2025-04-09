// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateInstanceBindNumberRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1,2,4,5</para>
        /// </summary>
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public string InstanceList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10088</para>
        /// </summary>
        [NameInMap("Number")]
        [Validation(Required=false)]
        public string Number { get; set; }

    }

}
