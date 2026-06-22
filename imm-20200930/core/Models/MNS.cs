// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class MNS : TeaModel {
        /// <summary>
        /// <para>Specifies the name of the ApsaraMQ for MNS topic, which can be found in the topic list for the current region in the left-side navigation pane of the <a href="https://mns.console.aliyun.com/">ApsaraMQ for MNS console</a>. This parameter is required for ApsaraMQ for MNS message notification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>topic1</para>
        /// </summary>
        [NameInMap("TopicName")]
        [Validation(Required=false)]
        public string TopicName { get; set; }

    }

}
