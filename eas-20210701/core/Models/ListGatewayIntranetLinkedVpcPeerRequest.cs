// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ListGatewayIntranetLinkedVpcPeerRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the attached virtual private cloud (VPC). For more information, see <a href="https://help.aliyun.com/document_detail/2621223.html">ListGatewayIntranetLinkedVpc</a>.</para>
        /// <list type="bullet">
        /// <item><description><para>Specify a VPC ID to query only the VPC peers for that VPC.</para>
        /// </description></item>
        /// <item><description><para>If you do not specify a VPC ID, all VPC peers are returned.</para>
        /// </description></item>
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
