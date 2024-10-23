// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class GetResourceTagsOutput : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ALIYUN::FC::FUNCTION</para>
        /// </summary>
        [NameInMap("resouceType")]
        [Validation(Required=false)]
        public string ResouceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>acs:fc:cn-shanghai:****:functions/demo</para>
        /// </summary>
        [NameInMap("resourceArn")]
        [Validation(Required=false)]
        public string ResourceArn { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public Dictionary<string, string> Tags { get; set; }

    }

}
