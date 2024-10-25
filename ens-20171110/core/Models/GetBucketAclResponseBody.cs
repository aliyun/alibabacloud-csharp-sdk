// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class GetBucketAclResponseBody : TeaModel {
        /// <summary>
        /// <para>The ACL of the bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>private</para>
        /// </summary>
        [NameInMap("BucketAcl")]
        [Validation(Required=false)]
        public string BucketAcl { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5C881388-2D4B-46F4-A96B-D4E6BD0886A2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
