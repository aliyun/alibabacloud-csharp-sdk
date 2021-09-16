// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class DataValue : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 配置描述
        /// </summary>
        [NameInMap("configDescription")]
        [Validation(Required=false)]
        public string ConfigDescription { get; set; }

        /// <summary>
        /// 配置code
        /// </summary>
        [NameInMap("configCode")]
        [Validation(Required=false)]
        public string ConfigCode { get; set; }

        /// <summary>
        /// 配置父code
        /// </summary>
        [NameInMap("parentCode")]
        [Validation(Required=false)]
        public string ParentCode { get; set; }

        /// <summary>
        /// key (用于前后端值传递)
        /// </summary>
        [NameInMap("configKey")]
        [Validation(Required=false)]
        public string ConfigKey { get; set; }

        /// <summary>
        /// value (用于前端展示)
        /// </summary>
        [NameInMap("configValue")]
        [Validation(Required=false)]
        public string ConfigValue { get; set; }

        /// <summary>
        /// 是否必选
        /// </summary>
        [NameInMap("requirement")]
        [Validation(Required=false)]
        public bool? Requirement { get; set; }

    }

}
