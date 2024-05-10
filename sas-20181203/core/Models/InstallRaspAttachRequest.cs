// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class InstallRaspAttachRequest : TeaModel {
        /// <summary>
        /// The application group ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// The UUIDs of ECS instances on which the RASP agent is to be installed.
        /// </summary>
        [NameInMap("EcsUUIDList")]
        [Validation(Required=false)]
        public List<string> EcsUUIDList { get; set; }

    }

}
