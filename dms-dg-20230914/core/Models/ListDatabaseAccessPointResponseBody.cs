// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_dg20230914.Models
{
    public class ListDatabaseAccessPointResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("DbInstanceAccessPointList")]
        [Validation(Required=false)]
        public List<ListDatabaseAccessPointResponseBodyDbInstanceAccessPointList> DbInstanceAccessPointList { get; set; }
        public class ListDatabaseAccessPointResponseBodyDbInstanceAccessPointList : TeaModel {
            [NameInMap("AccessAddr")]
            [Validation(Required=false)]
            public string AccessAddr { get; set; }

            [NameInMap("AccessPort")]
            [Validation(Required=false)]
            public int? AccessPort { get; set; }

            [NameInMap("DbInstanceId")]
            [Validation(Required=false)]
            public string DbInstanceId { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("RouterId")]
            [Validation(Required=false)]
            public string RouterId { get; set; }

            [NameInMap("VpcAzoneId")]
            [Validation(Required=false)]
            public string VpcAzoneId { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

        }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
