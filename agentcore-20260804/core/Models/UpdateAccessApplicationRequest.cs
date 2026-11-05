// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateAccessApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The request body for updating the access application.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateAccessApplicationRequestBody Body { get; set; }
        public class UpdateAccessApplicationRequestBody : TeaModel {
            /// <summary>
            /// <para>The name of the access application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-access-application</para>
            /// </summary>
            [NameInMap("applicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// <para>The list of redirect URIs.</para>
            /// </summary>
            [NameInMap("redirectUris")]
            [Validation(Required=false)]
            public List<string> RedirectUris { get; set; }

        }

    }

}
