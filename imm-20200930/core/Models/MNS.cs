// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class MNS : TeaModel {
        /// <summary>
        /// <para>The SMQ topic. You can check topics within a region in the <a href="https://mns.console.aliyun.com/">SMQ console</a>. This parameter is required if you want to use SMQ for notifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>topic1</para>
        /// </summary>
        [NameInMap("TopicName")]
        [Validation(Required=false)]
        public string TopicName { get; set; }

    }

}
