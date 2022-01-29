// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListProjectWorkitemTypesRequest : TeaModel {
        /// <summary>
        /// 工作项类型
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// 空间类型
        /// </summary>
        [NameInMap("spaceType")]
        [Validation(Required=false)]
        public string SpaceType { get; set; }

    }

}
