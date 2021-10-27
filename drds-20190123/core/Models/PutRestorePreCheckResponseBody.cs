// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class PutRestorePreCheckResponseBody : TeaModel {
        [NameInMap("PrecheckBackupResult")]
        [Validation(Required=false)]
        public PutRestorePreCheckResponseBodyPrecheckBackupResult PrecheckBackupResult { get; set; }
        public class PutRestorePreCheckResponseBodyPrecheckBackupResult : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public PutRestorePreCheckResponseBodyPrecheckBackupResultList List { get; set; }
            public class PutRestorePreCheckResponseBodyPrecheckBackupResultList : TeaModel {
                [NameInMap("List")]
                [Validation(Required=false)]
                public List<PutRestorePreCheckResponseBodyPrecheckBackupResultListList> List { get; set; }
                public class PutRestorePreCheckResponseBodyPrecheckBackupResultListList : TeaModel {
                    [NameInMap("CheckFailReason")]
                    [Validation(Required=false)]
                    public string CheckFailReason { get; set; }

                    [NameInMap("CheckItemContent")]
                    [Validation(Required=false)]
                    public string CheckItemContent { get; set; }

                    [NameInMap("CheckItemName")]
                    [Validation(Required=false)]
                    public string CheckItemName { get; set; }

                    [NameInMap("CheckResult")]
                    [Validation(Required=false)]
                    public string CheckResult { get; set; }

                    [NameInMap("ItemId")]
                    [Validation(Required=false)]
                    public long? ItemId { get; set; }

                    [NameInMap("Result")]
                    [Validation(Required=false)]
                    public bool? Result { get; set; }

                }

            }
            [NameInMap("Result")]
            [Validation(Required=false)]
            public bool? Result { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
