// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kvcachestore20260617.Models
{
    public class DeleteKVCacheStoreRequest : TeaModel {
        /// <summary>
        /// <para>The KvCacheStore instance ID. Only instances in the following states can be deleted: Available and Stopped. Instances in other states cannot be deleted.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kvcs-your-id</para>
        /// </summary>
        [NameInMap("KvcsId")]
        [Validation(Required=false)]
        public string KvcsId { get; set; }

        /// <summary>
        /// <para>The region ID, such as cn-hangzhou.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
