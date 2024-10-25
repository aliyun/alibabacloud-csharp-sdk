// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ReinitInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the image file that is used to reset the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-5wn1dhz5syoo9b48f440ntvad</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-5vn4n3y4laeb2ii9zxxltlvzi</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The password of the instance.</para>
        /// <para>It must be 8 to 30 characters in length. It must include at least three of the following characters types: uppercase letters, lowercase letters, digits, and special characters. The following special character are supported: <c>()\\&quot;~! @#$%^&amp;*-_+={}[]:;\\&quot;&lt;&gt;,.?/</c></para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

    }

}
