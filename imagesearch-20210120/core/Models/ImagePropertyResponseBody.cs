// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20210120.Models
{
    public class ImagePropertyResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ImagePropertyResponseBodyData Data { get; set; }
        public class ImagePropertyResponseBodyData : TeaModel {
            [NameInMap("PropertyResults")]
            [Validation(Required=false)]
            public List<ImagePropertyResponseBodyDataPropertyResults> PropertyResults { get; set; }
            public class ImagePropertyResponseBodyDataPropertyResults : TeaModel {
                public string PropertyId { get; set; }
                public string PropertyName { get; set; }
                public List<ImagePropertyResponseBodyDataPropertyResultsValues> Values { get; set; }
                public class ImagePropertyResponseBodyDataPropertyResultsValues : TeaModel {
                    public float? Probability { get; set; }
                    public string ValueId { get; set; }
                    public string ValueName { get; set; }
                }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
