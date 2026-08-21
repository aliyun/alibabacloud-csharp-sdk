// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListInstanceInfoRequest : TeaModel {
        [NameInMap("X-Debug-Id")]
        [Validation(Required=false)]
        public string XDebugId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>instance_tag</para>
        /// </summary>
        [NameInMap("infoType")]
        [Validation(Required=false)]
        public string InfoType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("instanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>managed</para>
        /// </summary>
        [NameInMap("managedType")]
        [Validation(Required=false)]
        public string ManagedType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xiF/wDgaeitjjhVJYYzLwJ4dD+2BRJj42DLT6GrZysw=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>01fc4a0b-f199-4885-9861-b4054a310fe7</para>
        /// </summary>
        [NameInMap("pluginId")]
        [Validation(Required=false)]
        public string PluginId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("x-sysom-invoke-source")]
        [Validation(Required=false)]
        public string XSysomInvokeSource { get; set; }

    }

}
