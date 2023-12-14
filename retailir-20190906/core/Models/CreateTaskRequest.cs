/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailir20190906.Models
{
    public class CreateTaskRequest : TeaModel {
        [NameInMap("Appkey")]
        [Validation(Required=false)]
        public string Appkey { get; set; }

        [NameInMap("ImageLeftBottom")]
        [Validation(Required=false)]
        public string ImageLeftBottom { get; set; }

        [NameInMap("ImageLeftTop")]
        [Validation(Required=false)]
        public string ImageLeftTop { get; set; }

        [NameInMap("ImageList")]
        [Validation(Required=false)]
        public List<CreateTaskRequestImageList> ImageList { get; set; }
        public class CreateTaskRequestImageList : TeaModel {
            [NameInMap("FileLink")]
            [Validation(Required=false)]
            public string FileLink { get; set; }

            [NameInMap("Xaxis")]
            [Validation(Required=false)]
            public int? Xaxis { get; set; }

            [NameInMap("Yaxis")]
            [Validation(Required=false)]
            public int? Yaxis { get; set; }

        }

        [NameInMap("ImageMiddleBottom")]
        [Validation(Required=false)]
        public string ImageMiddleBottom { get; set; }

        [NameInMap("ImageMiddleTop")]
        [Validation(Required=false)]
        public string ImageMiddleTop { get; set; }

        [NameInMap("ImageRightBottom")]
        [Validation(Required=false)]
        public string ImageRightBottom { get; set; }

        [NameInMap("ImageRightTop")]
        [Validation(Required=false)]
        public string ImageRightTop { get; set; }

        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
