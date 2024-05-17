// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class DesignateWorkersRequest : TeaModel {
        /// <summary>
        /// The type of the machines to be designated. Valid values: 1 and 2. The value 1 specifies the worker type. The value 2 specifies the label type.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DesignateType")]
        [Validation(Required=false)]
        public int? DesignateType { get; set; }

        /// <summary>
        /// The application group ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The job ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

        /// <summary>
        /// The designated `labels`. Specify the value of the parameter in a `JSON` string.
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// The unique identifier (UID) of the namespace.
        /// 
        /// This parameter is required.
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
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies whether to allow a failover.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Transferable")]
        [Validation(Required=false)]
        public bool? Transferable { get; set; }

        /// <summary>
        /// The designated machines. Specify the value of the parameter in a JSON string.
        /// </summary>
        [NameInMap("Workers")]
        [Validation(Required=false)]
        public string Workers { get; set; }

    }

}
