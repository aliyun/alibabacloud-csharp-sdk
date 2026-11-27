// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetAklessTmpIdentityForPartnerRequest : TeaModel {
        /// <summary>
        /// <para>The source system code for the call. This parameter is optional. This field is reserved for future extensions. Currently, the credential retrieval role is selected based on RoleCode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>clouddream</para>
        /// </summary>
        [NameInMap("AppCode")]
        [Validation(Required=false)]
        public string AppCode { get; set; }

        /// <summary>
        /// <para>The zero-trust role code, which is case-sensitive. The default code ai-website-clouddream-oem corresponds to the OEM role, and ai-website-clouddream-oem-provider corresponds to the OEM service provider role. Specify one code per request.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ai-website-clouddream-oem</para>
        /// </summary>
        [NameInMap("RoleCode")]
        [Validation(Required=false)]
        public string RoleCode { get; set; }

    }

}
