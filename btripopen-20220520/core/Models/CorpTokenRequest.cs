// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CorpTokenRequest : TeaModel {
        /// <summary>
        /// <para><b>Required</b>. The API secret key of the application. For information about how to obtain it, refer to: <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=4667763">Application Basic Information - Application Credentials</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Z2FyYmE********ZlLXtMO3FKbiYqJSM</para>
        /// </summary>
        [NameInMap("app_secret")]
        [Validation(Required=false)]
        public string AppSecret { get; set; }

        /// <summary>
        /// <para>The enterprise agent ID, which is used to establish the bindingrelationship between the enterprise and the application. For information about how to obtain it, refer to: <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=4667765">Callable Enterprises</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>open********gcxvxv</para>
        /// </summary>
        [NameInMap("corp_id")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <para>The enterprise type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
