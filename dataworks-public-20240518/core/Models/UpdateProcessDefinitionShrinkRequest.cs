// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateProcessDefinitionShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of approval nodes. Note: System policies do not take effect.</para>
        /// </summary>
        [NameInMap("ApprovalNodes")]
        [Validation(Required=false)]
        public string ApprovalNodesShrink { get; set; }

        /// <summary>
        /// <para>The idempotency token. Used to prevent duplicate operations caused by multiple calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AFAE64E-D1BE-432B-A9****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the approval process definition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Approval policy for MaxCompute tables in the lwt_ide_simple project</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the approval process definition.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>177554881536128</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The name of the approval process definition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MaxCompute table approval</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The notification service declaration.</para>
        /// </summary>
        [NameInMap("NotificationServices")]
        [Validation(Required=false)]
        public string NotificationServicesShrink { get; set; }

        /// <summary>
        /// <para>The list of conditional rules. Note: System policies do not take effect.</para>
        /// </summary>
        [NameInMap("RuleConditions")]
        [Validation(Required=false)]
        public string RuleConditionsShrink { get; set; }

    }

}
