// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class GetLogQueryConditionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DbUserList")]
        [Validation(Required=false)]
        public List<string> DbUserList { get; set; }

        [NameInMap("ClientIpList")]
        [Validation(Required=false)]
        public List<string> ClientIpList { get; set; }

        [NameInMap("ClientProgramList")]
        [Validation(Required=false)]
        public List<string> ClientProgramList { get; set; }

        [NameInMap("DbServerList")]
        [Validation(Required=false)]
        public List<string> DbServerList { get; set; }

        [NameInMap("SqlTypeList")]
        [Validation(Required=false)]
        public List<GetLogQueryConditionResponseBodySqlTypeList> SqlTypeList { get; set; }
        public class GetLogQueryConditionResponseBodySqlTypeList : TeaModel {
            [NameInMap("SqlKeyword")]
            [Validation(Required=false)]
            public string SqlKeyword { get; set; }

            [NameInMap("SqlType")]
            [Validation(Required=false)]
            public string SqlType { get; set; }

        }

    }

}
