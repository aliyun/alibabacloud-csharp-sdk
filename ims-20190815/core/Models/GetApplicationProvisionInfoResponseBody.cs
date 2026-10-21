// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetApplicationProvisionInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The application installation information.</para>
        /// </summary>
        [NameInMap("ApplicationProvisionInfo")]
        [Validation(Required=false)]
        public GetApplicationProvisionInfoResponseBodyApplicationProvisionInfo ApplicationProvisionInfo { get; set; }
        public class GetApplicationProvisionInfoResponseBodyApplicationProvisionInfo : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>177242285274****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The application category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Official: official applications</description></item>
            /// <item><description>ThirdParty: regular third-party applications</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ThirdParty</para>
            /// </summary>
            [NameInMap("AppCategory")]
            [Validation(Required=false)]
            public string AppCategory { get; set; }

            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>452392483381546****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GiteePrd</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The application assignment type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AllowAll: No assignment is required. All RAM users and roles can access the application.</description></item>
            /// <item><description>OnDemand: Assignment is required on demand. RAM users and roles can access the application only after it is assigned to them.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AllowAll</para>
            /// </summary>
            [NameInMap("AssignmentType")]
            [Validation(Required=false)]
            public string AssignmentType { get; set; }

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
            /// <para>The application permission scope information.</para>
            /// </summary>
            [NameInMap("DelegatedScope")]
            [Validation(Required=false)]
            public GetApplicationProvisionInfoResponseBodyApplicationProvisionInfoDelegatedScope DelegatedScope { get; set; }
            public class GetApplicationProvisionInfoResponseBodyApplicationProvisionInfoDelegatedScope : TeaModel {
                [NameInMap("PredefinedScopes")]
                [Validation(Required=false)]
                public GetApplicationProvisionInfoResponseBodyApplicationProvisionInfoDelegatedScopePredefinedScopes PredefinedScopes { get; set; }
                public class GetApplicationProvisionInfoResponseBodyApplicationProvisionInfoDelegatedScopePredefinedScopes : TeaModel {
                    [NameInMap("PredefinedScope")]
                    [Validation(Required=false)]
                    public List<GetApplicationProvisionInfoResponseBodyApplicationProvisionInfoDelegatedScopePredefinedScopesPredefinedScope> PredefinedScope { get; set; }
                    public class GetApplicationProvisionInfoResponseBodyApplicationProvisionInfoDelegatedScopePredefinedScopesPredefinedScope : TeaModel {
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
            /// <para>The display name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GiteeAliyun</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>Indicates whether user authorization is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NeedPrincipalConsent")]
            [Validation(Required=false)]
            public bool? NeedPrincipalConsent { get; set; }

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
        /// <para>936E1D9C-157D-45BD-8A3B-81C0716EB078</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
