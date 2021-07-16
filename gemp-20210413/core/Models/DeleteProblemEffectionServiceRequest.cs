// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class DeleteProblemEffectionServiceRequest : TeaModel {
        /// <summary>
        /// 影响服务ID
        /// </summary>
        [NameInMap("effectionServiceId")]
        [Validation(Required=false)]
        public long? EffectionServiceId { get; set; }

        /// <summary>
        /// 故障id
        /// </summary>
        [NameInMap("problemId")]
        [Validation(Required=false)]
        public long? ProblemId { get; set; }

        /// <summary>
        /// clientToken
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
