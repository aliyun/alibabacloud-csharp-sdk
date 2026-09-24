// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class InvokeEsRequestRequest : TeaModel {
        /// <summary>
        /// <para>The request body passed through to ES. Set this parameter based on the requirements of the target ES API. This parameter is not required for calls such as GET that do not have a request body.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;query&quot;:{&quot;match_all&quot;:{}}}</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        /// <summary>
        /// <para>The ID of the credential to use. If this parameter is not specified, the default credential of the instance is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cred-7k2mq9xr4vbn</para>
        /// </summary>
        [NameInMap("credentialId")]
        [Validation(Required=false)]
        public string CredentialId { get; set; }

        /// <summary>
        /// <para>The HTTP method used to access ES. Default value: GET.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GET</para>
        /// </summary>
        [NameInMap("method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        /// <summary>
        /// <para>The ES path to access. This parameter is required. The leading / can be omitted.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>_cat/indices?format=json</para>
        /// </summary>
        [NameInMap("path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the Alibaba Cloud ES system credential. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("system")]
        [Validation(Required=false)]
        public bool? System { get; set; }

    }

}
