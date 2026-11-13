// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class Resource : TeaModel {
        /// <summary>
        /// <para>The resource type name. Valid values: ALIYUN::FC::FUNCTION for functions in Function Compute 3.0, and ALIYUN::FC::SERVICE for services in legacy Function Compute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALIYUN::FC::FUNCTION</para>
        /// </summary>
        [NameInMap("resouceType")]
        [Validation(Required=false)]
        public string ResouceType { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud resource descriptor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:fc:cn-shanghai:****:functions/demo</para>
        /// </summary>
        [NameInMap("resourceArn")]
        [Validation(Required=false)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// <para>The tag dictionary. key indicates the tag key, and value indicates the tag value.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public Dictionary<string, string> Tags { get; set; }

    }

}
