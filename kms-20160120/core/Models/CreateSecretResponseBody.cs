// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CreateSecretResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>acs:kms:cn-hangzhou:154035569884****:secret/mydbconninfo</para>
        /// </summary>
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public string Arn { get; set; }

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
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("AutomaticRotation")]
        [Validation(Required=false)]
        public string AutomaticRotation { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>kst-bjj62d8f5e0sgtx8h****</para>
        /// </summary>
        [NameInMap("DKMSInstanceId")]
        [Validation(Required=false)]
        public string DKMSInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;SecretSubType\&quot;:\&quot;SingleUser\&quot;, \&quot;DBInstanceId\&quot;:\&quot;rm-uf667446pc955****\&quot;,  \&quot;CustomData\&quot;:{} }</para>
        /// </summary>
        [NameInMap("ExtendedConfig")]
        [Validation(Required=false)]
        public string ExtendedConfig { get; set; }

        /// <summary>
        /// <para>The extended configuration of the secret.</para>
        /// <remarks>
        /// <para> This parameter is returned if you set the SecretType parameter to Rds, RAMCredentials, or ECS.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-06T18:22:03Z</para>
        /// </summary>
        [NameInMap("NextRotationDate")]
        [Validation(Required=false)]
        public string NextRotationDate { get; set; }

        /// <summary>
        /// <para>The time when the next rotation will be performed.</para>
        /// <remarks>
        /// <para> This parameter is returned if automatic rotation is enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3bf02f7a-015b-4f93-be0f-cc043fda2dd3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>604800s</para>
        /// </summary>
        [NameInMap("RotationInterval")]
        [Validation(Required=false)]
        public string RotationInterval { get; set; }

        /// <summary>
        /// <para>The interval for automatic rotation.</para>
        /// <para>The value is in the <c>integer[unit]</c> format. The value of the <c>unit</c> field is fixed as s. For example, if the value is 604800s, automatic rotation is performed at a 7-day interval.</para>
        /// <remarks>
        /// <para> This parameter is returned if automatic rotation is enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>mydbconninfo</para>
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        /// <summary>
        /// <para>The ID of the dedicated KMS instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Rds</para>
        /// </summary>
        [NameInMap("SecretType")]
        [Validation(Required=false)]
        public string SecretType { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the secret.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
