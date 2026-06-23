// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateProcessDefinitionShrinkRequest : TeaModel {
        /// <summary>
        /// <para>A list of approval nodes. This parameter does not apply to system policies.</para>
        /// </summary>
        [NameInMap("ApprovalNodes")]
        [Validation(Required=false)]
        public string ApprovalNodesShrink { get; set; }

        /// <summary>
        /// <para>An idempotent parameter. It ensures that retried requests do not result in duplicate operations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AFAE64E-D1BE-432B-A9****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the process definition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lwt_ide_simple 项目 MaxCompute 表审批策略</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the process definition.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>177554881536128</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The name of the process definition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MaxCompute 表审批</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The notification service configurations.</para>
        /// </summary>
        [NameInMap("NotificationServices")]
        [Validation(Required=false)]
        public string NotificationServicesShrink { get; set; }

        /// <summary>
        /// <para>A list of rule conditions. This parameter does not apply to system policies.</para>
        /// </summary>
        [NameInMap("RuleConditions")]
        [Validation(Required=false)]
        public string RuleConditionsShrink { get; set; }

    }

}
