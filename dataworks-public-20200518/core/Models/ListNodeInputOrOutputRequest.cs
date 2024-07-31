// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListNodeInputOrOutputRequest : TeaModel {
        /// <summary>
        /// The type of node that you want to query. Valid values:
        /// 
        /// *   input: ancestor node
        /// *   output: descendant node
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
        /// The environment of the workspace. Valid values: DEV and PROD.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectEnv")]
        [Validation(Required=false)]
        public string ProjectEnv { get; set; }

    }

}
