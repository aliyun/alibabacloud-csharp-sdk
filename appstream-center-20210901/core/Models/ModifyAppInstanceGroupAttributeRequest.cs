// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ModifyAppInstanceGroupAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the delivery group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The name of the delivery group.</para>
        /// </summary>
        [NameInMap("AppInstanceGroupName")]
        [Validation(Required=false)]
        public string AppInstanceGroupName { get; set; }

        /// <summary>
        /// <para>The network settings.</para>
        /// <remarks>
        /// <para> If you want to use this parameter, submit a ticket.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Network")]
        [Validation(Required=false)]
        public ModifyAppInstanceGroupAttributeRequestNetwork Network { get; set; }
        public class ModifyAppInstanceGroupAttributeRequestNetwork : TeaModel {
            /// <summary>
            /// <para>The domain name rules.</para>
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
                /// <para>The policy used for the domain name.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>allow</description></item>
                /// <item><description>block</description></item>
                /// </list>
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
        /// <para>The information about the resource group.</para>
        /// </summary>
        [NameInMap("NodePool")]
        [Validation(Required=false)]
        public ModifyAppInstanceGroupAttributeRequestNodePool NodePool { get; set; }
        public class ModifyAppInstanceGroupAttributeRequestNodePool : TeaModel {
            /// <summary>
            /// <para>The maximum number of sessions to which a resource can connect at the same time. If a resource connects to a large number of sessions at the same time, user experience can be compromised. The value range varies based on the resource type. The following items describe the value ranges of different resource types:</para>
            /// <list type="bullet">
            /// <item><description>appstreaming.general.4c8g: 1 to 2</description></item>
            /// <item><description>appstreaming.general.8c16g: 1 to 4</description></item>
            /// <item><description>appstreaming.vgpu.8c16g.4g: 1 to 4</description></item>
            /// <item><description>appstreaming.vgpu.8c31g.16g: 1 to 4</description></item>
            /// <item><description>appstreaming.vgpu.14c93g.12g: 1 to 6</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NodeCapacity")]
            [Validation(Required=false)]
            public int? NodeCapacity { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-ew7va2g1wl3vm****</para>
            /// </summary>
            [NameInMap("NodePoolId")]
            [Validation(Required=false)]
            public string NodePoolId { get; set; }

        }

        [NameInMap("PerSessionPerApp")]
        [Validation(Required=false)]
        public bool? PerSessionPerApp { get; set; }

        /// <summary>
        /// <para>The application ID of the pre-open application. If you set <c>PreOpenMode</c> to <c>SINGLE_APP</c>, you cannot leave this parameter empty.``</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca-b2ronxxd****</para>
        /// </summary>
        [NameInMap("PreOpenAppId")]
        [Validation(Required=false)]
        public string PreOpenAppId { get; set; }

        /// <summary>
        /// <para>The pre-open mode.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SINGLE_APP: enables the pre-open mode for a single application.</description></item>
        /// <item><description>OFF: disables the pre-open mode. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OFF</para>
        /// </summary>
        [NameInMap("PreOpenMode")]
        [Validation(Required=false)]
        public string PreOpenMode { get; set; }

        /// <summary>
        /// <para>The product type.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>CloudApp: App Streaming</description></item>
        /// </list>
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
            /// <para>Specifies whether to reset after unbinding from a delivery group.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ResetAfterUnbind")]
            [Validation(Required=false)]
            public bool? ResetAfterUnbind { get; set; }

            /// <summary>
            /// <para>Specifies whether to skip user permission verification.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false: This is the default value.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SkipUserAuthCheck")]
            [Validation(Required=false)]
            public bool? SkipUserAuthCheck { get; set; }

        }

        /// <summary>
        /// <para>The duration for which sessions are retained after disconnection. Unit: minutes. After an end user disconnects from a session, the session is closed only after the specified duration elapses. If you want to permanently retain sessions, set this parameter to <c>-1</c>. Valid values:-1 and 3 to 300. Default value: <c>15</c>.</para>
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
            /// <para>The storage types.</para>
            /// </summary>
            [NameInMap("StorageTypeList")]
            [Validation(Required=false)]
            public List<string> StorageTypeList { get; set; }

            [NameInMap("UserProfile")]
            [Validation(Required=false)]
            public ModifyAppInstanceGroupAttributeRequestStoragePolicyUserProfile UserProfile { get; set; }
            public class ModifyAppInstanceGroupAttributeRequestStoragePolicyUserProfile : TeaModel {
                [NameInMap("FileSystemId")]
                [Validation(Required=false)]
                public string FileSystemId { get; set; }

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
