// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class PublishIndexVersionRequest : TeaModel {
        /// <summary>
        /// <para>The request body.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        /// &quot;dataSource&quot;: &quot;ha-cn-pl32rf0****_test_api&quot;,
        /// &quot;desc&quot;: &quot;Remarks&quot;
        /// }</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public Dictionary<string, object> Body { get; set; }

    }

}
