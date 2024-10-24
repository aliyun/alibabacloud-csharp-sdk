// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainOverviewResponseBody : TeaModel {
        /// <summary>
        /// <para>The peak queries per second (QPS) during HTTP traffic scrubbing. Unit: QPS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>41652</para>
        /// </summary>
        [NameInMap("MaxHttp")]
        [Validation(Required=false)]
        public long? MaxHttp { get; set; }

        /// <summary>
        /// <para>The peak QPS during HTTPS traffic scrubbing. Unit: QPS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MaxHttps")]
        [Validation(Required=false)]
        public long? MaxHttps { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C33EB3D5-AF96-43CA-9C7E-37A81BC06A1E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
