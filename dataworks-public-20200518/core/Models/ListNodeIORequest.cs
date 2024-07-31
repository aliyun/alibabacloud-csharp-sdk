// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListNodeIORequest : TeaModel {
        /// <summary>
        /// Specifies whether to query the information about ancestor or descendant nodes of the current node. Valid values: input and output.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IoType")]
        [Validation(Required=false)]
        public string IoType { get; set; }

        /// <summary>
        /// The node ID. You can call the [ListNodes](https://help.aliyun.com/document_detail/173979.html) operation to query the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public long? NodeId { get; set; }

        /// <summary>
        /// The runtime environment. Valid values: DEV and PROD.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectEnv")]
        [Validation(Required=false)]
        public string ProjectEnv { get; set; }

    }

}
