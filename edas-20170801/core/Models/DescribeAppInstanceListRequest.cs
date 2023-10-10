// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class DescribeAppInstanceListRequest : TeaModel {
        /// <summary>
        /// The ID of the application. You can call the ListApplication operation to query the ID of the application. For more information, see [ListApplication](~~149390~~).
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// Specifies whether to return the information about the node in which the pod resides.
        /// 
        /// *   `true`: returns the information about the node in which the pod resides
        /// *   `false`: does not return the information about the node in which the pod resides
        /// </summary>
        [NameInMap("WithNodeInfo")]
        [Validation(Required=false)]
        public bool? WithNodeInfo { get; set; }

    }

}
