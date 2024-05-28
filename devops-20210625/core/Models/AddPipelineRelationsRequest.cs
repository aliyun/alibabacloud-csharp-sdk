// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class AddPipelineRelationsRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("relObjectIds")]
        [Validation(Required=false)]
        public string RelObjectIds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("relObjectType")]
        [Validation(Required=false)]
        public string RelObjectType { get; set; }

    }

}
