// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListAssociatedTransferSettingResponseBody : TeaModel {
        /// <summary>
        /// <para>The settings of the associated resource group transfer feature.</para>
        /// </summary>
        [NameInMap("AssociatedTransferSetting")]
        [Validation(Required=false)]
        public ListAssociatedTransferSettingResponseBodyAssociatedTransferSetting AssociatedTransferSetting { get; set; }
        public class ListAssociatedTransferSettingResponseBodyAssociatedTransferSetting : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>121998723923****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>Indicates whether the task for transferring existing associated resources to the same resource group is started. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>false: The task is not started.</description></item>
            /// <item><description>true: The task is started.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableExistingResourcesTransfer")]
            [Validation(Required=false)]
            public string EnableExistingResourcesTransfer { get; set; }

            /// <summary>
            /// <para>The rule settings of the associated resource group transfer feature.</para>
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
                /// <para>The resource type of the master resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>instance</para>
                /// </summary>
                [NameInMap("MasterResourceType")]
                [Validation(Required=false)]
                public string MasterResourceType { get; set; }

                /// <summary>
                /// <para>The cloud service code of the master resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs</para>
                /// </summary>
                [NameInMap("MasterService")]
                [Validation(Required=false)]
                public string MasterService { get; set; }

                /// <summary>
                /// <para>The status of the associated resource group transfer feature. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Enable: enabled.</description></item>
                /// <item><description>Disable: disabled.</description></item>
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
            /// <para>The status of the associated resource group transfer feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Enable: enabled.</description></item>
            /// <item><description>Disable: disabled.</description></item>
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
