// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSecureSuggestionRequest : TeaModel {
        /// <summary>
        /// <para>Choose to query the new or old version of the security score rules. When the value is <b>home_security_score</b>, it queries the new version of the security score rules; otherwise, it defaults to querying the old version of the security score rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>home_security_score</para>
        /// </summary>
        [NameInMap("CalType")]
        [Validation(Required=false)]
        public string CalType { get; set; }

        /// <summary>
        /// <para>The language type for request and response messages, default is <b>zh</b>. Values:</para>
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
        /// <para>Resource directory member account ID (Alibaba Cloud account).</para>
        /// <remarks>
        /// <para>You can obtain this parameter by calling the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> API.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1232428423234****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>Source of the security score. If left empty, it defaults to Cloud Security Center. Enumerated values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: Cloud Security Center.</para>
        /// </description></item>
        /// <item><description><para>1: Yaochi Console.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public int? Source { get; set; }

        /// <summary>
        /// <para>The IP address of the access source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
