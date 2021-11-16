// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CreateProblemEffectionServiceRequest : TeaModel {
        /// <summary>
        /// clientToken
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// 影响描述
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 影响等级
        /// </summary>
        [NameInMap("level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        [NameInMap("pictureUrl")]
        [Validation(Required=false)]
        public List<string> PictureUrl { get; set; }

        /// <summary>
        /// 故障id
        /// </summary>
        [NameInMap("problemId")]
        [Validation(Required=false)]
        public long? ProblemId { get; set; }

        /// <summary>
        /// 影响服务id
        /// </summary>
        [NameInMap("serviceId")]
        [Validation(Required=false)]
        public long? ServiceId { get; set; }

        /// <summary>
        /// 影响状态 0 未恢复 1已恢复
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
