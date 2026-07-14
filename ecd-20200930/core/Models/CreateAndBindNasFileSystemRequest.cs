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
        /// <para>The ID of the shared cloud computer.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dg-fh0vdzyh6rdc*****</para>
        /// </summary>
        [NameInMap("DesktopGroupId")]
        [Validation(Required=false)]
        public string DesktopGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether the file system uses a KMS-managed key to encrypt data at rest. Encrypted data does not need to be decrypted during read and write operations.</para>
        /// <remarks>
        /// <para>NAS-managed keys are supported when <c>FileSystemType</c> is set to <c>standard</c> or <c>extreme</c>. User-managed keys are supported when <c>FileSystemType</c> is set to <c>extreme</c>.</para>
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
        /// <para>The region ID. You can call <a href="~~DescribeRegions~~">DescribeRegions</a> to query the regions supported by Elastic Desktop Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The storage specification type of the NAS file system.</para>
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
