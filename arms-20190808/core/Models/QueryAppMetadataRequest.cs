// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class QueryAppMetadataRequest : TeaModel {
        /// <summary>
        /// The list of metadata IDs. Separate multiple IDs with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MetaIds")]
        [Validation(Required=false)]
        public string MetaIds { get; set; }

        /// <summary>
        /// The metadata type. Valid values: sql: obtains an SQL statement based on sqlId exception: obtains the exception stack based on exceptionId
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MetaType")]
        [Validation(Required=false)]
        public string MetaType { get; set; }

        /// <summary>
        /// The process identifier (PID) of the application. For more information about how to obtain the PID, see "Obtain the PID of an application."
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        /// <summary>
        /// The region ID. Default value: cn-hangzhou.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
