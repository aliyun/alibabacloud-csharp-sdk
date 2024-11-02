// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class TriggerPlaybookResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BD5A8DB6-A42C-532B-BCE8-83E69550CD59</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The running UUID of the playbook. This parameter is used to query the running result of the playbook.</para>
        /// 
        /// <b>Example:</b>
        /// <para>55E63C57-D6C8-5036-A770-5CB10AC807AA</para>
        /// </summary>
        [NameInMap("TriggerUuid")]
        [Validation(Required=false)]
        public string TriggerUuid { get; set; }

    }

}
