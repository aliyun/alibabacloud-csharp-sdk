// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpApiApiInfoDeployCntMapValue : TeaModel {
        /// <summary>
        /// <para>The number of published API operations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("deployedCnt")]
        [Validation(Required=false)]
        public long? DeployedCnt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("cnt")]
        [Validation(Required=false)]
        public long? Cnt { get; set; }

    }

}
