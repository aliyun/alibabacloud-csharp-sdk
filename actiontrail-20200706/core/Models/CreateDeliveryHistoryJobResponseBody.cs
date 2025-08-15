// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class CreateDeliveryHistoryJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the historical event delivery task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16602</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public int? JobId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9D356A34-D5A9-41CD-9915-837B7F9D8722</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
