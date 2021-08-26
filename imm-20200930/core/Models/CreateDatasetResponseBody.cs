// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateDatasetResponseBody : TeaModel {
        /// <summary>
        /// 请求 ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// 数据集名称
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// 数据集创建时间
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}
