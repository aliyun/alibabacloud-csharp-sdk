// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GrafanaWorkspaceVpcRegionDetail : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>fc、ansm</para>
        /// </summary>
        [NameInMap("fcConfig")]
        [Validation(Required=false)]
        public string FcConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>配置ID</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Uninitialized</para>
        /// </summary>
        [NameInMap("installStatus")]
        [Validation(Required=false)]
        public string InstallStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vpc-abc*****</para>
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

        [NameInMap("securityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        [NameInMap("securityGroupIds")]
        [Validation(Required=false)]
        public List<string> SecurityGroupIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10988**********</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("vSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("vSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vpc-2ze4siu98**********</para>
        /// </summary>
        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
