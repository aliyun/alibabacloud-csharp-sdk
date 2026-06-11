// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIRegistry20260317.Models
{
    public class CreateNamespaceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>用于管理客服场景的Prompt</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>我的Prompt空间</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;minBlockRiskLevel&quot;:&quot;medium&quot;,&quot;maxSkipRatio&quot;:0.2}</para>
        /// </summary>
        [NameInMap("ScanPolicy")]
        [Validation(Required=false)]
        public string ScanPolicy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>customer-service,production</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
