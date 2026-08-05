// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class InitializeAutoShowListTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The production studio ID.</para>
        /// <remarks>
        /// <para>This ID can be used as a request parameter for querying production studio stream URLs, starting the production studio, adding video resources to the production studio, adding layouts to the production studio, querying the layout list of the production studio, adding components to the production studio, and adding programs to the production studio.</para>
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
        /// <para>The list of output addresses of the production studio.</para>
        /// <list type="bullet">
        /// <item><description><para>videoFormat: the streaming URL format.</para>
        /// </description></item>
        /// <item><description><para>outputStreamUrl: the stream pulling URL.</para>
        /// </description></item>
        /// <item><description><para>transcodeConfig: the transcoding resolution description of the stream pulling URL.</para>
        /// </description></item>
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
