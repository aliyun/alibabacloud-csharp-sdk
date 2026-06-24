// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ModifyAppInstanceGroupAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The delivery group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The delivery group name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>办公应用</para>
        /// </summary>
        [NameInMap("AppInstanceGroupName")]
        [Validation(Required=false)]
        public string AppInstanceGroupName { get; set; }

        /// <summary>
        /// <para>The network configuration.</para>
        /// <remarks>
        /// <para>To use this parameter, submit a ticket.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Network")]
        [Validation(Required=false)]
        public ModifyAppInstanceGroupAttributeRequestNetwork Network { get; set; }
        public class ModifyAppInstanceGroupAttributeRequestNetwork : TeaModel {
            /// <summary>
            /// <para>The domain name rule configurations.</para>
            /// </summary>
            [NameInMap("DomainRules")]
            [Validation(Required=false)]
            public List<ModifyAppInstanceGroupAttributeRequestNetworkDomainRules> DomainRules { get; set; }
            public class ModifyAppInstanceGroupAttributeRequestNetworkDomainRules : TeaModel {
                /// <summary>
                /// <para>The domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com">www.example.com</a></para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>The policy value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>block</para>
                /// </summary>
                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

            }

        }

        /// <summary>
        /// <para>The resource group object.</para>
        /// </summary>
        [NameInMap("NodePool")]
        [Validation(Required=false)]
        public ModifyAppInstanceGroupAttributeRequestNodePool NodePool { get; set; }
        public class ModifyAppInstanceGroupAttributeRequestNodePool : TeaModel {
            /// <summary>
            /// <para>The number of concurrent sessions, which is the number of sessions that can be simultaneously connected to a single resource. Too many simultaneous sessions may degrade the application experience. The valid value range varies by resource specification. You can call the ListNodeInstanceType operation to query the valid value range for each resource specification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NodeCapacity")]
            [Validation(Required=false)]
            public int? NodeCapacity { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-ew7va2g1wl3vm****</para>
            /// </summary>
            [NameInMap("NodePoolId")]
            [Validation(Required=false)]
            public string NodePoolId { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to allow only one application per session.</para>
        /// <list type="bullet">
        /// <item><description>If enabled, opening multiple applications within a delivery group allocates a separate session for each application, consuming more sessions.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PerSessionPerApp")]
        [Validation(Required=false)]
        public bool? PerSessionPerApp { get; set; }

        /// <summary>
        /// <para>The AppId of the pre-open application. If the PreOpenMode parameter is set to <c>SINGLE_APP</c>, PreOpenAppId cannot be an empty string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca-b2ronxxd****</para>
        /// </summary>
        [NameInMap("PreOpenAppId")]
        [Validation(Required=false)]
        public string PreOpenAppId { get; set; }

        /// <summary>
        /// <para>The pre-open mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OFF</para>
        /// </summary>
        [NameInMap("PreOpenMode")]
        [Validation(Required=false)]
        public string PreOpenMode { get; set; }

        /// <summary>
        /// <para>The product type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The security policy.</para>
        /// </summary>
        [NameInMap("SecurityPolicy")]
        [Validation(Required=false)]
        public ModifyAppInstanceGroupAttributeRequestSecurityPolicy SecurityPolicy { get; set; }
        public class ModifyAppInstanceGroupAttributeRequestSecurityPolicy : TeaModel {
            /// <summary>
            /// <para>Specifies whether to reset after unbinding.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ResetAfterUnbind")]
            [Validation(Required=false)]
            public bool? ResetAfterUnbind { get; set; }

            /// <summary>
            /// <para>Specifies whether to skip user authorization verification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SkipUserAuthCheck")]
            [Validation(Required=false)]
            public bool? SkipUserAuthCheck { get; set; }

        }

        /// <summary>
        /// <para>The session retention duration after disconnection, in minutes. After an end user session is disconnected, the session is retained for the specified duration before being logged off. Set this parameter to <c>-1</c> to retain the session indefinitely. Valid values: -1 and 3 to 300. Default value: <c>15</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("SessionTimeout")]
        [Validation(Required=false)]
        public int? SessionTimeout { get; set; }

        /// <summary>
        /// <para>The storage policy.</para>
        /// </summary>
        [NameInMap("StoragePolicy")]
        [Validation(Required=false)]
        public ModifyAppInstanceGroupAttributeRequestStoragePolicy StoragePolicy { get; set; }
        public class ModifyAppInstanceGroupAttributeRequestStoragePolicy : TeaModel {
            /// <summary>
            /// <para>The list of storage types.</para>
            /// </summary>
            [NameInMap("StorageTypeList")]
            [Validation(Required=false)]
            public List<string> StorageTypeList { get; set; }

            /// <summary>
            /// <para>The user data roaming configuration.</para>
            /// </summary>
            [NameInMap("UserProfile")]
            [Validation(Required=false)]
            public ModifyAppInstanceGroupAttributeRequestStoragePolicyUserProfile UserProfile { get; set; }
            public class ModifyAppInstanceGroupAttributeRequestStoragePolicyUserProfile : TeaModel {
                /// <summary>
                /// <para>The ID of the user data storage system (NAS ID).</para>
                /// 
                /// <b>Example:</b>
                /// <para>06ae94****</para>
                /// </summary>
                [NameInMap("FileSystemId")]
                [Validation(Required=false)]
                public string FileSystemId { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable user data roaming.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("UserProfileSwitch")]
                [Validation(Required=false)]
                public bool? UserProfileSwitch { get; set; }

            }

            [NameInMap("UserProfileFollow")]
            [Validation(Required=false)]
            public ModifyAppInstanceGroupAttributeRequestStoragePolicyUserProfileFollow UserProfileFollow { get; set; }
            public class ModifyAppInstanceGroupAttributeRequestStoragePolicyUserProfileFollow : TeaModel {
                [NameInMap("FileSystemId")]
                [Validation(Required=false)]
                public string FileSystemId { get; set; }

                [NameInMap("ProfileFollowSwitch")]
                [Validation(Required=false)]
                public bool? ProfileFollowSwitch { get; set; }

            }

        }

    }

}
