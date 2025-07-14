// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListExternalApplicationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the external applications.</para>
        /// </summary>
        [NameInMap("ExternalApplications")]
        [Validation(Required=false)]
        public ListExternalApplicationsResponseBodyExternalApplications ExternalApplications { get; set; }
        public class ListExternalApplicationsResponseBodyExternalApplications : TeaModel {
            [NameInMap("ExternalApplication")]
            [Validation(Required=false)]
            public List<ListExternalApplicationsResponseBodyExternalApplicationsExternalApplication> ExternalApplication { get; set; }
            public class ListExternalApplicationsResponseBodyExternalApplicationsExternalApplication : TeaModel {
                /// <summary>
                /// <para>The name of the external application principal. The value is in the <c>&lt;app_name&gt;@app.&lt;account_id&gt;.onaliyun.com</c> format.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:GiteePrd@app.153082740420">GiteePrd@app.153082740420</a>****.onaliyun.com</para>
                /// </summary>
                [NameInMap("AppPrincipalName")]
                [Validation(Required=false)]
                public string AppPrincipalName { get; set; }

                /// <summary>
                /// <para>The time when the external application was installed. The value is a timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1603693318000</para>
                /// </summary>
                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                /// <summary>
                /// <para>The information about the permissions that are granted to the external application.</para>
                /// </summary>
                [NameInMap("DelegatedScope")]
                [Validation(Required=false)]
                public ListExternalApplicationsResponseBodyExternalApplicationsExternalApplicationDelegatedScope DelegatedScope { get; set; }
                public class ListExternalApplicationsResponseBodyExternalApplicationsExternalApplicationDelegatedScope : TeaModel {
                    /// <summary>
                    /// <para>The information about the permissions that are granted to the external application.</para>
                    /// </summary>
                    [NameInMap("PredefinedScopes")]
                    [Validation(Required=false)]
                    public ListExternalApplicationsResponseBodyExternalApplicationsExternalApplicationDelegatedScopePredefinedScopes PredefinedScopes { get; set; }
                    public class ListExternalApplicationsResponseBodyExternalApplicationsExternalApplicationDelegatedScopePredefinedScopes : TeaModel {
                        [NameInMap("PredefinedScope")]
                        [Validation(Required=false)]
                        public List<ListExternalApplicationsResponseBodyExternalApplicationsExternalApplicationDelegatedScopePredefinedScopesPredefinedScope> PredefinedScope { get; set; }
                        public class ListExternalApplicationsResponseBodyExternalApplicationsExternalApplicationDelegatedScopePredefinedScopesPredefinedScope : TeaModel {
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
                /// <para>The display name of the external application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GiteeAliyun</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The ID of the external application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>407426893752729****</para>
                /// </summary>
                [NameInMap("ForeignAppId")]
                [Validation(Required=false)]
                public string ForeignAppId { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account for which the external application was installed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>173082740420****</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// <para>The update time of the external application. The value is a timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1603693518000</para>
                /// </summary>
                [NameInMap("UpdateDate")]
                [Validation(Required=false)]
                public string UpdateDate { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the response is truncated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// <remarks>
        /// <para> This parameter is returned only when <c>IsTruncated</c> is <c>true</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>EXAMPLE</para>
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>936E1D9C-157D-45BD-8A3B-81C0716EB077</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
