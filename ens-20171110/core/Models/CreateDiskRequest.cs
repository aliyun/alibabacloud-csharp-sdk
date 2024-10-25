// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateDiskRequest : TeaModel {
        /// <summary>
        /// <para>The category of the disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cloud_efficiency: ultra disk.</description></item>
        /// <item><description>cloud_ssd: all-flash disk.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_efficiency</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The name of the disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourDiskName</para>
        /// </summary>
        [NameInMap("DiskName")]
        [Validation(Required=false)]
        public string DiskName { get; set; }

        /// <summary>
        /// <para>Specifies whether to encrypt the new system disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default): no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Encrypted")]
        [Validation(Required=false)]
        public bool? Encrypted { get; set; }

        /// <summary>
        /// <para>The ID of the edge node.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-chengdu-telecom</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Set the value to <b>PostPaid</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The ID of the Key Management Service (KMS) key that is used by the cloud disk.</para>
        /// <remarks>
        /// <para> If you set the <b>Encrypted</b> parameter to <b>true</b>, the default service key is used when the <b>KMSKeyId</b> parameter is empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0e478b7a-4262-4802-b8cb-00d3fxxxxx</para>
        /// </summary>
        [NameInMap("KMSKeyId")]
        [Validation(Required=false)]
        public string KMSKeyId { get; set; }

        /// <summary>
        /// <para>The size of the disk. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public string Size { get; set; }

        /// <summary>
        /// <para>The ID of the snapshot that you want to use to create the disk.</para>
        /// <para>The following limits apply to the <b>SnapshotId</b> and <b>Size</b> parameters:</para>
        /// <list type="bullet">
        /// <item><description>If the size of the snapshot specified by <b>SnapshotId</b> is greater than the specified <b>Size</b> value, the size of the created disk is equal to the specified snapshot size.</description></item>
        /// <item><description>If the size of the snapshot specified by <b>SnapshotId</b> is smaller than the specified <b>Size</b> value, the size of the created disk is equal to the specified <b>Size</b> value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>s-897654321****</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDiskRequestTag> Tag { get; set; }
        public class CreateDiskRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
