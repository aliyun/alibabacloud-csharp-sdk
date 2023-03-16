// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class TestNetworkConnectionResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request. You can locate logs and troubleshoot issues based on the ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true: The request was successful.
        /// *   false: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The information about the connectivity test.
        /// </summary>
        [NameInMap("TaskList")]
        [Validation(Required=false)]
        public TestNetworkConnectionResponseBodyTaskList TaskList { get; set; }
        public class TestNetworkConnectionResponseBodyTaskList : TeaModel {
            /// <summary>
            /// The reason why the data source and resource group failed the connectivity test. If data source and the resource group passed the connectivity test, this parameter is left empty.
            /// </summary>
            [NameInMap("ConnectMessage")]
            [Validation(Required=false)]
            public string ConnectMessage { get; set; }

            /// <summary>
            /// The result of the connectivity test. Valid values:
            /// 
            /// *   true: The data source and the resource group passed the connectivity test.
            /// *   false: The data source and the resource group failed the connectivity test. You can troubleshoot issues based on the ConnectMessage parameter.
            /// </summary>
            [NameInMap("ConnectStatus")]
            [Validation(Required=false)]
            public bool? ConnectStatus { get; set; }

        }

    }

}
