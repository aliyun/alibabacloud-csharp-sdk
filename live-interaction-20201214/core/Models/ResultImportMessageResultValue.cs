// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class ResultImportMessageResultValue : TeaModel {
        /// <summary>
        /// 0 成功
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public long? Result { get; set; }

        /// <summary>
        /// 消息ID
        /// </summary>
        [NameInMap("msgId")]
        [Validation(Required=false)]
        public string MsgId { get; set; }

    }

}
