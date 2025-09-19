// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeSafConsoleRequest : TeaModel {
        /// <summary>
        /// <para>Set the language type for requests and received messages, default value is <b>zh</b>. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Query content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ei_riskLpInfo</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>Service to be called.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ei_riskLpInfo</para>
        /// </summary>
        [NameInMap("service")]
        [Validation(Required=false)]
        public string Service { get; set; }

    }

}
