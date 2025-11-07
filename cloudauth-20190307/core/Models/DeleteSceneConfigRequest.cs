// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DeleteSceneConfigRequest : TeaModel {
        /// <summary>
        /// <para>ID of the intent authentication configuration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>559</para>
        /// </summary>
        [NameInMap("sceneConfigId")]
        [Validation(Required=false)]
        public long? SceneConfigId { get; set; }

    }

}
