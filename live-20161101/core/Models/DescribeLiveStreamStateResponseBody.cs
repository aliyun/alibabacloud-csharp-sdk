// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamStateResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CE6CD79D-0A98-1F22-A15F-FADA74DF2729</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the stream. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>online: The stream is being ingested.</description></item>
        /// <item><description>offline: The stream is offline. This may be caused by failed or completed stream ingest. For the specific reason, check the stream ingest callback. This operation does not provide detailed information.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>online</para>
        /// </summary>
        [NameInMap("StreamState")]
        [Validation(Required=false)]
        public string StreamState { get; set; }

        /// <summary>
        /// <para>The mode of the stream. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>push: stream ingest</description></item>
        /// <item><description>pull: triggered stream pulling</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>push</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
