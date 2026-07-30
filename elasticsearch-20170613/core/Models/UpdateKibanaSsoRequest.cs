// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateKibanaSsoRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable Alibaba Cloud account authentication for Kibana. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enable.</description></item>
        /// <item><description>false: Disable.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public string Enable { get; set; }

        /// <summary>
        /// <para>PUBLIC, PRIVATE</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC, PRIVATE</para>
        /// </summary>
        [NameInMap("networkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

    }

}
