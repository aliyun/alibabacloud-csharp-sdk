// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class CreateBodyInstanceResponseBody : TeaModel {
        /// <summary>
        /// RequestId
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 实例id
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateBodyInstanceResponseBodyData Data { get; set; }
        public class CreateBodyInstanceResponseBodyData : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long Id { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
