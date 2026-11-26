// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class UpdateSCIMServerCredentialStatusRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the SCIM credential.</para>
        /// 
        /// <b>Example:</b>
        /// <para>scimcred-004whl0kvfwcypbi****</para>
        /// </summary>
        [NameInMap("CredentialId")]
        [Validation(Required=false)]
        public string CredentialId { get; set; }

        /// <summary>
        /// <para>The directory ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00fc2p61****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The status of the SCIM credential. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled: Enabled.</description></item>
        /// <item><description>Disabled: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Disabled</para>
        /// </summary>
        [NameInMap("NewStatus")]
        [Validation(Required=false)]
        public string NewStatus { get; set; }

    }

}
