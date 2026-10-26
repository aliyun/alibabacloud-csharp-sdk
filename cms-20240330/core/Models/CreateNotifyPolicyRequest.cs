// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateNotifyPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The request body, which contains the complete NotifyPolicyConfig configuration object for the notification policy.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public NotifyPolicyConfig Body { get; set; }

        /// <summary>
        /// <para>The workspace ID, which isolates notification policy resources across different business workspaces.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default-cms-xxxx-cn-hangzhou</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
