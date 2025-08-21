// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DeployInstanceSDGShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The deployment type of the SDG. shared: shared read/write splitting deployment. The content of the SDG is read-only, and data updates are written to the local storage of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>shared</para>
        /// </summary>
        [NameInMap("DeploymentType")]
        [Validation(Required=false)]
        public string DeploymentType { get; set; }

        [NameInMap("DiskAccessProtocol")]
        [Validation(Required=false)]
        public string DiskAccessProtocol { get; set; }

        [NameInMap("DiskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        /// <summary>
        /// <para>The IDs of the instances. The value is a JSON array that consists of up to 100 IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIdsShrink { get; set; }

        /// <summary>
        /// <para>The ID of the SDG.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sdg-xxxx</para>
        /// </summary>
        [NameInMap("SDGId")]
        [Validation(Required=false)]
        public string SDGId { get; set; }

    }

}
