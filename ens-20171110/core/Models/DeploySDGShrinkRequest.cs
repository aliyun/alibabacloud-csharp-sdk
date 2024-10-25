// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DeploySDGShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The SDG deployment type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>common (default): read/write deployment. Data updates are written to disks.</description></item>
        /// <item><description>overlay: read/write splitting deployment. Content in SDGs is read-only. Data updates are written to the local storage of the instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>common</para>
        /// </summary>
        [NameInMap("DeploymentType")]
        [Validation(Required=false)]
        public string DeploymentType { get; set; }

        /// <summary>
        /// <para>The IDs of instances on which you want to deploy SDGs. You can deploy SDGs on a maximum of 100 instances at a time.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIdsShrink { get; set; }

        /// <summary>
        /// <para>The SDG ID. This parameter is used to create a disk, which is attached to an instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sdg-xxxxx</para>
        /// </summary>
        [NameInMap("SDGId")]
        [Validation(Required=false)]
        public string SDGId { get; set; }

    }

}
