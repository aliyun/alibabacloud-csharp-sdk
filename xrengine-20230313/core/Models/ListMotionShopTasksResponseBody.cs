// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.XrEngine20230313.Models
{
    public class ListMotionShopTasksResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Current")]
        [Validation(Required=false)]
        public int? Current { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListMotionShopTasksResponseBodyData> Data { get; set; }
        public class ListMotionShopTasksResponseBodyData : TeaModel {
            [NameInMap("Material")]
            [Validation(Required=false)]
            public ListMotionShopTasksResponseBodyDataMaterial Material { get; set; }
            public class ListMotionShopTasksResponseBodyDataMaterial : TeaModel {
                [NameInMap("AvatarId")]
                [Validation(Required=false)]
                public string AvatarId { get; set; }

                [NameInMap("Box")]
                [Validation(Required=false)]
                public List<double?> Box { get; set; }

                [NameInMap("CoverUrl")]
                [Validation(Required=false)]
                public string CoverUrl { get; set; }

            }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public ListMotionShopTasksResponseBodyDataResult Result { get; set; }
            public class ListMotionShopTasksResponseBodyDataResult : TeaModel {
                [NameInMap("CoverUrl")]
                [Validation(Required=false)]
                public string CoverUrl { get; set; }

                [NameInMap("ShareUrl")]
                [Validation(Required=false)]
                public string ShareUrl { get; set; }

                [NameInMap("VideoUrl")]
                [Validation(Required=false)]
                public string VideoUrl { get; set; }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Pages")]
        [Validation(Required=false)]
        public int? Pages { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
