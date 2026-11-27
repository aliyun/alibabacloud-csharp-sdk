// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class DeleteAScriptsRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the programmable scripts.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AScriptIds")]
        [Validation(Required=false)]
        public List<string> AScriptIds { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can generate the value from your client and ensure that the value is unique among different requests. The client token can contain only ASCII characters. If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f516e84e-fc0c-4c2d-a461-6cd77******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run and does not delete the programmable scripts. The system checks whether required parameters are specified, the request format, and service limits. If the check fails, the system returns an error. If the check succeeds, the system returns the <c>DryRunOperation</c> error code.</description></item>
        /// <item><description><b>false</b> (default): performs a regular request. If the check succeeds, the system returns an HTTP 2xx status code and performs the operation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
