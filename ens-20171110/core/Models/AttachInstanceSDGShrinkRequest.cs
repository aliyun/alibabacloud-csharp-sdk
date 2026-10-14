// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AttachInstanceSDGShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The cloud disk access protocol type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>iscsi: the default protocol for standard cloud disks. Both rbd cloud disks and standard cloud disks support this protocol.</para>
        /// </description></item>
        /// <item><description><para>rbd: the default protocol for rbd cloud disks. Only rbd cloud disks support this mount protocol.</para>
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
        /// <item><description>rbd: rbd cloud disk.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If no shared cloud disk type is specified, a standard cloud disk is created by default.</description></item>
        /// <item><description>An rbd shared cloud disk can be created only when the parent disk type is rbd.</description></item>
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
        /// <para>The list of instance IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIdsShrink { get; set; }

        /// <summary>
        /// <para>The file loading rate optimization parameter.</para>
        /// </summary>
        [NameInMap("LoadOpt")]
        [Validation(Required=false)]
        public string LoadOptShrink { get; set; }

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
