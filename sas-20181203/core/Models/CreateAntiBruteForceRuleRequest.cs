// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateAntiBruteForceRuleRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to set the defense rule as the default rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DefaultRule")]
        [Validation(Required=false)]
        public bool? DefaultRule { get; set; }

        /// <summary>
        /// <para>The maximum number of failed logon attempts from an account. Valid values: 2, 3, 4, 5, 10, 50, 80, and 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("FailCount")]
        [Validation(Required=false)]
        public int? FailCount { get; set; }

        /// <summary>
        /// <para>The period of time during which logons from an account are not allowed. Unit: minutes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>5</b></description></item>
        /// <item><description><b>15</b></description></item>
        /// <item><description><b>30</b></description></item>
        /// <item><description><b>60</b></description></item>
        /// <item><description><b>120</b></description></item>
        /// <item><description><b>360</b></description></item>
        /// <item><description><b>720</b></description></item>
        /// <item><description><b>1440</b></description></item>
        /// <item><description><b>10080</b></description></item>
        /// <item><description><b>52560000</b>: permanent</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ForbiddenTime")]
        [Validation(Required=false)]
        public int? ForbiddenTime { get; set; }

        /// <summary>
        /// <para>The name of the defense rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestAntiBruteForceRule</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The types of protocols supported for interception by the brute force attack rule creation.</para>
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public CreateAntiBruteForceRuleRequestProtocolType ProtocolType { get; set; }
        public class CreateAntiBruteForceRuleRequestProtocolType : TeaModel {
            /// <summary>
            /// <para>Whether to enable RDP interception, default is on. Values: </para>
            /// <list type="bullet">
            /// <item><description><b>on</b>: Enable </description></item>
            /// <item><description><b>off</b>: Disable</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Rdp")]
            [Validation(Required=false)]
            public string Rdp { get; set; }

            /// <summary>
            /// <para>Whether to enable the SqlServer interception method, default is off. Values: </para>
            /// <list type="bullet">
            /// <item><description><b>on</b>: Enable </description></item>
            /// <item><description><b>off</b>: Disable</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("SqlServer")]
            [Validation(Required=false)]
            public string SqlServer { get; set; }

            /// <summary>
            /// <para>Whether to enable SSH interception, default is on. Values: </para>
            /// <list type="bullet">
            /// <item><description><b>on</b>: Enable </description></item>
            /// <item><description><b>off</b>: Disable</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Ssh")]
            [Validation(Required=false)]
            public string Ssh { get; set; }

        }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The maximum period of time during which failed logon attempts from an account can occur. Unit: minutes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b></description></item>
        /// <item><description><b>2</b></description></item>
        /// <item><description><b>5</b></description></item>
        /// <item><description><b>10</b></description></item>
        /// <item><description><b>15</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> To configure a defense rule, you must specify the Span, FailCount, and ForbiddenTime parameters. If the number of failed logon attempts from an account within the minutes specified by Span exceeds the value specified by FailCount, the account cannot be used for logons within the minutes specified by ForbiddenTime.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Span")]
        [Validation(Required=false)]
        public int? Span { get; set; }

        /// <summary>
        /// <para>The UUIDs of the servers to which you want to apply the defense rule.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public List<string> UuidList { get; set; }

    }

}
