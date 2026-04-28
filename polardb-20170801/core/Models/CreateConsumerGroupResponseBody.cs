// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateConsumerGroupResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cg-xxxxxx</para>
        /// </summary>
        [NameInMap("ConsumerGroupId")]
        [Validation(Required=false)]
        public string ConsumerGroupId { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>A7E6A8FD-C50B-46B2-BA85-D8B8D3******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
