// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeNoticeConfigRequest : TeaModel {
        /// <summary>
        /// <para>Notification configuration type, with values:</para>
        /// <list type="bullet">
        /// <item><description><b>Default (not provided)</b>: SMS/Email/Site Message </description></item>
        /// <item><description><b>cms</b>: Cloud Monitor Push</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cms</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60.191.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
