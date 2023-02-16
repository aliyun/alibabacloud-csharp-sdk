// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class DesignateWorkersRequest : TeaModel {
        /// <summary>
        /// The type of the designated machines. Valid values: 1: worker. 2: label.
        /// </summary>
        [NameInMap("DesignateType")]
        [Validation(Required=false)]
        public int? DesignateType { get; set; }

        /// <summary>
        /// The ID of the application group.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The ID of the job.
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

        /// <summary>
        /// The designated `labels`. The value is a `JSON` string.
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// The ID of the namespace.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The source of the namespace.
        /// </summary>
        [NameInMap("NamespaceSource")]
        [Validation(Required=false)]
        public string NamespaceSource { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies whether to allow a failover.
        /// </summary>
        [NameInMap("Transferable")]
        [Validation(Required=false)]
        public bool? Transferable { get; set; }

        /// <summary>
        /// The designated workers. The value is a JSON string.
        /// </summary>
        [NameInMap("Workers")]
        [Validation(Required=false)]
        public string Workers { get; set; }

    }

}
