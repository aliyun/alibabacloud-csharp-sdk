/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Composer20181212.Models
{
    public class CloneFlowRequest : TeaModel {
        /// <summary>
        /// The ID of the workflow that you want to clone.
        /// </summary>
        [NameInMap("FlowId")]
        [Validation(Required=false)]
        public string FlowId { get; set; }

        /// <summary>
        /// The version of the workflow that you want to clone. If you do not specify this parameter, the latest version of the workflow is cloned.
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
