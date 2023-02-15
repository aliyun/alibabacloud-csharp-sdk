// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeQrCodeAdvanceRequest : TeaModel {
        /// <summary>
        /// 1
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<RecognizeQrCodeAdvanceRequestTasks> Tasks { get; set; }
        public class RecognizeQrCodeAdvanceRequestTasks : TeaModel {
            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public Stream ImageURLObject { get; set; }

        }

    }

}
