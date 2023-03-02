// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetOpRiskDataResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information of the risky sensitive data returned. The information includes totalCount and opRiskDatas.
        /// 
        /// opRiskDatas includes the following parameters:
        /// 
        /// *   sensType: the type of the sensitive data
        /// *   sensLevel: the sensitivity level of the sensitive data
        /// *   opType: the type of the operation
        /// *   sql: the SQL statement that is executed
        /// *   opAccount: the account that is used to perform the operation
        /// *   opTime: the time when the operation was performed
        /// </summary>
        [NameInMap("RiskData")]
        [Validation(Required=false)]
        public string RiskData { get; set; }

    }

}
