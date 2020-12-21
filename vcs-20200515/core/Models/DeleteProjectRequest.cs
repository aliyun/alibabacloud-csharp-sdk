// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class DeleteProjectRequest : TeaModel {
        /// <summary>
        /// 项目id,多个以”,“隔开
        /// </summary>
        [NameInMap("ProjectIds")]
        [Validation(Required=false)]
        public string ProjectIds { get; set; }

    }

}
