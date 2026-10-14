// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DeployInstanceSDGShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The SDG deployment type. Set the value to shared, which indicates read/write splitting shared deployment. In this mode, the SDG content is read-only, and data updates are written to the local storage of the instance.</para>
        /// <para>This parameter is required. Currently, only the value shared is supported. If this parameter is not specified, the service returns a Parameter.Invalid error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>shared</para>
        /// </summary>
        [NameInMap("DeploymentType")]
        [Validation(Required=false)]
        public string DeploymentType { get; set; }

        /// <summary>
        /// <para>The access protocol type of the cloud disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>iscsi: the default protocol for standard cloud disks. Both RBD cloud disks and standard cloud disks support this protocol.</para>
        /// </description></item>
        /// <item><description><para>rbd: the default protocol for RBD cloud disks. Only RBD cloud disks support this mount protocol.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>iscsi</para>
        /// </summary>
        [NameInMap("DiskAccessProtocol")]
        [Validation(Required=false)]
        public string DiskAccessProtocol { get; set; }

        /// <summary>
        /// <para>The type of the shared cloud disk to be created. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>standard: standard cloud disk.</description></item>
        /// <item><description>rbd: RBD cloud disk.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If this parameter is not specified, a standard cloud disk is created by default.</description></item>
        /// <item><description>An RBD shared cloud disk can be created only when the source disk type is RBD.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("DiskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        /// <summary>
        /// <para>The list of instance IDs. The value is a JSON array. A maximum of 100 IDs can be specified.</para>
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
