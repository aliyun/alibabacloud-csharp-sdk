// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateSlsLogDispatchRequest : TeaModel {
        /// <summary>
        /// <para>The region ID of the Simple Log Service project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-southeast-1</para>
        /// </summary>
        [NameInMap("SlsRegionId")]
        [Validation(Required=false)]
        public string SlsRegionId { get; set; }

        /// <summary>
        /// <para>The log retention period. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public long? Ttl { get; set; }

    }

}
