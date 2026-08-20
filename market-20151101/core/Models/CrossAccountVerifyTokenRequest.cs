// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class CrossAccountVerifyTokenRequest : TeaModel {
        /// <summary>
        /// <para>Token returned upon successful cross-account role authorization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C19D103FEA2D50A584410267CE9FBA56</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
