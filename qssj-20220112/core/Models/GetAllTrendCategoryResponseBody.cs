// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qssj20220112.Models
{
    public class GetAllTrendCategoryResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetAllTrendCategoryResponseBodyData> Data { get; set; }
        public class GetAllTrendCategoryResponseBodyData : TeaModel {
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public long? CategoryId { get; set; }

            [NameInMap("CategoryLevel")]
            [Validation(Required=false)]
            public int? CategoryLevel { get; set; }

            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            [NameInMap("ChildCategory")]
            [Validation(Required=false)]
            public List<object> ChildCategory { get; set; }

            [NameInMap("SuperCategoryName")]
            [Validation(Required=false)]
            public string SuperCategoryName { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SuccessResponse")]
        [Validation(Required=false)]
        public bool? SuccessResponse { get; set; }

    }

}
