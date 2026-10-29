// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class UpdateApiKeyRequest : TeaModel {
        /// <summary>
        /// <para>The API key permission settings.</para>
        /// <remarks>
        /// <para>When calling the UpdateApiKey operation, either leave this section empty or fill it out completely. Otherwise, the configuration may not match your expectations.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("auth")]
        [Validation(Required=false)]
        public UpdateApiKeyRequestAuth Auth { get; set; }
        public class UpdateApiKeyRequestAuth : TeaModel {
            /// <summary>
            /// <para>The IP address whitelist.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>When customizing the permission scope, if the IP address whitelist is not specified, the server sets the default values to IPv4 (0.0.0.0/0) and IPv6 (::/0), which allows all traffic.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("accessIps")]
            [Validation(Required=false)]
            public List<string> AccessIps { get; set; }

            /// <summary>
            /// <para>The model access scope.</para>
            /// </summary>
            [NameInMap("modelAccessScope")]
            [Validation(Required=false)]
            public UpdateApiKeyRequestAuthModelAccessScope ModelAccessScope { get; set; }
            public class UpdateApiKeyRequestAuthModelAccessScope : TeaModel {
                /// <summary>
                /// <para>The list of accessible models.</para>
                /// <remarks>
                /// <para>Notice: The specified content takes effect only when allowAllModels is set to false.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("accessibleModels")]
                [Validation(Required=false)]
                public List<string> AccessibleModels { get; set; }

                /// <summary>
                /// <para>Specifies whether to allow access to all models that have been granted inference permissions in the workspace. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// </summary>
                [NameInMap("allowAllModels")]
                [Validation(Required=false)]
                public bool? AllowAllModels { get; set; }

            }

            /// <summary>
            /// <para>The permission type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>All: all permissions.</description></item>
            /// <item><description>Custom: custom permissions.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Custom</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>update description.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}
