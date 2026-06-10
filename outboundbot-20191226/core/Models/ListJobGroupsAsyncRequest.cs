// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListJobGroupsAsyncRequest : TeaModel {
        /// <summary>
        /// <para>The ID returned by an asynchronous call to <c>ListJobGroup</c>. Use this ID to retrieve the results of the asynchronous query.</para>
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
