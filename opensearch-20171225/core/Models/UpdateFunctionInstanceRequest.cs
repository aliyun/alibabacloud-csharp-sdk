// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class UpdateFunctionInstanceRequest : TeaModel {
        /// <summary>
        /// 创建参数
        /// </summary>
        [NameInMap("createParameters")]
        [Validation(Required=false)]
        public List<UpdateFunctionInstanceRequestCreateParameters> CreateParameters { get; set; }
        public class UpdateFunctionInstanceRequestCreateParameters : TeaModel {
            /// <summary>
            /// 参数名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 参数值
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// 周期训练
        /// </summary>
        [NameInMap("cron")]
        [Validation(Required=false)]
        public string Cron { get; set; }

        /// <summary>
        /// 实例描述
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 使用参数
        /// </summary>
        [NameInMap("usageParameters")]
        [Validation(Required=false)]
        public List<UpdateFunctionInstanceRequestUsageParameters> UsageParameters { get; set; }
        public class UpdateFunctionInstanceRequestUsageParameters : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
