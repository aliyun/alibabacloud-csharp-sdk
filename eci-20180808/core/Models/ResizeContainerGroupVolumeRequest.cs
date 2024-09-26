// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class ResizeContainerGroupVolumeRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the elastic container instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eci-2zelg8vwnlzdhf8hv****</para>
        /// </summary>
        [NameInMap("ContainerGroupId")]
        [Validation(Required=false)]
        public string ContainerGroupId { get; set; }

        /// <summary>
        /// <para>The size of the volume after the volume is scaled up. Unit: GiB. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Ultra disk (cloud_efficiency): 20 to 32768</description></item>
        /// <item><description>Standard SSD (cloud_ssd): 20 to 32768</description></item>
        /// <item><description>Enhanced SSD (cloud_essd): 20 to 32768</description></item>
        /// <item><description>Basic disk (cloud): 5 to 2000</description></item>
        /// </list>
        /// <remarks>
        /// <para> The capacity of the volume after the volume is scaled up must be greater than the original capacity of the volume. If the new capacity is equal to the original capacity of the volume, only the file system is scaled up.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("NewSize")]
        [Validation(Required=false)]
        public long? NewSize { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The name of the volume that is mounted to the elastic container instance. Only disk volumes can be scaled up.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default-volume1</para>
        /// </summary>
        [NameInMap("VolumeName")]
        [Validation(Required=false)]
        public string VolumeName { get; set; }

    }

}
