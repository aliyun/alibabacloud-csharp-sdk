// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class SavePtsSceneShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The information about the scenario.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string SceneShrink { get; set; }

    }

}
