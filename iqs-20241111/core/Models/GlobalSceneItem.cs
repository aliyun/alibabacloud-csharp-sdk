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
        /// &quot;snippet&quot;: &quot;As of March 7, 2025, SpaceX Starship has been launched 8 times, with 4 successes and 4 failures.&quot;,
        /// &quot;snippetHighlighted&quot;: [&quot;8 times&quot;],
        /// &quot;title&quot;: &quot;List of Starship launch missions&quot;
        /// }</para>
        /// </summary>
        [NameInMap("detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        /// <summary>
        /// <para>The type of vertical data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>answerBox</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
