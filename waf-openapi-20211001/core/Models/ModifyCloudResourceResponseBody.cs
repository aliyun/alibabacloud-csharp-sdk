// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyCloudResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the resource that is added to WAF.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-xxx-80-clb7</para>
        /// </summary>
        [NameInMap("CloudResource")]
        [Validation(Required=false)]
        public string CloudResource { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D7861F61-5B61-46CE-A47C-***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
