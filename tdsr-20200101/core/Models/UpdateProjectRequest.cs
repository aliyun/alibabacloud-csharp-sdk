// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class UpdateProjectRequest : TeaModel {
        /// <summary>
        /// 项目id
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 业务Id
        /// </summary>
        [NameInMap("BusinessId")]
        [Validation(Required=false)]
        public string BusinessId { get; set; }

    }

}
