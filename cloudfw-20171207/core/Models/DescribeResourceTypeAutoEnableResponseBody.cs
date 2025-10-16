// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeResourceTypeAutoEnableResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>7447795A-39AB-52CB-8F92-128DF******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceTypeAutoEnable")]
        [Validation(Required=false)]
        public Dictionary<string, bool?> ResourceTypeAutoEnable { get; set; }

    }

}
