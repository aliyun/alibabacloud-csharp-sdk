// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20181015.Models
{
    public class GrafanaWorkspaceVpcConfig : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>fc、ansm</para>
        /// </summary>
        [NameInMap("fcConfig")]
        [Validation(Required=false)]
        public string FcConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("installMsg")]
        [Validation(Required=false)]
        public string InstallMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CreateSucceed</para>
        /// </summary>
        [NameInMap("installStatus")]
        [Validation(Required=false)]
        public string InstallStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>北京VPC-A通道</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sg-6we94uvybteyc******</para>
        /// </summary>
        [NameInMap("securityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10983***********</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vsw-6we3**********</para>
        /// </summary>
        [NameInMap("vSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vpc-6wehr2x**********</para>
        /// </summary>
        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
