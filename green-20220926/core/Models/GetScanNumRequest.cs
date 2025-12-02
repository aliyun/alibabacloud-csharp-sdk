// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetScanNumRequest : TeaModel {
        /// <summary>
        /// <para>Storage space.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tmpsample</para>
        /// </summary>
        [NameInMap("Buckets")]
        [Validation(Required=false)]
        public string Buckets { get; set; }

        /// <summary>
        /// <para>Media type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image</para>
        /// </summary>
        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public int? MediaType { get; set; }

        /// <summary>
        /// <para>Region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
