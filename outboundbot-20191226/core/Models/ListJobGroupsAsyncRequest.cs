// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListJobGroupsAsyncRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6243d904-939d-42ce-a8e4-886a139e77a3</para>
        /// </summary>
        [NameInMap("AsyncTaskId")]
        [Validation(Required=false)]
        public string AsyncTaskId { get; set; }

    }

}
