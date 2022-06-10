// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// 业务空间key,不设置则访问默认业务空间，key值在主账号业务管理页面获取
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// 机器人备注，不超过50字
        /// </summary>
        [NameInMap("Introduction")]
        [Validation(Required=false)]
        public string Introduction { get; set; }

        /// <summary>
        /// 机器人服务的语言，如zh-cn、en-us，参考 http://www.lingoes.net/zh/translator/langcode.htm   入参全小写，当前只支持 zh-cn、en-us
        /// </summary>
        [NameInMap("LanguageCode")]
        [Validation(Required=false)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// 机器人名称，不超过50字
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 机器人类型
        /// </summary>
        [NameInMap("RobotType")]
        [Validation(Required=false)]
        public string RobotType { get; set; }

    }

}
