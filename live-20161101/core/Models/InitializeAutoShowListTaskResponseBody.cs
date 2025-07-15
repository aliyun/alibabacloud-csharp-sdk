// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class InitializeAutoShowListTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the production studio.</para>
        /// <remarks>
        /// <para> The value of this parameter can be used as the value of a request parameter to query the streaming URL of the production studio, start the production studio, add video resources to the production studio, add a production studio layout, query production studio layouts, add a production studio component, and add a production studio playlist.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>b4810848-bcf9-4aef-bd4a-e6bba2d9****</para>
        /// </summary>
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of output video streams.</para>
        /// <list type="bullet">
        /// <item><description>videoFormat: the format of the streaming URL.</description></item>
        /// <item><description>outputStreamUrl: the source URL.</description></item>
        /// <item><description>transcodeConfig: the output resolution specified for video transcoding of the source URL.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;videoFormat&quot;:&quot;flv&quot;,&quot;outputStreamUrl&quot;:&quot;<a href="http://example.aliyundoc.com%22,%22transcodeConfig%22:%22original%22%7D%5D">http://example.aliyundoc.com&quot;,&quot;transcodeConfig&quot;:&quot;original&quot;}]</a></para>
        /// </summary>
        [NameInMap("StreamList")]
        [Validation(Required=false)]
        public string StreamList { get; set; }

    }

}
