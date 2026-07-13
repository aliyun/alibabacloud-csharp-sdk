// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ListCloudGtmMonitorNodesRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh-CN</b>: Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en-US</b> (default): English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        [NameInMap("ShowDisabledNodes")]
        [Validation(Required=false)]
        public bool? ShowDisabledNodes { get; set; }

    }

}
