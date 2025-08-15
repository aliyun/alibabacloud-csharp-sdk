// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class StopLoggingRequest : TeaModel {
        /// <summary>
        /// <para>The name of the trail that you want to disable.</para>
        /// <para>The name must be 6 to 36 characters in length, and can contain lowercase letters, digits, hyphens (-), and underscores (_). It must start with a lowercase letter.</para>
        /// <remarks>
        /// <para>The name must be unique within your Alibaba Cloud account.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trail-test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
