// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class DeleteApplicationScalingRuleRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. Call the <a href="https://help.aliyun.com/document_detail/149390.html">ListApplication</a> operation to obtain the application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>78194c76-3dca-418e-a263-cccd1ab4****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The name of the scaling rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpu-trigger</para>
        /// </summary>
        [NameInMap("ScalingRuleName")]
        [Validation(Required=false)]
        public string ScalingRuleName { get; set; }

    }

}
