// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class SetAccessKeyPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The AccessKey ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LTAI*******************</para>
        /// </summary>
        [NameInMap("AccessKeyId")]
        [Validation(Required=false)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// <para>The network access restriction policy.</para>
        /// <para>A JSON-formatted string. For more information, see the AccessKeyPolicy structure description.</para>
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
        /// <para>30C9068D-FBAA-4998-9986-8A562FED0BC3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
