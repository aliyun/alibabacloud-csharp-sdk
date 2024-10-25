// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeStorageVolumeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen-3</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sgw-****</para>
        /// </summary>
        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the volume. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b> (default): enables the volume.</description></item>
        /// <item><description><b>0</b>: disables the volume.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsEnable")]
        [Validation(Required=false)]
        public int? IsEnable { get; set; }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the storage medium.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-***</para>
        /// </summary>
        [NameInMap("StorageId")]
        [Validation(Required=false)]
        public string StorageId { get; set; }

        /// <summary>
        /// <para>The ID of the volume.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sv-***</para>
        /// </summary>
        [NameInMap("VolumeId")]
        [Validation(Required=false)]
        public string VolumeId { get; set; }

    }

}
