// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteHoneypotPresetRequest : TeaModel {
        /// <summary>
        /// The ID of the honeypot template.
        /// 
        /// >  You can call the [ListHoneypotPreset](~~ListHoneypotPreset~~) operation to query the IDs of honeypot templates.
        /// </summary>
        [NameInMap("HoneypotPresetId")]
        [Validation(Required=false)]
        public string HoneypotPresetId { get; set; }

    }

}
