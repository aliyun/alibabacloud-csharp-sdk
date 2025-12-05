// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class DescribeKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The metadata of the CMK.</para>
        /// </summary>
        [NameInMap("KeyMetadata")]
        [Validation(Required=false)]
        public DescribeKeyResponseBodyKeyMetadata KeyMetadata { get; set; }
        public class DescribeKeyResponseBodyKeyMetadata : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the CMK.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:kms:cn-hangzhou:154035569884****:key/05754286-3ba2-4fa6-8d41-4323aca6****</para>
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

            /// <summary>
            /// <para>Indicates whether automatic key rotation is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Enabled</description></item>
            /// <item><description>Disabled</description></item>
            /// <item><description>Suspended</description></item>
            /// </list>
            /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/134270.html">Automatic key rotation</a>.</para>
            /// <remarks>
            /// <para> Only symmetric CMKs support automatic key rotation.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Disabled</para>
            /// </summary>
            [NameInMap("AutomaticRotation")]
            [Validation(Required=false)]
            public string AutomaticRotation { get; set; }

            /// <summary>
            /// <para>The time when the CMK was created. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-20T06:34:21Z</para>
            /// </summary>
            [NameInMap("CreationDate")]
            [Validation(Required=false)]
            public string CreationDate { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account that is used to create the CMK.</para>
            /// 
            /// <b>Example:</b>
            /// <para>154035569884****</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

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
            /// <para>The time at which the CMK is scheduled for deletion. The time is displayed in UTC.</para>
            /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/44196.html">ScheduleKeyDeletion</a>.</para>
            /// <remarks>
            /// <para> This parameter is returned only when the value of the KeyState parameter is PendingDeletion.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-26T18:22:03Z</para>
            /// </summary>
            [NameInMap("DeleteDate")]
            [Validation(Required=false)]
            public string DeleteDate { get; set; }

            /// <summary>
            /// <para>Indicates whether deletion protection is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Enabled</description></item>
            /// <item><description>Disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("DeletionProtection")]
            [Validation(Required=false)]
            public string DeletionProtection { get; set; }

            /// <summary>
            /// <para>The description of deletion protection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The CMK is being used by XXX. Deletion protection is set.</para>
            /// </summary>
            [NameInMap("DeletionProtectionDescription")]
            [Validation(Required=false)]
            public string DeletionProtectionDescription { get; set; }

            /// <summary>
            /// <para>The description of the CMK.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key description example</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the CMK. The ID must be globally unique.</para>
            /// 
            /// <b>Example:</b>
            /// <para>05754286-3ba2-4fa6-8d41-4323aca6****</para>
            /// </summary>
            [NameInMap("KeyId")]
            [Validation(Required=false)]
            public string KeyId { get; set; }

            /// <summary>
            /// <para>The type of the CMK.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Aliyun_AES_256</para>
            /// </summary>
            [NameInMap("KeySpec")]
            [Validation(Required=false)]
            public string KeySpec { get; set; }

            /// <summary>
            /// <para>The status of the CMK.</para>
            /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/44211.html">Impact of CMK status on API operations</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("KeyState")]
            [Validation(Required=false)]
            public string KeyState { get; set; }

            /// <summary>
            /// <para>The usage of the CMK.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ENCRYPT/DECRYPT</para>
            /// </summary>
            [NameInMap("KeyUsage")]
            [Validation(Required=false)]
            public string KeyUsage { get; set; }

            /// <summary>
            /// <para>The time when the last rotation was performed. The time is displayed in UTC. For a new CMK, the value of this parameter is the time when the initial version of the CMK was generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-20T06:34:21Z</para>
            /// </summary>
            [NameInMap("LastRotationDate")]
            [Validation(Required=false)]
            public string LastRotationDate { get; set; }

            /// <summary>
            /// <para>The time when the key material expires. The time is displayed in UTC. If this parameter value is empty, the key material does not expire.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-06T18:22:03Z</para>
            /// </summary>
            [NameInMap("MaterialExpireTime")]
            [Validation(Required=false)]
            public string MaterialExpireTime { get; set; }

            /// <summary>
            /// <para>The time when the next rotation will be performed.</para>
            /// <remarks>
            /// <para> This parameter is returned only when the value of the AutomaticRotation parameter is Enabled or Suspended.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-06T18:22:03Z</para>
            /// </summary>
            [NameInMap("NextRotationDate")]
            [Validation(Required=false)]
            public string NextRotationDate { get; set; }

            /// <summary>
            /// <para>The source of the key material for the CMK.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Aliyun_KMS</para>
            /// </summary>
            [NameInMap("Origin")]
            [Validation(Required=false)]
            public string Origin { get; set; }

            /// <summary>
            /// <para>The ID of the current primary key version for the symmetric CMK.</para>
            /// 
            /// <b>Example:</b>
            /// <para>515e0b0a-624f-45ab-92b5-54f9b551****</para>
            /// </summary>
            [NameInMap("PrimaryKeyVersion")]
            [Validation(Required=false)]
            public string PrimaryKeyVersion { get; set; }

            /// <summary>
            /// <para>The protection level of the CMK.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HSM</para>
            /// </summary>
            [NameInMap("ProtectionLevel")]
            [Validation(Required=false)]
            public string ProtectionLevel { get; set; }

            /// <summary>
            /// <para>The interval for automatic key rotation.</para>
            /// <para>Unit: seconds.</para>
            /// <para>For example, if the value is 604800s, automatic key rotation is performed at a 7-day interval.</para>
            /// <remarks>
            /// <para> This parameter is returned only when the value of the AutomaticRotation parameter is Enabled or Suspended.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>31536000s</para>
            /// </summary>
            [NameInMap("RotationInterval")]
            [Validation(Required=false)]
            public string RotationInterval { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f1fdfa9d-bd49-418b-942f-8f3e3ec00a4f</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
