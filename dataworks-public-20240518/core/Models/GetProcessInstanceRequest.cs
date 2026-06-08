// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetProcessInstanceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>332066440109224007</para>
        /// </summary>
        [NameInMap("ProcessInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

    }

}
