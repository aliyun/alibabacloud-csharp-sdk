// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class BindSlbRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Enterprise Distributed Application Service (EDAS) application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3616cdca-*********</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The listener port.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// <para>The ID of the SLB instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-wz96ph63r************</para>
        /// </summary>
        [NameInMap("SlbId")]
        [Validation(Required=false)]
        public string SlbId { get; set; }

        /// <summary>
        /// <para>The IP address of the SLB instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.16*.<em>.</em></para>
        /// </summary>
        [NameInMap("SlbIp")]
        [Validation(Required=false)]
        public string SlbIp { get; set; }

        /// <summary>
        /// <para>The network type of the SLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>internet: an Internet-facing instance.</para>
        /// </description></item>
        /// <item><description><para>intranet: an internal-facing instance.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>intranet</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The ID of the vServer group for the internal-facing SLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rsp-cige6******</para>
        /// </summary>
        [NameInMap("VServerGroupId")]
        [Validation(Required=false)]
        public string VServerGroupId { get; set; }

    }

}
