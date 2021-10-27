// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeDbListResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeDbListResponseBodyData> Data { get; set; }
        public class DescribeDbListResponseBodyData : TeaModel {
            [NameInMap("Accounts")]
            [Validation(Required=false)]
            public List<DescribeDbListResponseBodyDataAccounts> Accounts { get; set; }
            public class DescribeDbListResponseBodyDataAccounts : TeaModel {
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                [NameInMap("AccountPrivilege")]
                [Validation(Required=false)]
                public string AccountPrivilege { get; set; }

            }

            [NameInMap("CharacterSetName")]
            [Validation(Required=false)]
            public string CharacterSetName { get; set; }

            [NameInMap("DBDescription")]
            [Validation(Required=false)]
            public string DBDescription { get; set; }

            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            [NameInMap("DBName")]
            [Validation(Required=false)]
            public string DBName { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
