// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetDomainRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return online resource information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("withStatistics")]
        [Validation(Required=false)]
        public bool? WithStatistics { get; set; }

    }

}
