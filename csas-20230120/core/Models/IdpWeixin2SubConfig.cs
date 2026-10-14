// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class IdpWeixin2SubConfig : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1000002</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>wwautha1b2c3****</para>
        /// </summary>
        [NameInMap("AppSchema")]
        [Validation(Required=false)]
        public string AppSchema { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>s1e2c3r4e5****</para>
        /// </summary>
        [NameInMap("AppSecret")]
        [Validation(Required=false)]
        public string AppSecret { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>wwa1b2c3d4****</para>
        /// </summary>
        [NameInMap("CorpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>a1e2s3k4e5****</para>
        /// </summary>
        [NameInMap("EventAesKey")]
        [Validation(Required=false)]
        public string EventAesKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://auth.example.com/callback/wework/a1b2">https://auth.example.com/callback/wework/a1b2</a>****</para>
        /// </summary>
        [NameInMap("EventLabel")]
        [Validation(Required=false)]
        public string EventLabel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>v1t2o3k4e5****</para>
        /// </summary>
        [NameInMap("EventVerifyToken")]
        [Validation(Required=false)]
        public string EventVerifyToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://auth.example.com/callback">https://auth.example.com/callback</a></para>
        /// </summary>
        [NameInMap("RedirectUri")]
        [Validation(Required=false)]
        public string RedirectUri { get; set; }

    }

}
