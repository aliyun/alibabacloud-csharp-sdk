// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class SendTokenCodeRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f4a0dc8e-1702-4728-9a60-95b27a35****</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Windows_NT 10.0.18363 x64</para>
        /// </summary>
        [NameInMap("ClientOS")]
        [Validation(Required=false)]
        public string ClientOS { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2.1.0-R-20210731.151756</para>
        /// </summary>
        [NameInMap("ClientVersion")]
        [Validation(Required=false)]
        public string ClientVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>v28101ac6a9e69c66b04a163031680463660b4b216cd758f34b60b9ad6a7c7f7334b83dd8f75eef4209c68f9f1080b****</para>
        /// </summary>
        [NameInMap("LoginToken")]
        [Validation(Required=false)]
        public string LoginToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-2925105532</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cd45e873-650d-4d70-acb9-f996187a****</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>63****</para>
        /// </summary>
        [NameInMap("TokenCode")]
        [Validation(Required=false)]
        public string TokenCode { get; set; }

    }

}
