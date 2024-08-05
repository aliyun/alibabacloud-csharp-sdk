// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListFeatureConsistencyCheckJobFeatureReportsRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("LogItemId")]
        [Validation(Required=false)]
        public string LogItemId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("LogRequestId")]
        [Validation(Required=false)]
        public string LogRequestId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("LogUserId")]
        [Validation(Required=false)]
        public string LogUserId { get; set; }

    }

}
