// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ModelApiApiInfoDeployCntMapValue : TeaModel {
        /// <summary>
        /// <para>The number of deployed APIs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("deployedCnt")]
        [Validation(Required=false)]
        public long? DeployedCnt { get; set; }

        /// <summary>
        /// <para>The total number of APIs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("cnt")]
        [Validation(Required=false)]
        public long? Cnt { get; set; }

    }

}
