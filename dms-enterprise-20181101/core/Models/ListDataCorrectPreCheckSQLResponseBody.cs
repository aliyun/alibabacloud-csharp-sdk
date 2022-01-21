// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListDataCorrectPreCheckSQLResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("PreCheckSQLList")]
        [Validation(Required=false)]
        public List<ListDataCorrectPreCheckSQLResponseBodyPreCheckSQLList> PreCheckSQLList { get; set; }
        public class ListDataCorrectPreCheckSQLResponseBodyPreCheckSQLList : TeaModel {
            [NameInMap("AffectRows")]
            [Validation(Required=false)]
            public long? AffectRows { get; set; }

            [NameInMap("CheckSQL")]
            [Validation(Required=false)]
            public string CheckSQL { get; set; }

            [NameInMap("DbId")]
            [Validation(Required=false)]
            public long? DbId { get; set; }

            [NameInMap("SQLReviewQueryKey")]
            [Validation(Required=false)]
            public string SQLReviewQueryKey { get; set; }

            [NameInMap("SqlReviewStatus")]
            [Validation(Required=false)]
            public string SqlReviewStatus { get; set; }

            [NameInMap("SqlType")]
            [Validation(Required=false)]
            public string SqlType { get; set; }

            [NameInMap("TableNames")]
            [Validation(Required=false)]
            public string TableNames { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
