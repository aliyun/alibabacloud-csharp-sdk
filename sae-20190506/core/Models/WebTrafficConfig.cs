// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class WebTrafficConfig : TeaModel {
        /// <summary>
        /// <para>The authentication type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Anonymous</b>: does not require authentication.</description></item>
        /// <item><description><b>Application</b>: requires authentication.</description></item>
        /// </list>
        /// <remarks>
        /// <para> The default value is <b>Anonymous</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Anonymous</para>
        /// </summary>
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable access to the default Internet domain. If you set this parameter to true, a 403 error is returned if you access the default public URL provided by the function. A value of false does not have affect the running of the function.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DisableInternetURL")]
        [Validation(Required=false)]
        public bool? DisableInternetURL { get; set; }

        /// <summary>
        /// <para>Specifies the traffic weight of applications in different versions. The sum of traffic weight for all versions must be 100%.</para>
        /// </summary>
        [NameInMap("RevisionsTrafficWeight")]
        [Validation(Required=false)]
        public Dictionary<string, float?> RevisionsTrafficWeight { get; set; }

        /// <summary>
        /// <para>The configurations of IP ACL whitelist.</para>
        /// </summary>
        [NameInMap("WebAclConfig")]
        [Validation(Required=false)]
        public WebAclConfig WebAclConfig { get; set; }

    }

}
