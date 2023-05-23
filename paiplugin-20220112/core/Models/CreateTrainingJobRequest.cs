// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20220112.Models
{
    public class CreateTrainingJobRequest : TeaModel {
        /// <summary>
        /// 关联算法ID。
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// 关联运营活动ID。
        /// </summary>
        [NameInMap("CampaignId")]
        [Validation(Required=false)]
        public string CampaignId { get; set; }

        /// <summary>
        /// 训练数据路径，指定路径前需确保已在控制台完成一键授权。
        /// </summary>
        [NameInMap("DataPath")]
        [Validation(Required=false)]
        public string DataPath { get; set; }

        /// <summary>
        /// 训练任务名称。
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 备注。
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// 用户配置。
        /// </summary>
        [NameInMap("UserConfig")]
        [Validation(Required=false)]
        public string UserConfig { get; set; }

    }

}
