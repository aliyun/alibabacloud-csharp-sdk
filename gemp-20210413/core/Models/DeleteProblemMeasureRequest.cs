// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class DeleteProblemMeasureRequest : TeaModel {
        /// <summary>
        /// 故障改成措施id
        /// </summary>
        [NameInMap("measureId")]
        [Validation(Required=false)]
        public long? MeasureId { get; set; }

        /// <summary>
        /// 故障Id
        /// </summary>
        [NameInMap("problemId")]
        [Validation(Required=false)]
        public string ProblemId { get; set; }

        /// <summary>
        /// 幂等校验token
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
