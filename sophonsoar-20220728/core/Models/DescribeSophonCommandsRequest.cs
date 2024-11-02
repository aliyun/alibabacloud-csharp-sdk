// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeSophonCommandsRequest : TeaModel {
        /// <summary>
        /// <para>The name of the command. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_process</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
