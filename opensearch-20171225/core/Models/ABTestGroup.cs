// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ABTestGroup : TeaModel {
        /// <summary>
        /// <para>The alias of the test group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>“kevin_test”</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The status of the test group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: not in effect</description></item>
        /// <item><description>1: in effect</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
