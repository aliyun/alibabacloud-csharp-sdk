// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class DescribeRegionsRequest : TeaModel {
        /// <summary>
        /// <para>The language of the localName parameter that is returned.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ja</description></item>
        /// <item><description>en</description></item>
        /// <item><description>zh</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

    }

}
