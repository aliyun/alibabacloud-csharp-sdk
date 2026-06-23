// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class GlobalSceneItem : TeaModel {
        /// <summary>
        /// <para>The detailed information in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        /// &quot;snippet&quot;: &quot;截至2025年3月7日，SpaceX星舰已经发射了8次，并取得4次成功及4次失败。&quot;,
        /// &quot;snippetHighlighted&quot;: [&quot;8次&quot;],
        /// &quot;title&quot;: &quot;星舰发射任务列表&quot;
        /// }</para>
        /// </summary>
        [NameInMap("detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        /// <summary>
        /// <para>The type of the vertical data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>answerBox</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
