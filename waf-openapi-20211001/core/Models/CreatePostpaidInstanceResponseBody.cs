// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class CreatePostpaidInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_v2_public_cn-x0r****gr1i</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>73A4E786-8235-50C0-9631-87C8****4A36</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
