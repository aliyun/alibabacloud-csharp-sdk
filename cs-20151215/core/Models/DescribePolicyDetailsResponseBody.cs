// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribePolicyDetailsResponseBody : TeaModel {
        /// <summary>
        /// 规则治理动作 ● enforce: 拦截违规部署 ● inform：告警
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// 规则模板类型
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// 规则模板描述
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 软删除标志：0表示未删除 1表示删除
        /// </summary>
        [NameInMap("is_deleted")]
        [Validation(Required=false)]
        public int? IsDeleted { get; set; }

        /// <summary>
        /// 策略治理规则名称
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 是否需要配置策略： 0表示需要参数配置 1表示无需参数配置
        /// </summary>
        [NameInMap("no_config")]
        [Validation(Required=false)]
        public int? NoConfig { get; set; }

        /// <summary>
        /// 规则治理等级
        /// </summary>
        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// 规则模板详情
        /// </summary>
        [NameInMap("template")]
        [Validation(Required=false)]
        public string Template { get; set; }

    }

}
