// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class BindEcsSlbRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. You can query the application ID by calling the ListApplication operation. For more information, see <a href="https://help.aliyun.com/document_detail/149390.html">ListApplication</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>93fdd228-*****-ed2ae98de18d</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the instance group whose application you want to bind. You can call the ListDeployGroup operation to query the group ID. For more information, see <a href="https://help.aliyun.com/document_detail/62077.html">ListDeployGroup</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>577f4c50-16ee-43d8-<b><b>-</b></b></para>
        /// </summary>
        [NameInMap("DeployGroupId")]
        [Validation(Required=false)]
        public string DeployGroupId { get; set; }

        /// <summary>
        /// <para>The health check URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/_ehc.html</para>
        /// </summary>
        [NameInMap("ListenerHealthCheckUrl")]
        [Validation(Required=false)]
        public string ListenerHealthCheckUrl { get; set; }

        /// <summary>
        /// <para>The listener port for the SLB instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// <para>The listener protocol for the SLB instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tcp</para>
        /// </summary>
        [NameInMap("ListenerProtocol")]
        [Validation(Required=false)]
        public string ListenerProtocol { get; set; }

        /// <summary>
        /// <para>The ID of the SLB instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-uf6j54m3a****cj01jx8</para>
        /// </summary>
        [NameInMap("SlbId")]
        [Validation(Required=false)]
        public string SlbId { get; set; }

        /// <summary>
        /// <para>The forwarding rule of the SLB listener.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com/forwarding</para>
        /// </summary>
        [NameInMap("VForwardingUrlRule")]
        [Validation(Required=false)]
        public string VForwardingUrlRule { get; set; }

        /// <summary>
        /// <para>The ID of the vServer group for the SLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rsp-2ze<b><b>6l</b></b>*</para>
        /// </summary>
        [NameInMap("VServerGroupId")]
        [Validation(Required=false)]
        public string VServerGroupId { get; set; }

        /// <summary>
        /// <para>The name of the vServer group.</para>
        /// </summary>
        [NameInMap("VServerGroupName")]
        [Validation(Required=false)]
        public string VServerGroupName { get; set; }

    }

}
