// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ConditionConfiguration : TeaModel {
        /// <summary>
        /// <para>The evaluate expression.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cnt &gt; 100</para>
        /// </summary>
        [NameInMap("condition")]
        [Validation(Required=false)]
        public string Condition { get; set; }

        /// <summary>
        /// <para>The number of entries that match the evaluate expression to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b>count</b> &gt; 5</para>
        /// </summary>
        [NameInMap("countCondition")]
        [Validation(Required=false)]
        public string CountCondition { get; set; }

    }

}
