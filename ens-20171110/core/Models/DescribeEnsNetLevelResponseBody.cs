// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsNetLevelResponseBody : TeaModel {
        /// <summary>
        /// The returned service code. A value of 0 indicates that the operation was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The network levels.
        /// </summary>
        [NameInMap("EnsNetLevels")]
        [Validation(Required=false)]
        public DescribeEnsNetLevelResponseBodyEnsNetLevels EnsNetLevels { get; set; }
        public class DescribeEnsNetLevelResponseBodyEnsNetLevels : TeaModel {
            [NameInMap("EnsNetLevel")]
            [Validation(Required=false)]
            public List<DescribeEnsNetLevelResponseBodyEnsNetLevelsEnsNetLevel> EnsNetLevel { get; set; }
            public class DescribeEnsNetLevelResponseBodyEnsNetLevelsEnsNetLevel : TeaModel {
                /// <summary>
                /// The network level. Valid values:
                /// 
                /// *   Big: greater area.
                /// *   Middle: province.
                /// *   Small: city.
                /// </summary>
                [NameInMap("EnsNetLevelCode")]
                [Validation(Required=false)]
                public string EnsNetLevelCode { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
