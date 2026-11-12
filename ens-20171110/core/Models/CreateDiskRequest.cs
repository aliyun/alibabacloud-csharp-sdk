// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateDiskRequest : TeaModel {
        /// <summary>
        /// <para>The category of the cloud disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cloud_efficiency: ultra disk</description></item>
        /// <item><description>cloud_ssd: all-flash disk</description></item>
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
        /// <para>The name of the cloud disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourDiskName</para>
        /// </summary>
        [NameInMap("DiskName")]
        [Validation(Required=false)]
        public string DiskName { get; set; }

        /// <summary>
        /// <para>Specifies whether to encrypt the cloud disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: yes</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): no</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Encrypted")]
        [Validation(Required=false)]
        public bool? Encrypted { get; set; }

        /// <summary>
        /// <para>The edge zone ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-chengdu-telecom</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>The billing cycle of the instance. Valid values: Hour, Day, and Month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hour</para>
        /// </summary>
        [NameInMap("InstanceBillingCycle")]
        [Validation(Required=false)]
        public string InstanceBillingCycle { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Only <b>PostPaid</b> (pay-as-you-go) is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The ID of the Key Management Service (KMS) key used for the cloud disk.</para>
        /// <remarks>
        /// <para>If <b>Encrypted</b> is set to <b>true</b> and <b>KMSKeyId</b> is left empty, the default service key is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0e478b7a-4262-4802-b8cb-00d3fxxxxx</para>
        /// </summary>
        [NameInMap("KMSKeyId")]
        [Validation(Required=false)]
        public string KMSKeyId { get; set; }

        /// <summary>
        /// <para>The size of the cloud disk. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public string Size { get; set; }

        /// <summary>
        /// <para>The ID of the snapshot used to create the cloud disk.</para>
        /// <para>The <b>SnapshotId</b> and <b>Size</b> parameters are subject to the following limits:</para>
        /// <list type="bullet">
        /// <item><description><para>If snapshot size of the snapshot specified by <b>SnapshotId</b> is greater than the value of <b>Size</b>, snapshot size of the created cloud disk is equal to snapshot size of the snapshot.</para>
        /// </description></item>
        /// <item><description><para>If snapshot size of the snapshot specified by <b>SnapshotId</b> is less than the value of <b>Size</b>, snapshot size of the created cloud disk is equal to the value of <b>Size</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>s-897654321****</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// <para>The list of tags. You can add up to 20 tags in a single call.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDiskRequestTag> Tag { get; set; }
        public class CreateDiskRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N for the instance. Valid values of N: <b>1</b> to <b>20</b>.</para>
            /// <list type="bullet">
            /// <item><description>The key cannot start with <c>aliyun</c>, <c>acs:</c>, <c>http://</c>, or <c>https://</c>.</description></item>
            /// <item><description>The key can be up to 64 characters in length.</description></item>
            /// <item><description>The key cannot be an empty string.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pro</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N for the topic. <b>Key</b> and <b>Value</b> must be both specified or both left empty. If both are specified, the system filters topics that match the tag. If neither is specified, the system queries all topics.</para>
            /// <list type="bullet">
            /// <item><description>Valid values of N: 1 to 20.</description></item>
            /// <item><description>The value can be an empty string.</description></item>
            /// <item><description>The value can be up to 128 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>, or contain <c>http://</c> or <c>https://</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tagValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
