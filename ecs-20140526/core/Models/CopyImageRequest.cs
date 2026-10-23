// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CopyImageRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The ClientToken parameter can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the copied image. The description must be 2 to 256 characters in length, and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a description example.</para>
        /// </summary>
        [NameInMap("DestinationDescription")]
        [Validation(Required=false)]
        public string DestinationDescription { get; set; }

        /// <summary>
        /// <para>The name of the copied image. The name must be 2 to 128 characters in length. It must start with a letter or a Chinese character, and cannot start with aliyun or acs:. It cannot contain http:// or https://. It can contain digits, periods (.), colons (:), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>YourImageName</para>
        /// </summary>
        [NameInMap("DestinationImageName")]
        [Validation(Required=false)]
        public string DestinationImageName { get; set; }

        /// <summary>
        /// <para>The ID of the destination region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("DestinationRegionId")]
        [Validation(Required=false)]
        public string DestinationRegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to only perform a dry run for this request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs a dry run. The system checks whether your AccessKey pair is valid, whether the Resource Access Management (RAM) user has authorization, and whether the required parameters are specified. If the request fails the dry run, the corresponding error message is returned. If the request passes the dry run, the DryRunOperation error code is returned.</description></item>
        /// <item><description>false: sends a Normal request. If the request passes the dry run, a 2XX HTTP status code is returned and the operation is performed.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>hide</para>
        /// </summary>
        [NameInMap("EncryptAlgorithm")]
        [Validation(Required=false)]
        public string EncryptAlgorithm { get; set; }

        /// <summary>
        /// <para>Specifies whether to encrypt the copied image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Encrypts the image.</description></item>
        /// <item><description>false: Does not encrypt the image.</description></item>
        /// <item><description>Not specified: The encryption status depends on the backend logic. For more information, see the supplementary description below.</description></item>
        /// </list>
        /// <para>Default value: none.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Encrypted")]
        [Validation(Required=false)]
        public bool? Encrypted { get; set; }

        /// <summary>
        /// <para>The ID of the source custom image.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-bp1h46wfpjsjastc****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The ID of the key used to encrypt the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e522b26d-abf6-4e0d-b5da-04b7******3c</para>
        /// </summary>
        [NameInMap("KMSKeyId")]
        [Validation(Required=false)]
        public string KMSKeyId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the source custom image. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID of the image after replication. If you do not specify this parameter, the image after replication belongs to the default resource group.</para>
        /// <remarks>
        /// <para>If you invoke this operation as a Resource Access Management (RAM) user and leave ResourceGroupId empty, note that if the Resource Access Management (RAM) user does not have permissions on the default resource group, the operation returns the <c>Forbidden: User not authorized to operate on the specified resource</c> error. Update the Settings of ResourceGroupId to the ID of a resource group on which the Resource Access Management (RAM) user has permissions, or use the corresponding Alibaba Cloud account to grant the Resource Access Management (RAM) user permissions on the default resource group, and then invoke this operation again.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CopyImageRequestTag> Tag { get; set; }
        public class CopyImageRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N of the copied image. Valid values of N: 1 to 20. If you specify this parameter, it cannot be an empty string. The tag key can be up to 128 characters in length. It cannot start with aliyun or acs:, and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N of the copied image. Valid values of N: 1 to 20. If you specify this parameter, it can be an empty string. The tag value can be up to 128 characters in length. It cannot start with acs:, and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
