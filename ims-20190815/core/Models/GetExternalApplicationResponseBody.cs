// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetExternalApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the external application.</para>
        /// </summary>
        [NameInMap("ExternalApplication")]
        [Validation(Required=false)]
        public GetExternalApplicationResponseBodyExternalApplication ExternalApplication { get; set; }
        public class GetExternalApplicationResponseBodyExternalApplication : TeaModel {
            /// <summary>
            /// <para>The name of the application principal. The value is in the <c>&lt;app_name&gt;@app.&lt;account_id&gt;.onaliyun.com</c> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:GiteePrd@app.153082740420">GiteePrd@app.153082740420</a>****.onaliyun.com</para>
            /// </summary>
            [NameInMap("AppPrincipalName")]
            [Validation(Required=false)]
            public string AppPrincipalName { get; set; }

            /// <summary>
            /// <para>The time when the application was installed. The value is a timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1737534146000</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The information about the permissions that are granted on the application.</para>
            /// </summary>
            [NameInMap("DelegatedScope")]
            [Validation(Required=false)]
            public GetExternalApplicationResponseBodyExternalApplicationDelegatedScope DelegatedScope { get; set; }
            public class GetExternalApplicationResponseBodyExternalApplicationDelegatedScope : TeaModel {
                /// <summary>
                /// <para>The information about the permissions that are granted on the application.</para>
                /// </summary>
                [NameInMap("PredefinedScopes")]
                [Validation(Required=false)]
                public GetExternalApplicationResponseBodyExternalApplicationDelegatedScopePredefinedScopes PredefinedScopes { get; set; }
                public class GetExternalApplicationResponseBodyExternalApplicationDelegatedScopePredefinedScopes : TeaModel {
                    [NameInMap("PredefinedScope")]
                    [Validation(Required=false)]
                    public List<GetExternalApplicationResponseBodyExternalApplicationDelegatedScopePredefinedScopesPredefinedScope> PredefinedScope { get; set; }
                    public class GetExternalApplicationResponseBodyExternalApplicationDelegatedScopePredefinedScopesPredefinedScope : TeaModel {
                        /// <summary>
                        /// <para>The description of the permission.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Obtains the OpenID of the user. This is the default scope and cannot be deleted.</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The name of the permission.</para>
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
            /// <para>407426893752729****</para>
            /// </summary>
            [NameInMap("ForeignAppId")]
            [Validation(Required=false)]
            public string ForeignAppId { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account for which the application is installed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>173082740420****</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <para>The update time of the application. The value is a timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1737534146000</para>
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E4C4D1BD-2558-5BD1-8C36-A5D7FB174A55</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
