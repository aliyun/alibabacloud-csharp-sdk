// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ModifyAppInstanceGroupAttributeRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        [NameInMap("AppInstanceGroupName")]
        [Validation(Required=false)]
        public string AppInstanceGroupName { get; set; }

        [NameInMap("Network")]
        [Validation(Required=false)]
        public ModifyAppInstanceGroupAttributeRequestNetwork Network { get; set; }
        public class ModifyAppInstanceGroupAttributeRequestNetwork : TeaModel {
            [NameInMap("DomainRules")]
            [Validation(Required=false)]
            public List<ModifyAppInstanceGroupAttributeRequestNetworkDomainRules> DomainRules { get; set; }
            public class ModifyAppInstanceGroupAttributeRequestNetworkDomainRules : TeaModel {
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

            }

        }

        [NameInMap("NodePool")]
        [Validation(Required=false)]
        public ModifyAppInstanceGroupAttributeRequestNodePool NodePool { get; set; }
        public class ModifyAppInstanceGroupAttributeRequestNodePool : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NodeCapacity")]
            [Validation(Required=false)]
            public int? NodeCapacity { get; set; }

            /// <summary>
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

        [NameInMap("PreOpenAppId")]
        [Validation(Required=false)]
        public string PreOpenAppId { get; set; }

        [NameInMap("PreOpenMode")]
        [Validation(Required=false)]
        public string PreOpenMode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        [NameInMap("SecurityPolicy")]
        [Validation(Required=false)]
        public ModifyAppInstanceGroupAttributeRequestSecurityPolicy SecurityPolicy { get; set; }
        public class ModifyAppInstanceGroupAttributeRequestSecurityPolicy : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ResetAfterUnbind")]
            [Validation(Required=false)]
            public bool? ResetAfterUnbind { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SkipUserAuthCheck")]
            [Validation(Required=false)]
            public bool? SkipUserAuthCheck { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("SessionTimeout")]
        [Validation(Required=false)]
        public int? SessionTimeout { get; set; }

        [NameInMap("StoragePolicy")]
        [Validation(Required=false)]
        public ModifyAppInstanceGroupAttributeRequestStoragePolicy StoragePolicy { get; set; }
        public class ModifyAppInstanceGroupAttributeRequestStoragePolicy : TeaModel {
            [NameInMap("StorageTypeList")]
            [Validation(Required=false)]
            public List<string> StorageTypeList { get; set; }

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
