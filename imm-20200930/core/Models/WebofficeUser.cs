// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class WebofficeUser : TeaModel {
        /// <summary>
        /// <para>The custom URL of the avatar picture. The avatar picture is displayed on the WebOffice page.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example.com/?id=user1">http://example.com/?id=user1</a></para>
        /// </summary>
        [NameInMap("Avatar")]
        [Validation(Required=false)]
        public string Avatar { get; set; }

        /// <summary>
        /// <para>The custom user ID. The user ID is displayed on the WebOffice page. A user ID can contain letters and digits and cannot exceed 15 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user1</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The custom username. The username is displayed on the WebOffice page. The username must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>A username can contain digits, letters, hyphens (-), underscores (_), plus signs (+), forward slashes (/), equal signs (=), and at signs (@).</description></item>
        /// <item><description>A username can contain up to 32 characters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test-user1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
