// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class DescribeRegionsRequest : TeaModel {
        /// <summary>
        /// <para>The natural language in which responses are returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh-CN</b>: Chinese. This is the default value.</description></item>
        /// <item><description><b>en-US</b>: English.</description></item>
        /// <item><description><b>ja</b>: Japanese.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
