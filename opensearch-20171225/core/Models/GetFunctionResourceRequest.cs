// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class GetFunctionResourceRequest : TeaModel {
        /// <summary>
        /// <para>The output level.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>simple</description></item>
        /// <item><description>normal</description></item>
        /// <item><description>detail</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>detail</para>
        /// </summary>
        [NameInMap("output")]
        [Validation(Required=false)]
        public string Output { get; set; }

    }

}
