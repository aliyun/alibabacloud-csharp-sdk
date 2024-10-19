// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ResetAppSecretRequest : TeaModel {
        /// <summary>
        /// <para>The key of the application that is used to make an API call.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60030986</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// <para>The new AppKey that you set must be globally unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testAppKey</para>
        /// </summary>
        [NameInMap("NewAppKey")]
        [Validation(Required=false)]
        public string NewAppKey { get; set; }

        /// <summary>
        /// <para>The new key of the application. To improve compatibility, we recommend that you use other parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test***</para>
        /// </summary>
        [NameInMap("NewAppSecret")]
        [Validation(Required=false)]
        public string NewAppSecret { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
