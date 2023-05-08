// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCloudAssetCriteriaResponseBody : TeaModel {
        /// <summary>
        /// The values of the search condition. This parameter is returned only if the value of **Type** is **select**.
        /// 
        /// >  If the value of **Type** is **input**, the value of this parameter is an empty string.
        /// </summary>
        [NameInMap("CriteriaList")]
        [Validation(Required=false)]
        public List<GetCloudAssetCriteriaResponseBodyCriteriaList> CriteriaList { get; set; }
        public class GetCloudAssetCriteriaResponseBodyCriteriaList : TeaModel {
            [NameInMap("MultiValues")]
            [Validation(Required=false)]
            public string MultiValues { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// GetCloudAssetCriteria
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Values")]
            [Validation(Required=false)]
            public string Values { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
