// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class Resource : TeaModel {
        /// <summary>
        /// <para>The name of the resource type. Valid values: ALIYUN::FC::FUNCTION and ALIYUN::FC::SERVICE. The former name is used in Function Compute 3.0, and the latter name is used in earlier versions of Function Compute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALIYUN::FC::FUNCTION</para>
        /// </summary>
        [NameInMap("resouceType")]
        [Validation(Required=false)]
        public string ResouceType { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:fc:cn-shanghai:****:functions/demo</para>
        /// </summary>
        [NameInMap("resourceArn")]
        [Validation(Required=false)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// <para>The tag dictionary.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public Dictionary<string, string> Tags { get; set; }

    }

}
