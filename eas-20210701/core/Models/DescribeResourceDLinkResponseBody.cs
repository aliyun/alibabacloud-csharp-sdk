// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeResourceDLinkResponseBody : TeaModel {
        /// <summary>
        /// <para>The IDs of the secondary vSwitches that are directly connected.</para>
        /// </summary>
        [NameInMap("AuxVSwitchList")]
        [Validation(Required=false)]
        public List<string> AuxVSwitchList { get; set; }

        /// <summary>
        /// <para>The CIDR blocks of the clients that you want to connect to. After this parameter is specified, the CIDR blocks are added to the back-to-origin route of the server. Either this parameter or the VSwitchIdList parameter can be used to determine CIDR blocks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>72.16.0.0/16</para>
        /// </summary>
        [NameInMap("DestinationCIDRs")]
        [Validation(Required=false)]
        public string DestinationCIDRs { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40325405-579C-4D82****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the security group that is directly connected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp1j1z7297hcink9d****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the primary vSwitch that is directly connected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-8vbqn2at0kljjxxxx****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC that is directly connected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-uf66uio7md****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
