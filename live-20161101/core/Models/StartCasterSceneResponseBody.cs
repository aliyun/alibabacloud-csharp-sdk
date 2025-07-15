// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class StartCasterSceneResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CF60DB6A-7FD6-426E-9288-122CC1A52FA7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The streaming URL of the scene. It is used for playback, but not for stream relay.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://live/caster/example.org">http://live/caster/example.org</a></para>
        /// </summary>
        [NameInMap("StreamUrl")]
        [Validation(Required=false)]
        public string StreamUrl { get; set; }

    }

}
