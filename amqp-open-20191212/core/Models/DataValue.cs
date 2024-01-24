/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class DataValue : TeaModel {
        /// <summary>
        /// The Alibaba Cloud account ID or Resource Access Management (RAM) user to which the AccessKey pair that is used to create the static username and password belongs.
        /// </summary>
        [NameInMap("masterUid")]
        [Validation(Required=false)]
        public long? MasterUid { get; set; }

        /// <summary>
        /// The ID of the ApsaraMQ for RabbitMQ instance.
        /// </summary>
        [NameInMap("cInstanceId")]
        [Validation(Required=false)]
        public string CInstanceId { get; set; }

        /// <summary>
        /// The AccessKey ID that is used to create the static username and password.
        /// </summary>
        [NameInMap("accessKey")]
        [Validation(Required=false)]
        public string AccessKey { get; set; }

        /// <summary>
        /// The static username.
        /// </summary>
        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// The static password.
        /// </summary>
        [NameInMap("password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// The timestamp that indicates when the static username and password were deleted. Unit: milliseconds.
        /// </summary>
        [NameInMap("deleted")]
        [Validation(Required=false)]
        public long? Deleted { get; set; }

        /// <summary>
        /// The timestamp that indicates when the static username and password were created. Unit: milliseconds.
        /// </summary>
        [NameInMap("createTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

    }

}
