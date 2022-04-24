// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class EnableSceneRequest : TeaModel {
        /// <summary>
        /// 知识id集合
        /// </summary>
        [NameInMap("KnowledgeIds")]
        [Validation(Required=false)]
        public List<long?> KnowledgeIds { get; set; }

        /// <summary>
        /// 操作用户id
        /// </summary>
        [NameInMap("OperatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作用户名称
        /// </summary>
        [NameInMap("OperatorName")]
        [Validation(Required=false)]
        public string OperatorName { get; set; }

        /// <summary>
        /// 机器人code
        /// </summary>
        [NameInMap("RobotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

    }

}
