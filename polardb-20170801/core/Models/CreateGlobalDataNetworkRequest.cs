// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateGlobalDataNetworkRequest : TeaModel {
        /// <summary>
        /// <para>The description or remark of the GDN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mygdn</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The destination path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("DestinationFileSystemPath")]
        [Validation(Required=false)]
        public string DestinationFileSystemPath { get; set; }

        /// <summary>
        /// <para>The destination Polarlakebase instance. Note: This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pfs-xxx</para>
        /// </summary>
        [NameInMap("DestinationId")]
        [Validation(Required=false)]
        public string DestinationId { get; set; }

        /// <summary>
        /// <para>The region of the destination Polarlakebase instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("DestinationRegion")]
        [Validation(Required=false)]
        public string DestinationRegion { get; set; }

        /// <summary>
        /// <para>The destination type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>pfs</b>: Polarlakebase High-performance Edition.</description></item>
        /// <item><description><b>pcs</b>: Polarlakebase Cold Storage Edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pfs</para>
        /// </summary>
        [NameInMap("DestinationType")]
        [Validation(Required=false)]
        public string DestinationType { get; set; }

        /// <summary>
        /// <para>Specifies whether to freeze the source path during data transmission. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Freezes the source path.</description></item>
        /// <item><description><b>false</b>: Does not freeze the source path.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Currently, only OSS sources are supported.</para>
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
        /// <para>The source Polarlakebase instance. Note: This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pcs-xxx</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The region of the source Polarlakebase instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-wulanchabu</para>
        /// </summary>
        [NameInMap("SourceRegion")]
        [Validation(Required=false)]
        public string SourceRegion { get; set; }

        /// <summary>
        /// <para>The source type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>pfs</b>: Polarlakebase High-performance Edition.</description></item>
        /// <item><description><b>pcs</b>: Polarlakebase Cold Storage Edition.</description></item>
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
