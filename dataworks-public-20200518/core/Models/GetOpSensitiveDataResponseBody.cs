// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetOpSensitiveDataResponseBody : TeaModel {
        /// <summary>
        /// The information about the access records of the sensitive data. The information includes totalCount and opRiskDatas. opRiskDatas includes the following parameters:
        /// 
        /// *   sensType: the type of the sensitive data.
        /// *   sensLevel: the sensitivity level of the sensitive data. A larger value indicates a higher sensitivity level.
        /// *   opType: the type of the operation.
        /// *   sql: the SQL statement that is executed.
        /// *   opAccount: the account that is used to perform the operation.
        /// *   opTime: the time when the operation was performed.
        /// </summary>
        [NameInMap("OpSensitiveData")]
        [Validation(Required=false)]
        public string OpSensitiveData { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
