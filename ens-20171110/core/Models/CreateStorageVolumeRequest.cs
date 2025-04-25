// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateStorageVolumeRequest : TeaModel {
        /// <summary>
        /// <para>The password of the CHAP protocol.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Password</para>
        /// </summary>
        [NameInMap("AuthPassword")]
        [Validation(Required=false)]
        public string AuthPassword { get; set; }

        /// <summary>
        /// <para>The authentication protocol. Set the value to <b>CHAP</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CHAP</para>
        /// </summary>
        [NameInMap("AuthProtocol")]
        [Validation(Required=false)]
        public string AuthProtocol { get; set; }

        /// <summary>
        /// <para>The username of the CHAP protocol.</para>
        /// 
        /// <b>Example:</b>
        /// <para>User</para>
        /// </summary>
        [NameInMap("AuthUser")]
        [Validation(Required=false)]
        public string AuthUser { get; set; }

        /// <summary>
        /// <para>The description of the volume. The description must be 2 to 128 characters in length. The description cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the node.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen-3</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sgw-****</para>
        /// </summary>
        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable authentication. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Authentication is enabled.</description></item>
        /// <item><description><b>0</b> (default): Authentication is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsAuth")]
        [Validation(Required=false)]
        public string IsAuth { get; set; }

        /// <summary>
        /// <para>Indicates whether the volume is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b> (default): The volume is enabled.</description></item>
        /// <item><description><b>0</b>: The volume is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsEnable")]
        [Validation(Required=false)]
        public string IsEnable { get; set; }

        /// <summary>
        /// <para>The ID of the storage medium.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>si-****</para>
        /// </summary>
        [NameInMap("StorageId")]
        [Validation(Required=false)]
        public string StorageId { get; set; }

        /// <summary>
        /// <para>The name of the volume. The name must be 2 to 128 characters in length. The name cannot start with <c>http://</c> or <c>https://</c>. The name can contain letters, digits, colons (:), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>testVolumeName</para>
        /// </summary>
        [NameInMap("VolumeName")]
        [Validation(Required=false)]
        public string VolumeName { get; set; }

    }

}
