// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListNodesRequest : TeaModel {
        /// <summary>
        /// The IDs of the ECS instances.
        /// </summary>
        [NameInMap("ecsInstanceIds")]
        [Validation(Required=false)]
        public string EcsInstanceIds { get; set; }

        /// <summary>
        /// The name of the ECS instance.
        /// </summary>
        [NameInMap("ecsInstanceName")]
        [Validation(Required=false)]
        public string EcsInstanceName { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// The tags of the ECS instance. You must configure tagKey and tagValue.
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
