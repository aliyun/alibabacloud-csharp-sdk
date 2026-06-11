// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleTemplate : TeaModel {
        /// <summary>
        /// <para>The type of the alert.</para>
        /// </summary>
        [NameInMap("alertType")]
        [Validation(Required=false)]
        public string AlertType { get; set; }

        /// <summary>
        /// <para>The number of alert rules created from this template.</para>
        /// </summary>
        [NameInMap("applyCount")]
        [Validation(Required=false)]
        public long? ApplyCount { get; set; }

        /// <summary>
        /// <para>The description of the template.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The creation time of the template, as a UNIX timestamp.</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public long? GmtCreate { get; set; }

        /// <summary>
        /// <para>The time the template was last modified, as a UNIX timestamp.</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public long? GmtModified { get; set; }

        /// <summary>
        /// <para>The ID of the alert rule template.</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>Indicates whether the template is system-defined. Valid values: <c>0</c> (user-defined) and <c>1</c> (system-defined).</para>
        /// </summary>
        [NameInMap("isSystem")]
        [Validation(Required=false)]
        public int? IsSystem { get; set; }

        /// <summary>
        /// <para>The labels associated with the template, formatted as a JSON string.</para>
        /// </summary>
        [NameInMap("labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// <para>The rule configuration, formatted as a JSON string.</para>
        /// </summary>
        [NameInMap("ruleConfigs")]
        [Validation(Required=false)]
        public string RuleConfigs { get; set; }

        /// <summary>
        /// <para>The status of the template.</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The subtype of the alert.</para>
        /// </summary>
        [NameInMap("subType")]
        [Validation(Required=false)]
        public string SubType { get; set; }

        /// <summary>
        /// <para>The name of the alert rule template.</para>
        /// </summary>
        [NameInMap("templateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The ID of the user who owns the template.</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The universally unique identifier (UUID) of the template.</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
