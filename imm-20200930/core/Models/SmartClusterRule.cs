// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class SmartClusterRule : TeaModel {
        [NameInMap("BaseURIs")]
        [Validation(Required=false)]
        public List<string> BaseURIs { get; set; }

        /// <summary>
        /// <para>An array of keywords for clustering.</para>
        /// </summary>
        [NameInMap("Keywords")]
        [Validation(Required=false)]
        public List<string> Keywords { get; set; }

        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

        /// <summary>
        /// <para>The sensitivity for clustering, ranging from 0.0 to 1.0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.5</para>
        /// </summary>
        [NameInMap("Sensitivity")]
        [Validation(Required=false)]
        public float? Sensitivity { get; set; }

    }

}
