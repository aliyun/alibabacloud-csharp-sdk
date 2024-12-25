// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class CreateAccessControlListResponseBody : TeaModel {
        /// <summary>
        /// <para>The IP version. Valid values: <b>ipv4</b> and <b>ipv6</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acl-rj9xpxzcwxrukois****</para>
        /// </summary>
        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>988CB45E-1643-48C0-87B4-928DDF77EA49</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
