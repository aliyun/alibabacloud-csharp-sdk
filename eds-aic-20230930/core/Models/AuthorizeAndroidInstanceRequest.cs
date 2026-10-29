// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class AuthorizeAndroidInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The list of instance IDs.</para>
        /// </summary>
        [NameInMap("AndroidInstanceIds")]
        [Validation(Required=false)]
        public List<string> AndroidInstanceIds { get; set; }

        /// <summary>
        /// <para>The ID of the user to assign.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("AuthorizeUserId")]
        [Validation(Required=false)]
        public string AuthorizeUserId { get; set; }

        /// <summary>
        /// <para>The ID of the user to unassign.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("UnAuthorizeUserId")]
        [Validation(Required=false)]
        public string UnAuthorizeUserId { get; set; }

    }

}
