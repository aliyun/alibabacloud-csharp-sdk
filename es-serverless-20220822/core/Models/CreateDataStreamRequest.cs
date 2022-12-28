// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Es_serverless20220822.Models
{
    public class CreateDataStreamRequest : TeaModel {
        /// <summary>
        /// 代表资源名称的资源属性字段
        /// </summary>
        [NameInMap("dataStreamName")]
        [Validation(Required=false)]
        public string DataStreamName { get; set; }

        /// <summary>
        /// 删除时间
        /// </summary>
        [NameInMap("deletePhase")]
        [Validation(Required=false)]
        public string DeletePhase { get; set; }

        [NameInMap("dynamic")]
        [Validation(Required=false)]
        public string Dynamic { get; set; }

        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// 数据流模板
        /// </summary>
        [NameInMap("template")]
        [Validation(Required=false)]
        public CreateDataStreamRequestTemplate Template { get; set; }
        public class CreateDataStreamRequestTemplate : TeaModel {
            /// <summary>
            /// 索引字段设置
            /// </summary>
            [NameInMap("mappings")]
            [Validation(Required=false)]
            public List<DataStreamMapping> Mappings { get; set; }

        }

        [NameInMap("timeStampKey")]
        [Validation(Required=false)]
        public string TimeStampKey { get; set; }

        /// <summary>
        /// 数据流类型
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
