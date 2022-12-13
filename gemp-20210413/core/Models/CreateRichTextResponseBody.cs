// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CreateRichTextResponseBody : TeaModel {
        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateRichTextResponseBodyData Data { get; set; }
        public class CreateRichTextResponseBodyData : TeaModel {
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            [NameInMap("instanceType")]
            [Validation(Required=false)]
            public long? InstanceType { get; set; }

            [NameInMap("richText")]
            [Validation(Required=false)]
            public string RichText { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
