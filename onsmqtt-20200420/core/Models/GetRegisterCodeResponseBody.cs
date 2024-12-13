// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class GetRegisterCodeResponseBody : TeaModel {
        /// <summary>
        /// <para>The registration code of the CA certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13274673-8f90-4630-bea1-9cccb25756ad2089******</para>
        /// </summary>
        [NameInMap("RegisterCode")]
        [Validation(Required=false)]
        public string RegisterCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>020F6A43-19E6-4B6E-B846-44EB31DF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
