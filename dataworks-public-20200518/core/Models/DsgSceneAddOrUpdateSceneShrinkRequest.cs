// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgSceneAddOrUpdateSceneShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The information about the level-2 data masking scenario.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("scenes")]
        [Validation(Required=false)]
        public string ScenesShrink { get; set; }

    }

}
