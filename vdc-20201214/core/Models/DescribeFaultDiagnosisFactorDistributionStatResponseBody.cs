// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeFaultDiagnosisFactorDistributionStatResponseBody : TeaModel {
        /// <summary>
        /// 影响因素分布统计数据
        /// </summary>
        [NameInMap("StatList")]
        [Validation(Required=false)]
        public List<DescribeFaultDiagnosisFactorDistributionStatResponseBodyStatList> StatList { get; set; }
        public class DescribeFaultDiagnosisFactorDistributionStatResponseBodyStatList : TeaModel {
            /// <summary>
            /// 影响因素ID： 1：发布端网络差 2：订阅端网络差 3：发布端设备性能差 4：发布端关闭摄像头 5：发布端切到后台运行，UNKNOWN：未知
            /// </summary>
            [NameInMap("FactorId")]
            [Validation(Required=false)]
            public string FactorId { get; set; }

            /// <summary>
            /// 影响用户数
            /// </summary>
            [NameInMap("UserCount")]
            [Validation(Required=false)]
            public int? UserCount { get; set; }

            /// <summary>
            /// 影响用户占比
            /// </summary>
            [NameInMap("UserRatio")]
            [Validation(Required=false)]
            public float? UserRatio { get; set; }

        }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
