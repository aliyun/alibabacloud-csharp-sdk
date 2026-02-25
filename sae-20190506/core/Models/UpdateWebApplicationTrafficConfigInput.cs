// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UpdateWebApplicationTrafficConfigInput : TeaModel {
        /// <summary>
        /// <para>The authentication type. Valid values: Anonymous (default): does not require authentication. Application: requires authentication.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Anonymous</para>
        /// </summary>
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable access to the default Internet domain. If you set this parameter to true, a 403 error is returned if you access the default public URL provided by the application. A value of false does not have affect the running of the function.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DisableURLInternet")]
        [Validation(Required=false)]
        public bool? DisableURLInternet { get; set; }

        /// <summary>
        /// <para>The traffic distribution for the application versions. The sum of traffic percentages for all versions must be equal to 1.</para>
        /// </summary>
        [NameInMap("RevisionsTrafficWeight")]
        [Validation(Required=false)]
        public Dictionary<string, float?> RevisionsTrafficWeight { get; set; }

        /// <summary>
        /// <para>The configurations of the access control list (ACL) that consists of IP addresses.</para>
        /// </summary>
        [NameInMap("WebAclConfig")]
        [Validation(Required=false)]
        public WebAclConfig WebAclConfig { get; set; }

    }

}
