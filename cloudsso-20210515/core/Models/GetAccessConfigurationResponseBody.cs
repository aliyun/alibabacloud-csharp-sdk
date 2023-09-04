// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetAccessConfigurationResponseBody : TeaModel {
        /// <summary>
        /// The information about the access configuration.
        /// </summary>
        [NameInMap("AccessConfiguration")]
        [Validation(Required=false)]
        public GetAccessConfigurationResponseBodyAccessConfiguration AccessConfiguration { get; set; }
        public class GetAccessConfigurationResponseBodyAccessConfiguration : TeaModel {
            /// <summary>
            /// The ID of the access configuration.
            /// </summary>
            [NameInMap("AccessConfigurationId")]
            [Validation(Required=false)]
            public string AccessConfigurationId { get; set; }

            /// <summary>
            /// The name of the access configuration.
            /// </summary>
            [NameInMap("AccessConfigurationName")]
            [Validation(Required=false)]
            public string AccessConfigurationName { get; set; }

            /// <summary>
            /// The time when the access configuration was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The description of the access configuration.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The initial web page that is displayed after a CloudSSO user accesses an account in your resource directory by using the access configuration.
            /// </summary>
            [NameInMap("RelayState")]
            [Validation(Required=false)]
            public string RelayState { get; set; }

            /// <summary>
            /// The duration of a session in which a CloudSSO user accesses an account in your resource directory by using the access configuration.
            /// 
            /// Unit: seconds.
            /// </summary>
            [NameInMap("SessionDuration")]
            [Validation(Required=false)]
            public int? SessionDuration { get; set; }

            /// <summary>
            /// The status notification.
            /// </summary>
            [NameInMap("StatusNotifications")]
            [Validation(Required=false)]
            public List<string> StatusNotifications { get; set; }

            /// <summary>
            /// The time when the information about the access configuration was modified.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
