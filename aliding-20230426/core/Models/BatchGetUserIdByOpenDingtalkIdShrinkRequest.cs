// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class BatchGetUserIdByOpenDingtalkIdShrinkRequest : TeaModel {
        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public string TenantContextShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;DTOJdYJ2IQC4HuexhtjsS8Qxxxx&quot;,&quot;D8301AKf6lmZbXiilcB4P2MVxxxx&quot;]</para>
        /// </summary>
        [NameInMap("openDingtalkIds")]
        [Validation(Required=false)]
        public string OpenDingtalkIdsShrink { get; set; }

    }

}
