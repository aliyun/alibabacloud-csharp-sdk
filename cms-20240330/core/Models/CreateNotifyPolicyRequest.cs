// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateNotifyPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The request body, which is the complete notification policy configuration object NotifyPolicyConfig.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public NotifyPolicyConfig Body { get; set; }

        /// <summary>
        /// <para>The workspace ID. This parameter is used to isolate notification policy resources across different business spaces.</para>
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
