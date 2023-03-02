// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetSensitiveDataResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information of the sensitive data returned. The information includes totalCount and sensDatas.
        /// 
        /// sensDatas includes the following parameters:
        /// 
        /// *   guid: the ID of the metadata of the tenant. For example, the ID of the metadata in the MaxCompute compute engine is in the Project name.Table name.Column name format.
        /// *   sensType: the type of the sensitive data.
        /// *   sensLevel: the sensitivity level of the sensitive data.
        /// </summary>
        [NameInMap("SensitiveData")]
        [Validation(Required=false)]
        public Dictionary<string, object> SensitiveData { get; set; }

    }

}
