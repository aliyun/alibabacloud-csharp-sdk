// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListApplicationProvisionInfosResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the installed applications.</para>
        /// </summary>
        [NameInMap("ApplicationProvisionInfos")]
        [Validation(Required=false)]
        public ListApplicationProvisionInfosResponseBodyApplicationProvisionInfos ApplicationProvisionInfos { get; set; }
        public class ListApplicationProvisionInfosResponseBodyApplicationProvisionInfos : TeaModel {
            [NameInMap("ApplicationProvisionInfo")]
            [Validation(Required=false)]
            public List<ListApplicationProvisionInfosResponseBodyApplicationProvisionInfosApplicationProvisionInfo> ApplicationProvisionInfo { get; set; }
            public class ListApplicationProvisionInfosResponseBodyApplicationProvisionInfosApplicationProvisionInfo : TeaModel {
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
                /// <para>The information about the permissions that are granted to the application.</para>
                /// </summary>
                [NameInMap("DelegatedScope")]
                [Validation(Required=false)]
                public ListApplicationProvisionInfosResponseBodyApplicationProvisionInfosApplicationProvisionInfoDelegatedScope DelegatedScope { get; set; }
                public class ListApplicationProvisionInfosResponseBodyApplicationProvisionInfosApplicationProvisionInfoDelegatedScope : TeaModel {
                    /// <summary>
                    /// <para>The information about the permissions that are granted to the application.</para>
                    /// </summary>
                    [NameInMap("PredefinedScopes")]
                    [Validation(Required=false)]
                    public ListApplicationProvisionInfosResponseBodyApplicationProvisionInfosApplicationProvisionInfoDelegatedScopePredefinedScopes PredefinedScopes { get; set; }
                    public class ListApplicationProvisionInfosResponseBodyApplicationProvisionInfosApplicationProvisionInfoDelegatedScopePredefinedScopes : TeaModel {
                        [NameInMap("PredefinedScope")]
                        [Validation(Required=false)]
                        public List<ListApplicationProvisionInfosResponseBodyApplicationProvisionInfosApplicationProvisionInfoDelegatedScopePredefinedScopesPredefinedScope> PredefinedScope { get; set; }
                        public class ListApplicationProvisionInfosResponseBodyApplicationProvisionInfosApplicationProvisionInfoDelegatedScopePredefinedScopesPredefinedScope : TeaModel {
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
                /// <para>The update time. The value is a timestamp.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E403EBFD-C997-489D-BFC7-37C05E66D67C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
