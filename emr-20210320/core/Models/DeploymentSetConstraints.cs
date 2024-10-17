// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class DeploymentSetConstraints : TeaModel {
        /// <summary>
        /// <para>默认值。</para>
        /// 
        /// <b>Example:</b>
        /// <para>CLUSTER</para>
        /// </summary>
        [NameInMap("DefaultValue")]
        [Validation(Required=false)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>是否启用部署集限制策略</para>
        /// </summary>
        [NameInMap("EnableState")]
        [Validation(Required=false)]
        public string EnableState { get; set; }

        /// <summary>
        /// <para>替换策略。</para>
        /// </summary>
        [NameInMap("ReplacementStrategy")]
        [Validation(Required=false)]
        public ReplacementStrategy ReplacementStrategy { get; set; }

        /// <summary>
        /// <para>枚举值。</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;CLUSTER&quot;,&quot;NODE_GROUP&quot;,&quot;NONE&quot;]</para>
        /// </summary>
        [NameInMap("Values")]
        [Validation(Required=false)]
        public List<string> Values { get; set; }

    }

}
