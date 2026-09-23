// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ProvisionExternalApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>The external application information.</para>
        /// </summary>
        [NameInMap("ExternalApplication")]
        [Validation(Required=false)]
        public ProvisionExternalApplicationResponseBodyExternalApplication ExternalApplication { get; set; }
        public class ProvisionExternalApplicationResponseBodyExternalApplication : TeaModel {
            /// <summary>
            /// <para>The application principal name in the format of <c>&lt;app_name&gt;@app.&lt;account_id&gt;.onaliyun.com</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:GiteePrd@app.177242285274">GiteePrd@app.177242285274</a>****.onaliyun.com</para>
            /// </summary>
            [NameInMap("AppPrincipalName")]
            [Validation(Required=false)]
            public string AppPrincipalName { get; set; }

            /// <summary>
            /// <para>The installation timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1603693518000</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The permission scope information of the application.</para>
            /// </summary>
            [NameInMap("DelegatedScope")]
            [Validation(Required=false)]
            public ProvisionExternalApplicationResponseBodyExternalApplicationDelegatedScope DelegatedScope { get; set; }
            public class ProvisionExternalApplicationResponseBodyExternalApplicationDelegatedScope : TeaModel {
                [NameInMap("PredefinedScopes")]
                [Validation(Required=false)]
                public ProvisionExternalApplicationResponseBodyExternalApplicationDelegatedScopePredefinedScopes PredefinedScopes { get; set; }
                public class ProvisionExternalApplicationResponseBodyExternalApplicationDelegatedScopePredefinedScopes : TeaModel {
                    [NameInMap("PredefinedScope")]
                    [Validation(Required=false)]
                    public List<ProvisionExternalApplicationResponseBodyExternalApplicationDelegatedScopePredefinedScopesPredefinedScope> PredefinedScope { get; set; }
                    public class ProvisionExternalApplicationResponseBodyExternalApplicationDelegatedScopePredefinedScopesPredefinedScope : TeaModel {
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }

            }

            /// <summary>
            /// <para>The display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GiteeAliyun</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The external application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>403550611646604****</para>
            /// </summary>
            [NameInMap("ForeignAppId")]
            [Validation(Required=false)]
            public string ForeignAppId { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID to which the external application is installed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>157242285274****</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <para>The update timestamp.</para>
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
