// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListFeedbacksRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;20251216-8B9B7B02-16FE-54BE-942A-F59DE0656032&quot;]</para>
        /// </summary>
        [NameInMap("TaskIdList")]
        [Validation(Required=false)]
        public string TaskIdList { get; set; }

    }

}
