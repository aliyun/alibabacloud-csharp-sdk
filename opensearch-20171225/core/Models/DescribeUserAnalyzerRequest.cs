// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class DescribeUserAnalyzerRequest : TeaModel {
        /// <summary>
        /// <para>The Associated information,output properties based on hierarchy.</para>
        /// <list type="bullet">
        /// <item><description><b>all</b>: Outputs associated app information</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("with")]
        [Validation(Required=false)]
        public string With { get; set; }

    }

}
