// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class CreateOmsOpenAPIProjectShrinkRequest : TeaModel {
        [NameInMap("BusinessName")]
        [Validation(Required=false)]
        public string BusinessName { get; set; }

        [NameInMap("DestConfig")]
        [Validation(Required=false)]
        public string DestConfigShrink { get; set; }

        [NameInMap("LabelIds")]
        [Validation(Required=false)]
        public string LabelIdsShrink { get; set; }

        /// <summary>
        /// 页序号，分页查询时生效
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 页大小，分页查询时生效
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("SourceConfig")]
        [Validation(Required=false)]
        public string SourceConfigShrink { get; set; }

        [NameInMap("TransferMapping")]
        [Validation(Required=false)]
        public string TransferMappingShrink { get; set; }

        [NameInMap("TransferStepConfig")]
        [Validation(Required=false)]
        public string TransferStepConfigShrink { get; set; }

        /// <summary>
        /// 实例规格 ID，创建项目时生效
        /// </summary>
        [NameInMap("WorkerGradeId")]
        [Validation(Required=false)]
        public string WorkerGradeId { get; set; }

    }

}
