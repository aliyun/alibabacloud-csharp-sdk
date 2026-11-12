// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ListGatewayIntranetLinkedVpcPeerRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the associated VPC. For more information about how to query the VPC ID, see <a href="https://help.aliyun.com/document_detail/2621223.html">ListGatewayIntranetLinkedVpc</a>.</para>
        /// <list type="bullet">
        /// <item><description>If you specify a VPC ID, only the VPC peers associated with the specified VPC ID are queried.</description></item>
        /// <item><description>If you do not specify a VPC ID, all VPC peers are queried.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2zetuli9ws0qgjd******</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
