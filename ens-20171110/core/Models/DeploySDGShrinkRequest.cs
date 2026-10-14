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
        /// <item><description>common: (default) read/write deployment. Data updates are written to the cloud disk.</description></item>
        /// <item><description>overlay: read/write splitting deployment. The SDG content is read-only, and data updates are written to the local storage of the instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>common</para>
        /// </summary>
        [NameInMap("DeploymentType")]
        [Validation(Required=false)]
        public string DeploymentType { get; set; }

        /// <summary>
        /// <para>The list of device resource IDs to which the SDG is deployed. Batch deployment is supported, with a maximum of 100 instances per request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIdsShrink { get; set; }

        /// <summary>
        /// <para>The SDG ID. A cloud disk is created based on this SDG ID and mounted to the specified instance.</para>
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
