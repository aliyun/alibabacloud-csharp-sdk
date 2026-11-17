// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateAndBindNasFileSystemRequest : TeaModel {
        /// <summary>
        /// <para>The description of the NAS file system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>newDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the shared cloud desktop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dg-fh0vdzyh6rdc*****</para>
        /// </summary>
        [NameInMap("DesktopGroupId")]
        [Validation(Required=false)]
        public string DesktopGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether the file system uses Key Management Service (KMS) managed keys to encrypt data at rest. No decryption is required when reading or writing encrypted data.</para>
        /// <remarks>
        /// <para>When <c>FileSystemType</c> is set to <c>standard</c> or <c>extreme</c>, NAS-managed keys are supported. When <c>FileSystemType</c> is set to <c>extreme</c>, user-managed keys are supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("EncryptType")]
        [Validation(Required=false)]
        public int? EncryptType { get; set; }

        /// <summary>
        /// <para>The list of user IDs.</para>
        /// </summary>
        [NameInMap("EndUserIds")]
        [Validation(Required=false)]
        public List<string> EndUserIds { get; set; }

        /// <summary>
        /// <para>The name of the NAS file system.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>szy-asp-upm-test</para>
        /// </summary>
        [NameInMap("FileSystemName")]
        [Validation(Required=false)]
        public string FileSystemName { get; set; }

        /// <summary>
        /// <para>The ID of the office network.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing+dir-15657*****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="~~DescribeRegions~~">DescribeRegions</a> to query the regions supported by WUYING Workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The user VHD capacity tier in GiB. Valid values: 5, 20, 50, 100, and 500. Default value: 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("SizeQuota")]
        [Validation(Required=false)]
        public long? SizeQuota { get; set; }

        /// <summary>
        /// <para>The storage type of the NAS file system.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Capacity</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

    }

}
