// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class CopyGtmConfigRequest : TeaModel {
        /// <summary>
        /// The type of the object that you want to copy. Only the INSTANCE type is supported.
        /// </summary>
        [NameInMap("CopyType")]
        [Validation(Required=false)]
        public string CopyType { get; set; }

        /// <summary>
        /// The language that specific response parameters will use.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The ID of the source object. Only instance IDs are supported.
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// The ID of the target object. Only instance IDs are supported.
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

    }

}
