// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateNASFileSystemRequest : TeaModel {
        /// <summary>
        /// <para>Description of the NAS file system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Whether the file system is encrypted. Uses KMS service-managed keys to encrypt the file system\&quot;s on-disk data. No decryption is required when reading and writing encrypted data. Possible values and their meanings:</para>
        /// <list type="bullet">
        /// <item><description>0: Not encrypted.</description></item>
        /// <item><description>1: Encrypted using NAS-managed keys.</description></item>
        /// </list>
        /// <para>Default value: 0</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("EncryptType")]
        [Validation(Required=false)]
        public string EncryptType { get; set; }

        /// <summary>
        /// <para>Name of the NAS file system.
        /// The file name must follow these rules:</para>
        /// <list type="bullet">
        /// <item><description>Length: 2 to 128 English or Chinese characters.</description></item>
        /// <item><description>Must start with an uppercase or lowercase letter or a Chinese character, cannot start with http:// or https://.</description></item>
        /// <item><description>Can include numbers, underscores (_), or hyphens (-).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>testNAS</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-363353****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>Region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Storage specification type of the NAS file system. Allowed values:</para>
        /// <list type="bullet">
        /// <item><description>Capacity: Capacity type.</description></item>
        /// <item><description>Performance: Performance type.</description></item>
        /// </list>
        /// <para>Default value: Capacity</para>
        /// 
        /// <b>Example:</b>
        /// <para>Capacity</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

    }

}
