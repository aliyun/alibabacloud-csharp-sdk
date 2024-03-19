// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class UploadRecommendationDataRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public List<UploadRecommendationDataRequestContent> Content { get; set; }
        public class UploadRecommendationDataRequestContent : TeaModel {
            [NameInMap("Fields")]
            [Validation(Required=false)]
            public string Fields { get; set; }

            [NameInMap("OperationType")]
            [Validation(Required=false)]
            public string OperationType { get; set; }

        }

        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

    }

}
