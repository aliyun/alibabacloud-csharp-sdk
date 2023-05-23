// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20220112.Models
{
    public class GetAlgorithmResponseBody : TeaModel {
        /// <summary>
        /// 返回数据。
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAlgorithmResponseBodyData Data { get; set; }
        public class GetAlgorithmResponseBodyData : TeaModel {
            /// <summary>
            /// 算法说明。
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 算法Id。
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// 预测所需参数名与对应的参数说明。
            /// </summary>
            [NameInMap("InferUserConfigMap")]
            [Validation(Required=false)]
            public string InferUserConfigMap { get; set; }

            /// <summary>
            /// 算法名称。
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 训练所需参数名与对应的参数说明。
            /// </summary>
            [NameInMap("TrainUserConfigMap")]
            [Validation(Required=false)]
            public string TrainUserConfigMap { get; set; }

        }

        /// <summary>
        /// 错误码。
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 错误信息。
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
