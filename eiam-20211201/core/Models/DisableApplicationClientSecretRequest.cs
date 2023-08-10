// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class DisableApplicationClientSecretRequest : TeaModel {
        /// <summary>
        /// The ID of the application for which you want to disable a client key.
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The client key ID of the application.
        /// </summary>
        [NameInMap("SecretId")]
        [Validation(Required=false)]
        public string SecretId { get; set; }

    }

}
