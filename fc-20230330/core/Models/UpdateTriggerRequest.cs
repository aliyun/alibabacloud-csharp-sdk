// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class UpdateTriggerRequest : TeaModel {
        /// <summary>
        /// <para>The trigger configurations.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateTriggerInput Body { get; set; }

    }

}
