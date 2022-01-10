// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateSprintRequest : TeaModel {
        /// <summary>
        /// 结束时间
        /// </summary>
        [NameInMap("endDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// 迭代名
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [NameInMap("spaceIdentifier")]
        [Validation(Required=false)]
        public string SpaceIdentifier { get; set; }

        /// <summary>
        /// 负责人列表
        /// </summary>
        [NameInMap("staffIds")]
        [Validation(Required=false)]
        public List<string> StaffIds { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [NameInMap("startDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

    }

}
