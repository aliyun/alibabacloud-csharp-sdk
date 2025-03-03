// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class UpdateAssociatedTransferSettingRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the Transfer Existing Associated Resources feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false</description></item>
        /// <item><description>true</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableExistingResourcesTransfer")]
        [Validation(Required=false)]
        public string EnableExistingResourcesTransfer { get; set; }

        /// <summary>
        /// <para>The settings of transfer rules.</para>
        /// </summary>
        [NameInMap("RuleSettings")]
        [Validation(Required=false)]
        public List<UpdateAssociatedTransferSettingRequestRuleSettings> RuleSettings { get; set; }
        public class UpdateAssociatedTransferSettingRequestRuleSettings : TeaModel {
            /// <summary>
            /// <para>The type of the associated resource.</para>
            /// <para>You can obtain the resource type from the <b>Resource type</b> column in <a href="https://help.aliyun.com/document_detail/94479.html">Services that work with Resource Group</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>disk</para>
            /// </summary>
            [NameInMap("AssociatedResourceType")]
            [Validation(Required=false)]
            public string AssociatedResourceType { get; set; }

            /// <summary>
            /// <para>The service code of the associated resource.</para>
            /// <para>You can obtain the service code from the <b>Service code</b> column in <a href="https://help.aliyun.com/document_detail/94479.html">Services that work with Resource Group</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("AssociatedService")]
            [Validation(Required=false)]
            public string AssociatedService { get; set; }

            /// <summary>
            /// <para>The type of the primary resource.</para>
            /// <para>You can obtain the resource type from the <b>Resource type</b> column in <a href="https://help.aliyun.com/document_detail/94479.html">Services that work with Resource Group</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance</para>
            /// </summary>
            [NameInMap("MasterResourceType")]
            [Validation(Required=false)]
            public string MasterResourceType { get; set; }

            /// <summary>
            /// <para>The service code of the primary resource.</para>
            /// <para>You can obtain the service code from the <b>Service code</b> column in <a href="https://help.aliyun.com/document_detail/94479.html">Services that work with Resource Group</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("MasterService")]
            [Validation(Required=false)]
            public string MasterService { get; set; }

            /// <summary>
            /// <para>The status of the Transfer Associated Resources feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Enable: enabled</description></item>
            /// <item><description>Disable: disabled</description></item>
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
