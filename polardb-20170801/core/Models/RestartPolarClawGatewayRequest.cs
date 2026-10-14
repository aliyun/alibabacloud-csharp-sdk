// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class RestartPolarClawGatewayRequest : TeaModel {
        /// <summary>
        /// <para>The PolarClaw application ID. Example: pa-xxx.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-xxx</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The restart mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>in-process: lightweight restart. Environment variables do not take effect. This is the default value.</description></item>
        /// <item><description>pkill: cold start. Environment variables take effect.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>in-process</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

    }

}
