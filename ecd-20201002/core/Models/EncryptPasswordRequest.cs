// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class EncryptPasswordRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1d40776f-e9cb-4e2b-a8da-308d10e8****</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing+dir-131196****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1b16dcff3ab21a6c5ec01652238375511cff5a1db59fd4dc49afb37e2ea7a626af6f38109fd0498b6abd9de1af7743****</para>
        /// </summary>
        [NameInMap("LoginToken")]
        [Validation(Required=false)]
        public string LoginToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing+dir-131196****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ab123456</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c78e2e52-23d9-4401-a648-e67ac6ff****</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
