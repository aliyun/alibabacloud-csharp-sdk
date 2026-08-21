// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetConfigByNameRequest : TeaModel {
        [NameInMap("X-Debug-Id")]
        [Validation(Required=false)]
        public string XDebugId { get; set; }

        /// <summary>
        /// <para>The configuration name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>节点网络延时检测</para>
        /// </summary>
        [NameInMap("configName")]
        [Validation(Required=false)]
        public string ConfigName { get; set; }

        /// <summary>
        /// <para>The type of the configuration parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>attention</para>
        /// </summary>
        [NameInMap("configType")]
        [Validation(Required=false)]
        public string ConfigType { get; set; }

        /// <summary>
        /// <para>The entity ID. Default value: &quot;default&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bptest</para>
        /// </summary>
        [NameInMap("entityId")]
        [Validation(Required=false)]
        public string EntityId { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the global UID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("useGlobalUid")]
        [Validation(Required=false)]
        public bool? UseGlobalUid { get; set; }

        /// <summary>
        /// <para>The version ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("versionId")]
        [Validation(Required=false)]
        public long? VersionId { get; set; }

        [NameInMap("x-sysom-invoke-source")]
        [Validation(Required=false)]
        public string XSysomInvokeSource { get; set; }

    }

}
