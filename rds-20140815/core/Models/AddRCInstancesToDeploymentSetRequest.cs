// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class AddRCInstancesToDeploymentSetRequest : TeaModel {
        /// <summary>
        /// <para>The group number of the ECS instance in the deployment set when the deployment set policy is high availability group (AvailabilityGroup). You can use this parameter to specify the group number. Valid values: 1 to 7. If no value is specified, the system automatically assigns an active group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DeploymentSetGroupNo")]
        [Validation(Required=false)]
        public string DeploymentSetGroupNo { get; set; }

        /// <summary>
        /// <para>The deployment set ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds-uf6c8qerk019bj1l****</para>
        /// </summary>
        [NameInMap("DeploymentSetId")]
        [Validation(Required=false)]
        public string DeploymentSetId { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcibly release running instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Forcibly release.</description></item>
        /// <item><description><b>false</b> (default): Do not forcibly release.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rc-aaaa,rc-bbb</para>
        /// </summary>
        [NameInMap("RCInstanceIds")]
        [Validation(Required=false)]
        public string RCInstanceIds { get; set; }

        /// <summary>
        /// <para>The region ID. You can call DescribeRegions to query available regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
