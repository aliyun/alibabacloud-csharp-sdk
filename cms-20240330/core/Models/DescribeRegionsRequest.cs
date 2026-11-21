// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DescribeRegionsRequest : TeaModel {
        /// <summary>
        /// <para>The language. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese (default).</description></item>
        /// <item><description>en: English.</description></item>
        /// <item><description>ja: Japanese.</description></item>
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
