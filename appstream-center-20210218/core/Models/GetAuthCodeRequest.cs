// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210218.Models
{
    public class GetAuthCodeRequest : TeaModel {
        [NameInMap("AutoCreateUser")]
        [Validation(Required=false)]
        public bool? AutoCreateUser { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("ExternalUserId")]
        [Validation(Required=false)]
        public string ExternalUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;Version&quot;: &quot;1&quot;,
        ///       &quot;Resource&quot;: {
        ///             &quot;Type&quot;: &quot;AppInstanceGroup&quot;,
        ///             &quot;Id&quot;: &quot;aig-9ciijz60n4xsv****&quot;
        ///       }
        /// }</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

    }

}
