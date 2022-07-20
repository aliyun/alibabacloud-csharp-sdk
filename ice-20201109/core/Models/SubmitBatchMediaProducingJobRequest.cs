// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitBatchMediaProducingJobRequest : TeaModel {
        /// <summary>
        /// 调用方保证请求幂等性Client Token
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// 批量混剪ClipsParam
        /// </summary>
        [NameInMap("ClipsParam")]
        [Validation(Required=false)]
        public string ClipsParam { get; set; }

        /// <summary>
        /// 剪辑合成配置
        /// </summary>
        [NameInMap("EditingProduceConfig")]
        [Validation(Required=false)]
        public string EditingProduceConfig { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [NameInMap("JobTitle")]
        [Validation(Required=false)]
        public string JobTitle { get; set; }

        /// <summary>
        /// 用户合成输出配置
        /// </summary>
        [NameInMap("OutputMediaConfig")]
        [Validation(Required=false)]
        public string OutputMediaConfig { get; set; }

        /// <summary>
        /// 用户合成输出目标
        /// </summary>
        [NameInMap("OutputMediaTarget")]
        [Validation(Required=false)]
        public string OutputMediaTarget { get; set; }

        /// <summary>
        /// 批量混剪下合成成片的个数
        /// </summary>
        [NameInMap("OutputNum")]
        [Validation(Required=false)]
        public int? OutputNum { get; set; }

        /// <summary>
        /// 剪辑任务工程信息
        /// </summary>
        [NameInMap("ProjectMetadata")]
        [Validation(Required=false)]
        public string ProjectMetadata { get; set; }

        /// <summary>
        /// 任务来源
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// 提交任务类型
        /// </summary>
        [NameInMap("SubmitBy")]
        [Validation(Required=false)]
        public string SubmitBy { get; set; }

        /// <summary>
        /// 批量混剪模版id
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 用户配置UserData
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
