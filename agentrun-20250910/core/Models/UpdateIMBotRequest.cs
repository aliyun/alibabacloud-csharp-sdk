// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class UpdateIMBotRequest : TeaModel {
        /// <summary>
        /// <para>Contains the configuration details to update for the IM bot.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateIMBotInput Body { get; set; }

    }

}
