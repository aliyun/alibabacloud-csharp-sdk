// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ResetAppCodeRequest : TeaModel {
        /// <summary>
        /// <para>The AppCode of the app.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3aaf905a0a1f4f0eabc6d891dfa08afc</para>
        /// </summary>
        [NameInMap("AppCode")]
        [Validation(Required=false)]
        public string AppCode { get; set; }

        /// <summary>
        /// <para>The new AppCode of the app.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6f0e7ab2aa5f4b8fb18421e6edf4fb6c2</para>
        /// </summary>
        [NameInMap("NewAppCode")]
        [Validation(Required=false)]
        public string NewAppCode { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
