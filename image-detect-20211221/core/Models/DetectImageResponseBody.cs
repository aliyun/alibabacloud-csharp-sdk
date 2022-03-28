// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Image_detect20211221.Models
{
    public class DetectImageResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Response")]
        [Validation(Required=false)]
        public DetectImageResponseBodyResponse Response { get; set; }
        public class DetectImageResponseBodyResponse : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public DetectImageResponseBodyResponseData Data { get; set; }
            public class DetectImageResponseBodyResponseData : TeaModel {
                [NameInMap("Info")]
                [Validation(Required=false)]
                public DetectImageResponseBodyResponseDataInfo Info { get; set; }
                public class DetectImageResponseBodyResponseDataInfo : TeaModel {
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }
                    [NameInMap("Conf")]
                    [Validation(Required=false)]
                    public double? Conf { get; set; }
                    [NameInMap("Direction")]
                    [Validation(Required=false)]
                    public string Direction { get; set; }
                    [NameInMap("Well")]
                    [Validation(Required=false)]
                    public string Well { get; set; }
                };

                [NameInMap("Results")]
                [Validation(Required=false)]
                public List<DetectImageResponseBodyResponseDataResults> Results { get; set; }
                public class DetectImageResponseBodyResponseDataResults : TeaModel {
                    [NameInMap("CategoryList")]
                    [Validation(Required=false)]
                    public List<string> CategoryList { get; set; }

                    [NameInMap("ConfList")]
                    [Validation(Required=false)]
                    public List<double?> ConfList { get; set; }

                    [NameInMap("Direction")]
                    [Validation(Required=false)]
                    public string Direction { get; set; }

                    [NameInMap("Rect")]
                    [Validation(Required=false)]
                    public List<double?> Rect { get; set; }

                    [NameInMap("TaskType")]
                    [Validation(Required=false)]
                    public string TaskType { get; set; }

                }

            }
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public int? ErrorCode { get; set; }
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }
            [NameInMap("Flag")]
            [Validation(Required=false)]
            public bool? Flag { get; set; }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
