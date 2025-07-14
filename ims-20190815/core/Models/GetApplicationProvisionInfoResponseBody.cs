// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetApplicationProvisionInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The installation information about the application.</para>
        /// </summary>
        [NameInMap("ApplicationProvisionInfo")]
        [Validation(Required=false)]
        public GetApplicationProvisionInfoResponseBodyApplicationProvisionInfo ApplicationProvisionInfo { get; set; }
        public class GetApplicationProvisionInfoResponseBodyApplicationProvisionInfo : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>177242285274****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

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
            public GetApplicationProvisionInfoResponseBodyApplicationProvisionInfoDelegatedScope DelegatedScope { get; set; }
            public class GetApplicationProvisionInfoResponseBodyApplicationProvisionInfoDelegatedScope : TeaModel {
                /// <summary>
                /// <para>The information about the scopes of permissions that are granted to the application.</para>
                /// </summary>
                [NameInMap("PredefinedScopes")]
                [Validation(Required=false)]
                public GetApplicationProvisionInfoResponseBodyApplicationProvisionInfoDelegatedScopePredefinedScopes PredefinedScopes { get; set; }
                public class GetApplicationProvisionInfoResponseBodyApplicationProvisionInfoDelegatedScopePredefinedScopes : TeaModel {
                    [NameInMap("PredefinedScope")]
                    [Validation(Required=false)]
                    public List<GetApplicationProvisionInfoResponseBodyApplicationProvisionInfoDelegatedScopePredefinedScopesPredefinedScope> PredefinedScope { get; set; }
                    public class GetApplicationProvisionInfoResponseBodyApplicationProvisionInfoDelegatedScopePredefinedScopesPredefinedScope : TeaModel {
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
        /// <para>936E1D9C-157D-45BD-8A3B-81C0716EB078</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
