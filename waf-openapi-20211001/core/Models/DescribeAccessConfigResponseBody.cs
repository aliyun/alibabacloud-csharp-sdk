// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeAccessConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The value of the queried configuration item. For more information, see the <b>ConfigValue</b> parameter in <a href="~~ModifyAccessConfig~~">ModifyAccessConfig</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;status&quot;:1,&quot;products&quot;:[&quot;alb&quot;]}</para>
        /// </summary>
        [NameInMap("ConfigValue")]
        [Validation(Required=false)]
        public string ConfigValue { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D7861F61-5B61-46CE-A47C-6B19160D5EB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
