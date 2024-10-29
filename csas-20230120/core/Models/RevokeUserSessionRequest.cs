// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class RevokeUserSessionRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678</para>
        /// </summary>
        [NameInMap("ExternalIds")]
        [Validation(Required=false)]
        public string ExternalIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idp-cfg9vcrqylo39c39uxnw</para>
        /// </summary>
        [NameInMap("IdpId")]
        [Validation(Required=false)]
        public string IdpId { get; set; }

    }

}
