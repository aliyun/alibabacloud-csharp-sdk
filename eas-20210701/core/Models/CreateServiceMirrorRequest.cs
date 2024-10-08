// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateServiceMirrorRequest : TeaModel {
        /// <summary>
        /// <para>The percentage of the traffic that is mirrored to the destination service. Valid values: 0 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Ratio")]
        [Validation(Required=false)]
        public int? Ratio { get; set; }

        /// <summary>
        /// <para>The instances.</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public List<string> Target { get; set; }

    }

}
