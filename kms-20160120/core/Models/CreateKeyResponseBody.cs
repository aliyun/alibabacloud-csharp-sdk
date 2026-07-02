// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CreateKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The metadata of the key.</para>
        /// </summary>
        [NameInMap("KeyMetadata")]
        [Validation(Required=false)]
        public CreateKeyResponseBodyKeyMetadata KeyMetadata { get; set; }
        public class CreateKeyResponseBodyKeyMetadata : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:kms:cn-qingdao:154035569884****:key/key-hzz62f1cb66fa42qo****</para>
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

            /// <summary>
            /// <para>Indicates whether automatic key rotation is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Enabled: Automatic rotation is enabled.</para>
            /// </description></item>
            /// <item><description><para>Disabled: Automatic rotation is disabled.</para>
            /// </description></item>
            /// <item><description><para>Suspended: Automatic rotation is suspended.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("AutomaticRotation")]
            [Validation(Required=false)]
            public string AutomaticRotation { get; set; }

            /// <summary>
            /// <para>The date and time when the key was created. The time is in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-25T10:00:00Z</para>
            /// </summary>
            [NameInMap("CreationDate")]
            [Validation(Required=false)]
            public string CreationDate { get; set; }

            /// <summary>
            /// <para>The creator of the key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>154035569884****</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The ID of the KMS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kst-bjj62d8f5e0sgtx8h****</para>
            /// </summary>
            [NameInMap("DKMSInstanceId")]
            [Validation(Required=false)]
            public string DKMSInstanceId { get; set; }

            /// <summary>
            /// <para>The scheduled time to delete the key. For more information, see <a href="https://help.aliyun.com/document_detail/601417.html">ScheduleKeyDeletion</a> .</para>
            /// <para>This parameter is returned only when the value of KeyState is PendingDeletion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-03-25T10:00:00Z</para>
            /// </summary>
            [NameInMap("DeleteDate")]
            [Validation(Required=false)]
            public string DeleteDate { get; set; }

            /// <summary>
            /// <para>The description of the key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key description example</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The globally unique identifier (GUID) of the key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key-hzz62f1cb66fa42qo****</para>
            /// </summary>
            [NameInMap("KeyId")]
            [Validation(Required=false)]
            public string KeyId { get; set; }

            /// <summary>
            /// <para>The specification of the key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Aliyun_AES_256</para>
            /// </summary>
            [NameInMap("KeySpec")]
            [Validation(Required=false)]
            public string KeySpec { get; set; }

            /// <summary>
            /// <para>The status of the key.<br> For more information, see <a href="https://help.aliyun.com/document_detail/44211.html">Impact of CMK status on API calls</a>.<br></para>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("KeyState")]
            [Validation(Required=false)]
            public string KeyState { get; set; }

            /// <summary>
            /// <para>The usage of the key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ENCRYPT/DECRYPT</para>
            /// </summary>
            [NameInMap("KeyUsage")]
            [Validation(Required=false)]
            public string KeyUsage { get; set; }

            /// <summary>
            /// <para>The time when the last rotation was performed. The time is in UTC.<br> If the key is new, this value is the generation time of the initial key version.<br></para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-25T10:00:00Z</para>
            /// </summary>
            [NameInMap("LastRotationDate")]
            [Validation(Required=false)]
            public string LastRotationDate { get; set; }

            /// <summary>
            /// <para>The expiration time of the key material. The time is in UTC.<br> If this value is empty, the key material does not expire.<br></para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-03-25T10:00:00Z</para>
            /// </summary>
            [NameInMap("MaterialExpireTime")]
            [Validation(Required=false)]
            public string MaterialExpireTime { get; set; }

            /// <summary>
            /// <para>The time when the next rotation is scheduled.</para>
            /// <para>This parameter is returned only when the value of AutomaticRotation is Enabled or Suspended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-25T10:00:00Z</para>
            /// </summary>
            [NameInMap("NextRotationDate")]
            [Validation(Required=false)]
            public string NextRotationDate { get; set; }

            /// <summary>
            /// <para>The source of the key material.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Aliyun_KMS</para>
            /// </summary>
            [NameInMap("Origin")]
            [Validation(Required=false)]
            public string Origin { get; set; }

            /// <summary>
            /// <para>The ID of the current primary version of the key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7ce1d081-06cb-42e6-aab6-5c5de030****</para>
            /// </summary>
            [NameInMap("PrimaryKeyVersion")]
            [Validation(Required=false)]
            public string PrimaryKeyVersion { get; set; }

            /// <summary>
            /// <para>The protection level of the key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SOFTWARE</para>
            /// </summary>
            [NameInMap("ProtectionLevel")]
            [Validation(Required=false)]
            public string ProtectionLevel { get; set; }

            /// <summary>
            /// <para>The automatic rotation period of the key. The value is in seconds. The value is an integer followed by the character s. For example, a rotation period of 7 days is 604800s.</para>
            /// <para>This parameter is returned only when the value of AutomaticRotation is Enabled or Suspended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>31536000s</para>
            /// </summary>
            [NameInMap("RotationInterval")]
            [Validation(Required=false)]
            public string RotationInterval { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. This ID is a globally unique identifier (GUID) generated by Alibaba Cloud for the request. Use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>381D5D33-BB8F-395F-8EE4-AE3BB4B523C4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
