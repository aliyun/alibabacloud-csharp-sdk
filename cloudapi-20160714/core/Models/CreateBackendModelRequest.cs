// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class CreateBackendModelRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>34e94fcd3e2e47a49824a89b8f92cb5e</para>
        /// </summary>
        [NameInMap("BackendId")]
        [Validation(Required=false)]
        public string BackendId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;ServiceAddress\&quot;:\&quot;<a href="http://apigateway-echo-redux.alicloudapi.com:8080%5C%5C%22%7D">http://apigateway-echo-redux.alicloudapi.com:8080\\&quot;}</a></para>
        /// </summary>
        [NameInMap("BackendModelData")]
        [Validation(Required=false)]
        public string BackendModelData { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("BackendType")]
        [Validation(Required=false)]
        public string BackendType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>model description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TEST</para>
        /// </summary>
        [NameInMap("StageName")]
        [Validation(Required=false)]
        public string StageName { get; set; }

    }

}
