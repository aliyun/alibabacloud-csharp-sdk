// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCloudVendorProductTemplateConfigRequest : TeaModel {
        /// <summary>
        /// <para>Set the language type for request and response messages, default is <b>zh</b>. Values:</para>
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
        /// <para>Cloud asset vendor. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>CHAITIN</b>: Chaitin Technology</description></item>
        /// <item><description><b>FORTINET</b>: Fortinet</description></item>
        /// <item><description><b>THREATBOOK</b>: ThreatBook</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CHAITIN</para>
        /// </summary>
        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public string Vendor { get; set; }

    }

}
