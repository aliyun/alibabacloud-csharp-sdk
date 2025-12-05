// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class UpdateSecretVersionStageRequest : TeaModel {
        /// <summary>
        /// <para>The version from which you want to remove the specified stage label.</para>
        /// <remarks>
        /// <para> You must specify at least one of the RemoveFromVersion and MoveToVersion parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>002</para>
        /// </summary>
        [NameInMap("MoveToVersion")]
        [Validation(Required=false)]
        public string MoveToVersion { get; set; }

        /// <summary>
        /// <para>The specified stage label. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ACSCurrent</description></item>
        /// <item><description>ACSPrevious</description></item>
        /// <item><description>Custom stage label</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>001</para>
        /// </summary>
        [NameInMap("RemoveFromVersion")]
        [Validation(Required=false)]
        public string RemoveFromVersion { get; set; }

        /// <summary>
        /// <para>The operation that you want to perform. Set the value to <b>UpdateSecretVersionStage</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>secret001</para>
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        /// <summary>
        /// <para>The name of the secret.</para>
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
