// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateServiceMirrorRequest : TeaModel {
        /// <summary>
        /// <para>The percentage of traffic that you want to mirror. Valid values: 0 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Ratio")]
        [Validation(Required=false)]
        public int? Ratio { get; set; }

        /// <summary>
        /// <para>The service instances.</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public List<string> Target { get; set; }

    }

}
