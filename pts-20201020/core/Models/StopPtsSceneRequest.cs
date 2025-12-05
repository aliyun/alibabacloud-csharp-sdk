// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class StopPtsSceneRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the scenario that you want to stop, which is the ID that is returned after the scenario is created. You can view scenario IDs on the scenario list page in the PTS console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GV4DEBG</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

    }

}
