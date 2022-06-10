// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CreateConnQuestionResponseBody : TeaModel {
        /// <summary>
        /// 关联关系ID
        /// </summary>
        [NameInMap("OutlineId")]
        [Validation(Required=false)]
        public long? OutlineId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
