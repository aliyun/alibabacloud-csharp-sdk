// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ExpressConnectRouter20230901.Models
{
    public class ListExpressConnectRouterSupportedRegionRequest : TeaModel {
        /// <summary>
        /// <para>A client token to ensure the idempotence of the request.</para>
        /// <para>Generate a value that is unique across different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the <b>RequestId</b> as the <b>ClientToken</b>. Each request has a unique <b>RequestId</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-00****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The type of network instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>TR</b>: transit router instance.</para>
        /// </description></item>
        /// <item><description><para><b>VBR</b>: virtual border router instance.</para>
        /// </description></item>
        /// <item><description><para><b>VPC</b>: virtual private cloud instance.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VBR</para>
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
