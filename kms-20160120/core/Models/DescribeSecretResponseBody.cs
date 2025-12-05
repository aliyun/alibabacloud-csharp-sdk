// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class DescribeSecretResponseBody : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the secret.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:kms:cn-hangzhou:154035569884****:secret/secret001</para>
        /// </summary>
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public string Arn { get; set; }

        /// <summary>
        /// <para>Indicates whether automatic rotation is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled: indicates that automatic rotation is enabled.</description></item>
        /// <item><description>Disabled: indicates that automatic rotation is disabled.</description></item>
        /// <item><description>Invalid: indicates that the status of automatic rotation is abnormal. In this case, Secrets Manager cannot automatically rotate the secret.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is returned only for a managed ApsaraDB RDS secret, a managed RAM secret, or a managed ECS secret.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("AutomaticRotation")]
        [Validation(Required=false)]
        public string AutomaticRotation { get; set; }

        /// <summary>
        /// <para>The time when the secret was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-02-21T15:39:26Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The ID of the dedicated KMS instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kst-bjj62d8f5e0sgtx8h****</para>
        /// </summary>
        [NameInMap("DKMSInstanceId")]
        [Validation(Required=false)]
        public string DKMSInstanceId { get; set; }

        /// <summary>
        /// <para>The description of the secret.</para>
        /// 
        /// <b>Example:</b>
        /// <para>userinfo</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the customer master key (CMK) that is used to encrypt the secret value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00aa68af-2c02-4f68-95fe-3435d330****</para>
        /// </summary>
        [NameInMap("EncryptionKeyId")]
        [Validation(Required=false)]
        public string EncryptionKeyId { get; set; }

        /// <summary>
        /// <para>The extended configuration of the secret.</para>
        /// <remarks>
        /// <para> This parameter is returned only for a managed ApsaraDB RDS secret, a managed Resource Access Management (RAM) secret, or a managed Elastic Compute Service (ECS) secret.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;SecretSubType\&quot;:\&quot;SingleUser\&quot;, \&quot;DBInstanceId\&quot;:\&quot;rm-uf667446pc955****\&quot;,  \&quot;CustomData\&quot;:{} }</para>
        /// </summary>
        [NameInMap("ExtendedConfig")]
        [Validation(Required=false)]
        public string ExtendedConfig { get; set; }

        /// <summary>
        /// <para>The time when the last rotation was performed.</para>
        /// <remarks>
        /// <para> This parameter is returned if the secret was rotated.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-05T08:22:03Z</para>
        /// </summary>
        [NameInMap("LastRotationDate")]
        [Validation(Required=false)]
        public string LastRotationDate { get; set; }

        /// <summary>
        /// <para>The time when the next rotation will be performed.</para>
        /// <remarks>
        /// <para> This parameter is returned when automatic rotation is enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-06T18:22:03Z</para>
        /// </summary>
        [NameInMap("NextRotationDate")]
        [Validation(Required=false)]
        public string NextRotationDate { get; set; }

        [NameInMap("OwingService")]
        [Validation(Required=false)]
        public string OwingService { get; set; }

        /// <summary>
        /// <para>The time when the secret is scheduled to be deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-03-21T15:45:12Z</para>
        /// </summary>
        [NameInMap("PlannedDeleteTime")]
        [Validation(Required=false)]
        public string PlannedDeleteTime { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>93348dfb-3627-4417-8d90-487a76a909c9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The interval for automatic rotation.</para>
        /// <para>The value is in the <c>integer[unit]</c> format. <c>integer</c> indicates the length of time. <c>unit</c>: indicates the time unit. The value of <c>unit</c> is fixed as s. For example, if the value is 604800s, automatic rotation is performed at a 7-day interval.</para>
        /// <remarks>
        /// <para> This parameter is returned when automatic rotation is enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3153600s</para>
        /// </summary>
        [NameInMap("RotationInterval")]
        [Validation(Required=false)]
        public string RotationInterval { get; set; }

        /// <summary>
        /// <para>The name of the secret.</para>
        /// 
        /// <b>Example:</b>
        /// <para>secret001</para>
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        /// <summary>
        /// <para>The type of the secret. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Generic: indicates a generic secret.</description></item>
        /// <item><description>Rds: indicates a managed ApsaraDB RDS secret.</description></item>
        /// <item><description>RAMCredentials: indicates a managed RAM secret.</description></item>
        /// <item><description>ECS: indicates a managed ECS secret.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Rds</para>
        /// </summary>
        [NameInMap("SecretType")]
        [Validation(Required=false)]
        public string SecretType { get; set; }

        /// <summary>
        /// <para>The resource tags of the secret.</para>
        /// <para>This parameter is not returned if you set the FetchTags parameter to false or you do not specify the FetchTags parameter.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeSecretResponseBodyTags Tags { get; set; }
        public class DescribeSecretResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeSecretResponseBodyTagsTag> Tag { get; set; }
            public class DescribeSecretResponseBodyTagsTag : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key1</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>val1</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

        /// <summary>
        /// <para>The time when the secret was updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-02-21T15:39:26Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
