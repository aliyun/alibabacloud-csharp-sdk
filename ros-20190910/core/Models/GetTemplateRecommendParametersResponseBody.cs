// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetTemplateRecommendParametersResponseBody : TeaModel {
        [NameInMap("RecommendParameterValues")]
        [Validation(Required=false)]
        public List<GetTemplateRecommendParametersResponseBodyRecommendParameterValues> RecommendParameterValues { get; set; }
        public class GetTemplateRecommendParametersResponseBodyRecommendParameterValues : TeaModel {
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            [NameInMap("RecommendValue")]
            [Validation(Required=false)]
            public string RecommendValue { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
