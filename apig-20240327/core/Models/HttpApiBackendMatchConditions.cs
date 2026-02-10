// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpApiBackendMatchConditions : TeaModel {
        /// <summary>
        /// <para>The configurations of the matching conditions.</para>
        /// </summary>
        [NameInMap("conditions")]
        [Validation(Required=false)]
        public List<HttpApiBackendMatchCondition> Conditions { get; set; }

        /// <summary>
        /// <para>Specifies whether the matching condition is the default one.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("default")]
        [Validation(Required=false)]
        public bool? Default { get; set; }

    }

}
