// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeKVCacheInstanceAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the KVCache instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pkv-123456</para>
        /// </summary>
        [NameInMap("KVCacheInstanceId")]
        [Validation(Required=false)]
        public string KVCacheInstanceId { get; set; }

    }

}
