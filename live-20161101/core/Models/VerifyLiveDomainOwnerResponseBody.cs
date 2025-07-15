// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class VerifyLiveDomainOwnerResponseBody : TeaModel {
        /// <summary>
        /// <para>The verification information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>verify_dffeb6610035dcb77b413******</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1BA6D7CE-55F1-5926-8764-F8663473AD0D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
