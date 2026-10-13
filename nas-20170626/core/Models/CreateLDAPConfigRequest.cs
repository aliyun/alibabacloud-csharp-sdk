// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateLDAPConfigRequest : TeaModel {
        /// <summary>
        /// <para>The distinguished name (DN) of the entry to bind to the LDAP directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn=alibaba,dc=com</para>
        /// </summary>
        [NameInMap("BindDN")]
        [Validation(Required=false)]
        public string BindDN { get; set; }

        /// <summary>
        /// <para>The file system ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>109c04****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The LDAP search base.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dc=example</para>
        /// </summary>
        [NameInMap("SearchBase")]
        [Validation(Required=false)]
        public string SearchBase { get; set; }

        /// <summary>
        /// <para>The LDAP server address.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ldap://ldap.example.example</para>
        /// </summary>
        [NameInMap("URI")]
        [Validation(Required=false)]
        public string URI { get; set; }

    }

}
