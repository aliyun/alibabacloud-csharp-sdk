// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class AdjustPtsSceneSpeedShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The stress testing speed in the PTS scenario.</para>
        /// </summary>
        [NameInMap("ApiSpeedList")]
        [Validation(Required=false)]
        public string ApiSpeedListShrink { get; set; }

        /// <summary>
        /// <para>The scenario ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DYXXX12H</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

    }

}
