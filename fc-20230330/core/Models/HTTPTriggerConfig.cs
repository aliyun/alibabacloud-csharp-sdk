// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class HTTPTriggerConfig : TeaModel {
        /// <summary>
        /// <para>Authentication configuration</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;JWKS&quot;:{&quot;foo&quot;:&quot;bar&quot;},&quot;TokenLookup&quot;:&quot;header:Authorization:Bearer,cookie:AuthorizationCookie&quot;,&quot;ClaimPassBy&quot;:&quot;query:uid:uid,header:name:name&quot;}</para>
        /// </summary>
        [NameInMap("authConfig")]
        [Validation(Required=false)]
        public string AuthConfig { get; set; }

        /// <summary>
        /// <para>The authentication type. Valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para><b>function</b>: Authentication is required.</para>
        /// </description></item>
        /// <item><description><para><b>anonymous</b>: Authentication is not required.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The default type is <b>function</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>anonymous</para>
        /// </summary>
        [NameInMap("authType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        [NameInMap("corsConfig")]
        [Validation(Required=false)]
        public CORSConfig CorsConfig { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable access from the default public domain name. If set to true, accessing the function\&quot;s default public URL returns a 403 error. If set to false, this parameter has no effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("disableURLInternet")]
        [Validation(Required=false)]
        public bool? DisableURLInternet { get; set; }

        /// <summary>
        /// <para>The list of request methods. Multiple methods are supported.</para>
        /// </summary>
        [NameInMap("methods")]
        [Validation(Required=false)]
        public List<string> Methods { get; set; }

    }

}
