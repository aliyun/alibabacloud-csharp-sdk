// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DeleteRemindRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the custom alert rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("RemindId")]
        [Validation(Required=false)]
        public long? RemindId { get; set; }

    }

}
