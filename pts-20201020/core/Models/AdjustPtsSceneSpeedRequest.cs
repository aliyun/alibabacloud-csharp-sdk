// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class AdjustPtsSceneSpeedRequest : TeaModel {
        /// <summary>
        /// <para>The stress testing speed in the PTS scenario.</para>
        /// </summary>
        [NameInMap("ApiSpeedList")]
        [Validation(Required=false)]
        public List<AdjustPtsSceneSpeedRequestApiSpeedList> ApiSpeedList { get; set; }
        public class AdjustPtsSceneSpeedRequestApiSpeedList : TeaModel {
            /// <summary>
            /// <para>The API ID. You can find the information of the API corresponding to the ID in the Relation response parameter of the GetPtsSceneRunningData operation based on the ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DYXXX12H</para>
            /// </summary>
            [NameInMap("ApiId")]
            [Validation(Required=false)]
            public string ApiId { get; set; }

            /// <summary>
            /// <para>The new stress. In concurrency mode, the new stress is the concurrency. In RPS mode, the new stress is the RPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Speed")]
            [Validation(Required=false)]
            public long? Speed { get; set; }

        }

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
