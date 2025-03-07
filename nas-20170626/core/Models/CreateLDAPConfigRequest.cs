// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateLDAPConfigRequest : TeaModel {
        /// <summary>
        /// <para>An LDAP entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn=alibaba,dc=com</para>
        /// </summary>
        [NameInMap("BindDN")]
        [Validation(Required=false)]
        public string BindDN { get; set; }

        /// <summary>
        /// <para>The ID of the file system.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>109c04****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>An LDAP search base.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dc=example</para>
        /// </summary>
        [NameInMap("SearchBase")]
        [Validation(Required=false)]
        public string SearchBase { get; set; }

        /// <summary>
        /// <para>An LDAP URI.</para>
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
