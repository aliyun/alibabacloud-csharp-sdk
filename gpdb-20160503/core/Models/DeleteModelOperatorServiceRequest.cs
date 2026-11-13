// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DeleteModelOperatorServiceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the model operator service to be released. You can obtain the ID by calling ListModelOperatorServices. The service must belong to the current account and the requested region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adbpg-mo-123456789abc</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

    }

}
