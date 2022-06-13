// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListDsMenusRequest : TeaModel {
        /// <summary>
        /// 业务空间key,不设置则访问默认业务空间，key值在主账号业务管理页面获取
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// 机器人ID
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 1-正式环境，2-测试环境（默认）
        /// </summary>
        [NameInMap("RobotEnv")]
        [Validation(Required=false)]
        public int? RobotEnv { get; set; }

        /// <summary>
        /// 业务来源标识：
        /// 1-集团内部aliyun域名；2-外部使用4service域名（默认）
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public int? Source { get; set; }

        /// <summary>
        /// 功能标识，为空表示所有；支持的tag有：Dialog / Intent / Entity / Var / TaskCenter；传入多个时通过英文逗号分隔
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
