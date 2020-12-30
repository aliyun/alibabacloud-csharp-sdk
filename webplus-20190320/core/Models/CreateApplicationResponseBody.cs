// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebPlus20190320.Models
{
    public class CreateApplicationResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Application")]
        [Validation(Required=false)]
        public CreateApplicationResponseBodyApplication Application { get; set; }
        public class CreateApplicationResponseBodyApplication : TeaModel {
            [NameInMap("CreateUsername")]
            [Validation(Required=false)]
            public string CreateUsername { get; set; }
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }
            [NameInMap("UpdateUsername")]
            [Validation(Required=false)]
            public string UpdateUsername { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }
            [NameInMap("UsingSharedStorage")]
            [Validation(Required=false)]
            public bool? UsingSharedStorage { get; set; }
            [NameInMap("AppDescription")]
            [Validation(Required=false)]
            public string AppDescription { get; set; }
        };

    }

}
