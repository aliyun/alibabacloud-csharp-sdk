// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetAccessKeyPolicyForAccountResponseBody : TeaModel {
        /// <summary>
        /// <para>The network access restriction policy. The value is a JSON-formatted string. For more information about the AccessKeyPolicy structure, see the SetAccessKeyPolicy documentation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Status&quot;:&quot;Inactive&quot;,&quot;Statements&quot;:[{&quot;Value&quot;:&quot;AllowAllVPC&quot;,&quot;Type&quot;:&quot;VPCWhiteList&quot;,&quot;IPList&quot;:[&quot;::/0&quot;,&quot;0.0.0.0/0&quot;]}]}</para>
        /// </summary>
        [NameInMap("AccessKeyPolicy")]
        [Validation(Required=false)]
        public string AccessKeyPolicy { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>85836703-8D4F-485F-9726-4D1C730F957E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
