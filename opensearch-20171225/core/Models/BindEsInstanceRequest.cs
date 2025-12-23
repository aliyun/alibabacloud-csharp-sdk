// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class BindEsInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The body of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;esInstanceId&quot;: &quot;es-cn-abcde&quot;
        /// }</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public Dictionary<string, object> Body { get; set; }

    }

}
