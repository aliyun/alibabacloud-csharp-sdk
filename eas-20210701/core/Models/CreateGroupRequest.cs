// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateGroupRequest : TeaModel {
        /// <summary>
        /// <para>The user-defined labels.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// <para>The name of the group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>foo</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The virtual private cloud (VPC) configuration.</para>
        /// </summary>
        [NameInMap("Network")]
        [Validation(Required=false)]
        public CreateGroupRequestNetwork Network { get; set; }
        public class CreateGroupRequestNetwork : TeaModel {
            /// <summary>
            /// <para>The dedicated gateway ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-248xxxxxxvlkhtbrda</para>
            /// </summary>
            [NameInMap("GatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            /// <summary>
            /// <para>The security group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-584xxxxxx7h08llvoww5tv5gl</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1xxxxxxwmssgq28gye8</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1xxxxxx0qrykjr9b</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12xx34</para>
        /// </summary>
        [NameInMap("WorkSpaceId")]
        [Validation(Required=false)]
        public string WorkSpaceId { get; set; }

    }

}
