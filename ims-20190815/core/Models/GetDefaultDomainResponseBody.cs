// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetDefaultDomainResponseBody : TeaModel {
        /// <summary>
        /// <para>The default domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>examplecompany.onaliyun.com</para>
        /// </summary>
        [NameInMap("DefaultDomainName")]
        [Validation(Required=false)]
        public string DefaultDomainName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66815255-7CCE-4759-AC37-9755794C3626</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
