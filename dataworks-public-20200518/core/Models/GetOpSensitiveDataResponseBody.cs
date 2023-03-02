// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetOpSensitiveDataResponseBody : TeaModel {
        /// <summary>
        /// The information of the access records returned for the sensitive data. The information includes totalCount and opRiskDatas.
        /// 
        /// opRiskDatas includes the following parameters:
        /// 
        /// *   sensType: indicates the type of the sensitive data.
        /// *   sensLevel: indicates the sensitivity level of the sensitive data. A larger value of sensLevel indicates a higher sensitivity level.
        /// *   opType: indicates the type of the operation.
        /// *   sql: indicates the SQL statement that is executed.
        /// *   opAccount: indicates the account that is used to perform the operation.
        /// *   opTime: indicates the time when the operation was performed.
        /// </summary>
        [NameInMap("OpSensitiveData")]
        [Validation(Required=false)]
        public string OpSensitiveData { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
