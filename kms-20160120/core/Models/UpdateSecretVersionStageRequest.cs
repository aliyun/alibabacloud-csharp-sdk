// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class UpdateSecretVersionStageRequest : TeaModel {
        /// <summary>
        /// <para>The version number of the secret. This parameter specifies that the version stage set by VersionStage is attached to this version.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>You must specify at least one of RemoveFromVersion and MoveToVersion.</para>
        /// </description></item>
        /// <item><description><para>If you set VersionStage to ACSCurrent or ACSPrevious, you must specify this parameter.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>002</para>
        /// </summary>
        [NameInMap("MoveToVersion")]
        [Validation(Required=false)]
        public string MoveToVersion { get; set; }

        /// <summary>
        /// <para>The version number of the secret. This parameter specifies that the version stage set by VersionStage is removed from this version.</para>
        /// <remarks>
        /// <para>You must specify at least one of RemoveFromVersion and MoveToVersion.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>001</para>
        /// </summary>
        [NameInMap("RemoveFromVersion")]
        [Validation(Required=false)]
        public string RemoveFromVersion { get; set; }

        /// <summary>
        /// <para>The name or Alibaba Cloud Resource Name (ARN) of the secret.</para>
        /// <remarks>
        /// <para>To access a secret in a different Alibaba Cloud account, you must specify the ARN of the secret. The ARN is in the format of <c>acs:kms:${region}:${account}:secret/${secret-name}</c>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>secret001</para>
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        /// <summary>
        /// <para>The version stage of the secret.</para>
        /// <para><b>Scenario 1: Add a version stage to a specified secret version.</b></para>
        /// <para>Specify this parameter and MoveToVersion. Do not specify RemoveFromVersion. This parameter can be set to ACSCurrent, ACSPrevious, or a custom stage.</para>
        /// <para><b>Scenario 2: Remove a version stage from a specified secret version.</b></para>
        /// <para>Specify this parameter and RemoveFromVersion. Do not specify MoveToVersion. This parameter must be set to a custom stage.</para>
        /// <remarks>
        /// <para>ACSCurrent and ACSPrevious are system-reserved stages. You cannot directly remove them. You can only remove them from one secret version and attach them to another.</para>
        /// </remarks>
        /// <para><b>Scenario 3: Remove a version stage from a specified secret version and attach it to another secret version.</b></para>
        /// <para>Specify this parameter, MoveToVersion, and RemoveFromVersion. This parameter can be set to ACSCurrent, ACSPrevious, or a custom stage.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACSCurrent</para>
        /// </summary>
        [NameInMap("VersionStage")]
        [Validation(Required=false)]
        public string VersionStage { get; set; }

    }

}
