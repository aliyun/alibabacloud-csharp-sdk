// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class IpWhiteListConfigRequest : TeaModel {
        /// <summary>
        /// <para>Required for add and delete operations. The IP whitelist. Separate multiple IP addresses with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60.205.254.120</para>
        /// </summary>
        [NameInMap("IpWhiteList")]
        [Validation(Required=false)]
        public string IpWhiteList { get; set; }

        /// <summary>
        /// <para>The operation type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ADD: Incrementally adds entries.</description></item>
        /// <item><description>DELETE: Deletes entries.</description></item>
        /// <item><description>QUERY: Queries entries.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>add</para>
        /// </summary>
        [NameInMap("Operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

    }

}
