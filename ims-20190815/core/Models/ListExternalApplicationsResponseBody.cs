// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListExternalApplicationsResponseBody : TeaModel {
        [NameInMap("ExternalApplications")]
        [Validation(Required=false)]
        public ListExternalApplicationsResponseBodyExternalApplications ExternalApplications { get; set; }
        public class ListExternalApplicationsResponseBodyExternalApplications : TeaModel {
            [NameInMap("ExternalApplication")]
            [Validation(Required=false)]
            public List<ListExternalApplicationsResponseBodyExternalApplicationsExternalApplication> ExternalApplication { get; set; }
            public class ListExternalApplicationsResponseBodyExternalApplicationsExternalApplication : TeaModel {
                [NameInMap("AppPrincipalName")]
                [Validation(Required=false)]
                public string AppPrincipalName { get; set; }

                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                [NameInMap("DelegatedScope")]
                [Validation(Required=false)]
                public ListExternalApplicationsResponseBodyExternalApplicationsExternalApplicationDelegatedScope DelegatedScope { get; set; }
                public class ListExternalApplicationsResponseBodyExternalApplicationsExternalApplicationDelegatedScope : TeaModel {
                    [NameInMap("PredefinedScopes")]
                    [Validation(Required=false)]
                    public ListExternalApplicationsResponseBodyExternalApplicationsExternalApplicationDelegatedScopePredefinedScopes PredefinedScopes { get; set; }
                    public class ListExternalApplicationsResponseBodyExternalApplicationsExternalApplicationDelegatedScopePredefinedScopes : TeaModel {
                        [NameInMap("PredefinedScope")]
                        [Validation(Required=false)]
                        public List<ListExternalApplicationsResponseBodyExternalApplicationsExternalApplicationDelegatedScopePredefinedScopesPredefinedScope> PredefinedScope { get; set; }
                        public class ListExternalApplicationsResponseBodyExternalApplicationsExternalApplicationDelegatedScopePredefinedScopesPredefinedScope : TeaModel {
                            [NameInMap("Description")]
                            [Validation(Required=false)]
                            public string Description { get; set; }

                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                    }

                }

                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("ForeignAppId")]
                [Validation(Required=false)]
                public string ForeignAppId { get; set; }

                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

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
