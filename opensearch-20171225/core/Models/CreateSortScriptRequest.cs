// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class CreateSortScriptRequest : TeaModel {
        /// <summary>
        /// <para>The sort phase to which the script applies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>second_rank</para>
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The script name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rank_cava_20230606_v7</para>
        /// </summary>
        [NameInMap("scriptName")]
        [Validation(Required=false)]
        public string ScriptName { get; set; }

        /// <summary>
        /// <para>The script type. Set the value to cava_script.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cava_script</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
