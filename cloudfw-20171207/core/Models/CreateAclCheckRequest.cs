// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateAclCheckRequest : TeaModel {
        /// <summary>
        /// <para>The type of the ACL check.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Internet</para>
        /// </summary>
        [NameInMap("AclType")]
        [Validation(Required=false)]
        public string AclType { get; set; }

        /// <summary>
        /// <para>The list of ACL check names.</para>
        /// <para><b>Note</b>: This parameter is required in actual calls. Provide at least one check name. If no check name is provided, the API returns ErrorParameters (-200103).</para>
        /// </summary>
        [NameInMap("CheckNames")]
        [Validation(Required=false)]
        public List<string> CheckNames { get; set; }

        /// <summary>
        /// <para>The language type of the request and response messages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
