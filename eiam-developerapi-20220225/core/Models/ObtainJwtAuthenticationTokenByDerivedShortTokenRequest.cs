// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class ObtainJwtAuthenticationTokenByDerivedShortTokenRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sk-Nx2vzxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("derivedShortToken")]
        [Validation(Required=false)]
        public string DerivedShortToken { get; set; }

    }

}
