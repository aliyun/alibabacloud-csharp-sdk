// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateDomainProxyTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the proxy token of the domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pt_mtohn73423stghoivjmi4jwxxx</para>
        /// </summary>
        [NameInMap("DomainProxyTokenId")]
        [Validation(Required=false)]
        public string DomainProxyTokenId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
