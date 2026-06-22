// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyAntiBruteForceRuleRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the defense rule against brute-force attacks is set as the default policy in Settings. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The rule is set as the default policy.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The rule is not set as the default policy.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DefaultRule")]
        [Validation(Required=false)]
        public bool? DefaultRule { get; set; }

        /// <summary>
        /// <para>The threshold for the number of logon failures. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2</b>: 2 times</description></item>
        /// <item><description><b>3</b>: 3 times</description></item>
        /// <item><description><b>4</b>: 4 times</description></item>
        /// <item><description><b>5</b>: 5 times</description></item>
        /// <item><description><b>10</b>: 10 times</description></item>
        /// <item><description><b>50</b>: 50 times</description></item>
        /// <item><description><b>80</b>: 80 times</description></item>
        /// <item><description><b>100</b>: 100 times.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("FailCount")]
        [Validation(Required=false)]
        public int? FailCount { get; set; }

        /// <summary>
        /// <para>The duration for which logon is prohibited, in minutes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>5</b>: 5 minutes</description></item>
        /// <item><description><b>15</b>: 15 minutes</description></item>
        /// <item><description><b>30</b>: 30 minutes</description></item>
        /// <item><description><b>60</b>: 1 hour</description></item>
        /// <item><description><b>120</b>: 2 hours</description></item>
        /// <item><description><b>360</b>: 6 hours</description></item>
        /// <item><description><b>720</b>: 12 hours</description></item>
        /// <item><description><b>1440</b>: 24 hours</description></item>
        /// <item><description><b>10080</b>: 7 days</description></item>
        /// <item><description><b>52560000</b>: permanent (100 years).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ForbiddenTime")]
        [Validation(Required=false)]
        public int? ForbiddenTime { get; set; }

        /// <summary>
        /// <para>The ID of the defense rule against brute-force attacks.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>65778</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The name of the defense rule against brute-force attacks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestRule</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The protocol types that the defense rule against brute-force attacks supports for interception.</para>
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public ModifyAntiBruteForceRuleRequestProtocolType ProtocolType { get; set; }
        public class ModifyAntiBruteForceRuleRequestProtocolType : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable RDP interception. This is enabled by default. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b>: enabled</description></item>
            /// <item><description><b>off</b>: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Rdp")]
            [Validation(Required=false)]
            public string Rdp { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable SqlServer interception. This is disabled by default. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b>: enabled</description></item>
            /// <item><description><b>off</b>: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("SqlServer")]
            [Validation(Required=false)]
            public string SqlServer { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable SSH interception. This is enabled by default. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b>: enabled</description></item>
            /// <item><description><b>off</b>: disabled.</description></item>
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
        /// <para>The IP address of the access source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.2.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The threshold for the period of time during which logon failures are counted, in minutes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: 1 minute</description></item>
        /// <item><description><b>2</b>: 2 minutes</description></item>
        /// <item><description><b>5</b>: 5 minutes</description></item>
        /// <item><description><b>10</b>: 10 minutes</description></item>
        /// <item><description><b>15</b>: 15 minutes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Span")]
        [Validation(Required=false)]
        public int? Span { get; set; }

        /// <summary>
        /// <para>The list of servers to which the defense rule against brute-force attacks applies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>uuid-13213-dasda</para>
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public List<string> UuidList { get; set; }

    }

}
