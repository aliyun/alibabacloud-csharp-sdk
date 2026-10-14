// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class GetOssStorageAndAccByBucketsRequest : TeaModel {
        /// <summary>
        /// <para>The bucket information.</para>
        /// <para>This parameter is required. If this parameter is not specified, the service returns error code 160002401.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-bucket</para>
        /// </summary>
        [NameInMap("BucketList")]
        [Validation(Required=false)]
        public string BucketList { get; set; }

    }

}
