// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgQueryDefaultTemplatesRequest : TeaModel {
        /// <summary>
        /// The ID of the level-2 data masking scenario. You can call the [DsgSceneQuerySceneListByName](https://help.aliyun.com/document_detail/2786322.html) operation to query the list of IDs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public int? SceneId { get; set; }

    }

}
