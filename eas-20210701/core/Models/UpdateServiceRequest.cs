// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateServiceRequest : TeaModel {
        /// <summary>
        /// The type of the service update. Valid values: merge and replace. By default, merge is used if you do not specify this parameter.
        /// 
        /// *   merge: If the JSON string configured for the existing service is `{"a":"b"}` and the JSON string specified in the body parameter is `{"c":"d"}`, the JSON string is `{"a":"b","c":"d"}` after the service update.
        /// *   replace: If the JSON string configured for the existing service is `{"a":"b"}` and the JSON string specified in the body parameter is `{"c":"d"}`, the JSON string is `{"c":"d"}` after the service update.
        /// </summary>
        [NameInMap("UpdateType")]
        [Validation(Required=false)]
        public string UpdateType { get; set; }

        /// <summary>
        /// The request body. The body includes the request parameters that you want to update. For more information about the request parameters, see [CreateService](https://help.aliyun.com/document_detail/412086.html).
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

    }

}
