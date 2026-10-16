// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class UpdateAssociatedTransferSettingRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to start the task for transferring existing associated resources to the resource group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false: Does not start the task for transferring existing associated resources to the resource group.</description></item>
        /// <item><description>true: Starts the task for transferring existing associated resources to the resource group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableExistingResourcesTransfer")]
        [Validation(Required=false)]
        public string EnableExistingResourcesTransfer { get; set; }

        /// <summary>
        /// <para>The rule settings of the associated resource group transfer feature.</para>
        /// </summary>
        [NameInMap("RuleSettings")]
        [Validation(Required=false)]
        public List<UpdateAssociatedTransferSettingRequestRuleSettings> RuleSettings { get; set; }
        public class UpdateAssociatedTransferSettingRequestRuleSettings : TeaModel {
            /// <summary>
            /// <para>The resource type of the associated resource.</para>
            /// <para>You can obtain the resource type from the <b>Resource Type</b> column in <a href="https://help.aliyun.com/document_detail/94479.html">Cloud services that support resource groups</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>disk</para>
            /// </summary>
            [NameInMap("AssociatedResourceType")]
            [Validation(Required=false)]
            public string AssociatedResourceType { get; set; }

            /// <summary>
            /// <para>The cloud service code of the associated resource.</para>
            /// <para>You can obtain the cloud service code from the <b>Cloud Service Code</b> column in <a href="https://help.aliyun.com/document_detail/94479.html">Cloud services that support resource groups</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("AssociatedService")]
            [Validation(Required=false)]
            public string AssociatedService { get; set; }

            /// <summary>
            /// <para>The resource type of the master resource.</para>
            /// <para>You can obtain the resource type from the <b>Resource Type</b> column in <a href="https://help.aliyun.com/document_detail/94479.html">Cloud services that support resource groups</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance</para>
            /// </summary>
            [NameInMap("MasterResourceType")]
            [Validation(Required=false)]
            public string MasterResourceType { get; set; }

            /// <summary>
            /// <para>The cloud service code of the master resource.</para>
            /// <para>You can obtain the cloud service code from the <b>Cloud Service Code</b> column in <a href="https://help.aliyun.com/document_detail/94479.html">Cloud services that support resource groups</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("MasterService")]
            [Validation(Required=false)]
            public string MasterService { get; set; }

            /// <summary>
            /// <para>The enabling status of the associated resource group transfer feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Enable: Enabled.</description></item>
            /// <item><description>Disable: Disabled.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
