// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ArmsConfiguration : TeaModel {
        /// <summary>
        /// <para>应用实时监控服务（ARMS）的许可证密钥</para>
        /// 
        /// <b>Example:</b>
        /// <para>arms-license-key-123456</para>
        /// </summary>
        [NameInMap("armsLicenseKey")]
        [Validation(Required=false)]
        public string ArmsLicenseKey { get; set; }

        /// <summary>
        /// <para>是否启用应用实时监控服务（ARMS）</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableArms")]
        [Validation(Required=false)]
        public bool? EnableArms { get; set; }

    }

}
