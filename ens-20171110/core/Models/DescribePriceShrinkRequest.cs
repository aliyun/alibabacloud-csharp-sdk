// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribePriceShrinkRequest : TeaModel {
        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public List<DescribePriceShrinkRequestDataDisk> DataDisk { get; set; }
        public class DescribePriceShrinkRequestDataDisk : TeaModel {
            /// <summary>
            /// 数据盘大小，单位GB。如果此字段不为空，则以此段为准。
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public DescribePriceShrinkRequestSystemDisk SystemDisk { get; set; }
        public class DescribePriceShrinkRequestSystemDisk : TeaModel {
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }
        };

        /// <summary>
        /// 如果DataDisk.1.Size为空且此字段不为空时的则以此字段为准
        /// </summary>
        [NameInMap("DataDisks")]
        [Validation(Required=false)]
        public string DataDisksShrink { get; set; }

        /// <summary>
        /// 节点ID。
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// 实列规格。
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// 带宽计费方式
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// 购买资源的时长，如果不指定PeriodUnit，则默认按月购买。目前只支持按Days和Month。如果PeriodUnit=Day时，Period仅可以3。如果PeriodUnit=Monthc时，则Period可以为1-9,12。
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// 查询云服务器ENS不同计费周期的价格。取值范围：
        /// Month（默认）：按月计费的价格单位。
        /// Day：按天计费的价格单位。
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// 数量。
        /// </summary>
        [NameInMap("Quantity")]
        [Validation(Required=false)]
        public int? Quantity { get; set; }

    }

}
