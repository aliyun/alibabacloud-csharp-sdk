// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateProcessDefinitionShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ApprovalNodes")]
        [Validation(Required=false)]
        public string ApprovalNodesShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NotificationServices")]
        [Validation(Required=false)]
        public string NotificationServicesShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RuleConditions")]
        [Validation(Required=false)]
        public string RuleConditionsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Table</para>
        /// </summary>
        [NameInMap("SubType")]
        [Validation(Required=false)]
        public string SubType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Extension</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
