// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class UpdateABTestSceneRequest : TeaModel {
        /// <summary>
        /// The request body.
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public ABTestScene Body { get; set; }

        /// <summary>
        /// Specifies whether to perform a dry run. This parameter is only used to check whether the data source is valid. Valid values: true and false.
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
