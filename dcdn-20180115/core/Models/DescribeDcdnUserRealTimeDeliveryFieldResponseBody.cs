// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserRealTimeDeliveryFieldResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public DescribeDcdnUserRealTimeDeliveryFieldResponseBodyContent Content { get; set; }
        public class DescribeDcdnUserRealTimeDeliveryFieldResponseBodyContent : TeaModel {
            [NameInMap("Fields")]
            [Validation(Required=false)]
            public List<DescribeDcdnUserRealTimeDeliveryFieldResponseBodyContentFields> Fields { get; set; }
            public class DescribeDcdnUserRealTimeDeliveryFieldResponseBodyContentFields : TeaModel {
                /// <summary>
                /// The description of the field.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The name of the field.
                /// </summary>
                [NameInMap("FieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                /// <summary>
                /// Indicates whether the field was selected.
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("Selected")]
                [Validation(Required=false)]
                public bool? Selected { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
