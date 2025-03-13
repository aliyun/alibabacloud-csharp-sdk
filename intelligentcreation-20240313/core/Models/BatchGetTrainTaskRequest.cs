// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class BatchGetTrainTaskRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1524004782431111</para>
        /// </summary>
        [NameInMap("aliyunMainId")]
        [Validation(Required=false)]
        public string AliyunMainId { get; set; }

        [NameInMap("taskIdList")]
        [Validation(Required=false)]
        public List<string> TaskIdList { get; set; }

    }

}
