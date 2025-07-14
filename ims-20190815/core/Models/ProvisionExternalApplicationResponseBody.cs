// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ProvisionExternalApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the external application.</para>
        /// </summary>
        [NameInMap("ExternalApplication")]
        [Validation(Required=false)]
        public ProvisionExternalApplicationResponseBodyExternalApplication ExternalApplication { get; set; }
        public class ProvisionExternalApplicationResponseBodyExternalApplication : TeaModel {
            /// <summary>
            /// <para>The name of the application principal. The value is in the <c>&lt;app_name&gt;@app.&lt;account_id&gt;.onaliyun.com</c> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:GiteePrd@app.177242285274">GiteePrd@app.177242285274</a>****.onaliyun.com</para>
            /// </summary>
            [NameInMap("AppPrincipalName")]
            [Validation(Required=false)]
            public string AppPrincipalName { get; set; }

            /// <summary>
            /// <para>The time when the application was installed. The value is a timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1603693518000</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The information about the scopes of permissions that are granted to the application.</para>
            /// </summary>
            [NameInMap("DelegatedScope")]
            [Validation(Required=false)]
            public ProvisionExternalApplicationResponseBodyExternalApplicationDelegatedScope DelegatedScope { get; set; }
            public class ProvisionExternalApplicationResponseBodyExternalApplicationDelegatedScope : TeaModel {
                /// <summary>
                /// <para>The information about the scopes of permissions that are granted to the application.</para>
                /// </summary>
                [NameInMap("PredefinedScopes")]
                [Validation(Required=false)]
                public ProvisionExternalApplicationResponseBodyExternalApplicationDelegatedScopePredefinedScopes PredefinedScopes { get; set; }
                public class ProvisionExternalApplicationResponseBodyExternalApplicationDelegatedScopePredefinedScopes : TeaModel {
                    [NameInMap("PredefinedScope")]
                    [Validation(Required=false)]
                    public List<ProvisionExternalApplicationResponseBodyExternalApplicationDelegatedScopePredefinedScopesPredefinedScope> PredefinedScope { get; set; }
                    public class ProvisionExternalApplicationResponseBodyExternalApplicationDelegatedScopePredefinedScopesPredefinedScope : TeaModel {
                        /// <summary>
                        /// <para>The description of the permission scope.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Obtains the OpenID of the user. This is the default scope and cannot be deleted.</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The name of the permission scope.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>openid</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }

            }

            /// <summary>
            /// <para>The display name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GiteeAliyun</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>403550611646604****</para>
            /// </summary>
            [NameInMap("ForeignAppId")]
            [Validation(Required=false)]
            public string ForeignAppId { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the external application belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>157242285274****</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <para>The update time. The value is a timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1603693518000</para>
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>55535873-9A6B-5C87-853F-C7CD258826F2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
