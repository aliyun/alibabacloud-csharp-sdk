// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateGlobalDataNetworkRequest : TeaModel {
        /// <summary>
        /// <para>The description or remarks for the GDN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mygdn</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Destination path</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("DestinationFileSystemPath")]
        [Validation(Required=false)]
        public string DestinationFileSystemPath { get; set; }

        /// <summary>
        /// <para>Target PolarFileSystem (PolarFS) instance</para>
        /// 
        /// <b>Example:</b>
        /// <para>pfs-xxx</para>
        /// </summary>
        [NameInMap("DestinationId")]
        [Validation(Required=false)]
        public string DestinationId { get; set; }

        /// <summary>
        /// <para>The region of the destination PolarFS instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("DestinationRegion")]
        [Validation(Required=false)]
        public string DestinationRegion { get; set; }

        /// <summary>
        /// <para>The type of the destination instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>pfs</b>: PolarFS High-Performance Edition.</para>
        /// </description></item>
        /// <item><description><para><b>pcs</b>: PolarFS Cold Storage Edition.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pfs</para>
        /// </summary>
        [NameInMap("DestinationType")]
        [Validation(Required=false)]
        public string DestinationType { get; set; }

        /// <summary>
        /// <para>Whether to freeze the source path during transmission. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Freeze.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Do not freeze.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Currently only supports oss source.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("FreezeSourceDuringSync")]
        [Validation(Required=false)]
        public string FreezeSourceDuringSync { get; set; }

        /// <summary>
        /// <para>The source path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("SourceFileSystemPath")]
        [Validation(Required=false)]
        public string SourceFileSystemPath { get; set; }

        /// <summary>
        /// <para>Source PolarFileSystem (PolarFS) instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pcs-xxx</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The region of the source PolarFS instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-wulanchabu</para>
        /// </summary>
        [NameInMap("SourceRegion")]
        [Validation(Required=false)]
        public string SourceRegion { get; set; }

        /// <summary>
        /// <para>The type of the source instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>pfs</b>: PolarFS High-Performance Edition.</para>
        /// </description></item>
        /// <item><description><para><b>pcs</b>: PolarFS Cold Storage Edition.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pcs</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
