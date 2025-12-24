// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs_workbench20251111.Models
{
    public class ModifyTerminalSettingsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>免密登录配置</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PasswordlessLoginConfig")]
        [Validation(Required=false)]
        public string PasswordlessLoginConfigShrink { get; set; }

    }

}
