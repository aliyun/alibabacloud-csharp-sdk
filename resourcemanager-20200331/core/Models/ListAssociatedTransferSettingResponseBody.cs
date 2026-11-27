// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListAssociatedTransferSettingResponseBody : TeaModel {
        /// <summary>
        /// <para>The associated transfer settings.</para>
        /// </summary>
        [NameInMap("AssociatedTransferSetting")]
        [Validation(Required=false)]
        public ListAssociatedTransferSettingResponseBodyAssociatedTransferSetting AssociatedTransferSetting { get; set; }
        public class ListAssociatedTransferSettingResponseBodyAssociatedTransferSetting : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>121998723923****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>Specifies whether to transfer existing associated resources along with the resource group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>false: Existing associated resources are not transferred along with the resource group.</description></item>
            /// <item><description>true: Existing associated resources are transferred along with the resource group.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableExistingResourcesTransfer")]
            [Validation(Required=false)]
            public string EnableExistingResourcesTransfer { get; set; }

            /// <summary>
            /// <para>The rule settings for the associated transfer feature.</para>
            /// </summary>
            [NameInMap("RuleSettings")]
            [Validation(Required=false)]
            public List<ListAssociatedTransferSettingResponseBodyAssociatedTransferSettingRuleSettings> RuleSettings { get; set; }
            public class ListAssociatedTransferSettingResponseBodyAssociatedTransferSettingRuleSettings : TeaModel {
                /// <summary>
                /// <para>The resource type of the associated resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>disk</para>
                /// </summary>
                [NameInMap("AssociatedResourceType")]
                [Validation(Required=false)]
                public string AssociatedResourceType { get; set; }

                /// <summary>
                /// <para>The cloud service code of the associated resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs</para>
                /// </summary>
                [NameInMap("AssociatedService")]
                [Validation(Required=false)]
                public string AssociatedService { get; set; }

                /// <summary>
                /// <para>The resource type of the primary resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>instance</para>
                /// </summary>
                [NameInMap("MasterResourceType")]
                [Validation(Required=false)]
                public string MasterResourceType { get; set; }

                /// <summary>
                /// <para>The cloud service code of the primary resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs</para>
                /// </summary>
                [NameInMap("MasterService")]
                [Validation(Required=false)]
                public string MasterService { get; set; }

                /// <summary>
                /// <para>The enabling status of the associated transfer feature. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Enable: Enabled.</description></item>
                /// <item><description>Disable: Disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Enable</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The enabling status of the associated transfer feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Enable: Enabled.</description></item>
            /// <item><description>Disable: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7556FD65-45D2-5C45-9FC9-A7DE831C775C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
