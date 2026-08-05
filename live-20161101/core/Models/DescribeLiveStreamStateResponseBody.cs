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
        /// <para>The state of the stream. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>online: The stream is active.</para>
        /// </description></item>
        /// <item><description><para>offline: The stream is offline. This may mean the stream ingest has failed or ended. For specific details, use the data returned by the stream ingest callback. This operation does not provide a detailed breakdown of the offline status.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>online</para>
        /// </summary>
        [NameInMap("StreamState")]
        [Validation(Required=false)]
        public string StreamState { get; set; }

        /// <summary>
        /// <para>The stream ingest method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>push</para>
        /// </description></item>
        /// <item><description><para>pull</para>
        /// </description></item>
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
