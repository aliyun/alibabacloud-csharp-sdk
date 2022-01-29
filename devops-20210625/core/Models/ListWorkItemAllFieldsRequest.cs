// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListWorkItemAllFieldsRequest : TeaModel {
        /// <summary>
        /// 项目id
        /// </summary>
        [NameInMap("spaceIdentifier")]
        [Validation(Required=false)]
        public string SpaceIdentifier { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [NameInMap("spaceType")]
        [Validation(Required=false)]
        public string SpaceType { get; set; }

        /// <summary>
        /// 工作项类型id，工作项类型的列表和id可以从ListProjectWorkitemType中获取
        /// </summary>
        [NameInMap("workitemTypeIdentifier")]
        [Validation(Required=false)]
        public string WorkitemTypeIdentifier { get; set; }

    }

}
