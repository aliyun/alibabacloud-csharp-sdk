// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class UpdateTensorboardRequest : TeaModel {
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MaxRunningTimeMinutes</para>
        /// </summary>
        [NameInMap("MaxRunningTimeMinutes")]
        [Validation(Required=false)]
        public long? MaxRunningTimeMinutes { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>380</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
