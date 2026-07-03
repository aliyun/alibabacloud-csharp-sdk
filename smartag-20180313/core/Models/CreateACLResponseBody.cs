// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class CreateACLResponseBody : TeaModel {
        /// <summary>
        /// <para>The access control instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acl-o6yol7zowii5n2****</para>
        /// </summary>
        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        /// <summary>
        /// <para>The type of the Smart Access Gateway instance associated with the access control instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acl-hardware</para>
        /// </summary>
        [NameInMap("AclType")]
        [Validation(Required=false)]
        public string AclType { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE837E9F-BD50-4C2B-9E47-260F9D848480</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource group ID of the access control instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm2iu4fnc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
