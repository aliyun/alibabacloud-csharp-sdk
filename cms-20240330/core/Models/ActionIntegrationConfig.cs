// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ActionIntegrationConfig : TeaModel {
        /// <summary>
        /// <para>The list of action integration configurations. An action integration is an automated action that is executed after an alert rule is triggered, such as sending a notification or invoking a webhook. Each action integration is referenced by its action integration ID.</para>
        /// </summary>
        [NameInMap("actions")]
        [Validation(Required=false)]
        public List<string> Actions { get; set; }

        /// <summary>
        /// <para>Indicates whether action integration is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

    }

}
