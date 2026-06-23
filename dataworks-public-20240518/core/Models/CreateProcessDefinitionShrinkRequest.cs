// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateProcessDefinitionShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of approval nodes.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ApprovalNodes")]
        [Validation(Required=false)]
        public string ApprovalNodesShrink { get; set; }

        /// <summary>
        /// <para>The idempotency token. We recommend that you use a UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the process definition.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>这是一个示例策略</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the process definition.</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The name of the process definition.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>我的审批策略</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The notification service declarations.</para>
        /// </summary>
        [NameInMap("NotificationServices")]
        [Validation(Required=false)]
        public string NotificationServicesShrink { get; set; }

        /// <summary>
        /// <para>The list of condition rules.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RuleConditions")]
        [Validation(Required=false)]
        public string RuleConditionsShrink { get; set; }

        /// <summary>
        /// <para>The subtype. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Table</description></item>
        /// <item><description>Column</description></item>
        /// <item><description>Database</description></item>
        /// <item><description>Schema</description></item>
        /// <item><description>Default</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Table</para>
        /// </summary>
        [NameInMap("SubType")]
        [Validation(Required=false)]
        public string SubType { get; set; }

        /// <summary>
        /// <para>The type of the process definition. Valid values:</para>
        /// <ol>
        /// <item><description>MaxCompute</description></item>
        /// <item><description>DataService</description></item>
        /// <item><description>Extension</description></item>
        /// <item><description>Hologres</description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>Extension</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
