// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ModifyLogConfigRequest : TeaModel {
        [NameInMap("LogType")]
        [Validation(Required=false)]
        public string LogType { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SlsLogStore")]
        [Validation(Required=false)]
        public string SlsLogStore { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SlsProject")]
        [Validation(Required=false)]
        public string SlsProject { get; set; }

    }

}
