// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class HTTPTriggerConfig : TeaModel {
        /// <summary>
        /// <para>The authentication configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;JWKS&quot;:{&quot;foo&quot;:&quot;bar&quot;},&quot;TokenLookup&quot;:&quot;header:Authorization:Bearer,cookie:AuthorizationCookie&quot;,&quot;ClaimPassBy&quot;:&quot;query:uid:uid,header:name:name&quot;}</para>
        /// </summary>
        [NameInMap("authConfig")]
        [Validation(Required=false)]
        public string AuthConfig { get; set; }

        /// <summary>
        /// <para>The authentication type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>function</b>: requires authentication.</description></item>
        /// <item><description><b>anonymous</b>: does not require authentication.</description></item>
        /// </list>
        /// <remarks>
        /// <para> The default value is <b>function</b></para>
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
        /// <para>Specifies whether to disable access to the default Internet domain. If you set this parameter to true, a 403 error is returned if you access the default public URL provided by the function. A value of false does not have affect the running of the function.</para>
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
