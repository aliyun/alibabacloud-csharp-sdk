// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeRtcMPUEventSubRequest : TeaModel {
        /// <summary>
        /// <para>The ID of your application.</para>
        /// <remarks>
        /// <para>The ID can be up to 64 characters in length and can contain letters, digits, underscores, and hyphens (-).</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourAppId</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

    }

}
