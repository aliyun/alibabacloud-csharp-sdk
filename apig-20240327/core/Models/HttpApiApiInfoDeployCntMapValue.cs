// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpApiApiInfoDeployCntMapValue : TeaModel {
        /// <summary>
        /// <para>deployedCnt</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("deployedCnt")]
        [Validation(Required=false)]
        public long? DeployedCnt { get; set; }

        /// <summary>
        /// <para>Cnt</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Cnt")]
        [Validation(Required=false)]
        public long? Cnt { get; set; }

    }

}
