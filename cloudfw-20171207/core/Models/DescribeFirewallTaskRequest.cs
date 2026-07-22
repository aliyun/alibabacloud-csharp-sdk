// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeFirewallTaskRequest : TeaModel {
        /// <summary>
        /// <para>The VPC-connected instance ID. You must specify at least one of TaskId and ChildInstanceId. If neither is specified, the API returns ErrorParameters(400).</para>
        /// 
        /// <b>Example:</b>
        /// <para>vfw-tr-cd6000c588214403****</para>
        /// </summary>
        [NameInMap("ChildInstanceId")]
        [Validation(Required=false)]
        public string ChildInstanceId { get; set; }

        /// <summary>
        /// <para>The language type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The task ID. You must specify at least one of TaskId and ChildInstanceId. If neither is specified, the API returns ErrorParameters(400).</para>
        /// 
        /// <b>Example:</b>
        /// <para>199431783</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The type of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>NAT</b>: NAT firewall task</para>
        /// </description></item>
        /// <item><description><para><b>VPC</b>: VPC firewall task</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
