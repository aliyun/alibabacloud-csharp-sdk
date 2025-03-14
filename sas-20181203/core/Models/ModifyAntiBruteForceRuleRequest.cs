// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyAntiBruteForceRuleRequest : TeaModel {
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
        /// <para>The threshold of logon failures that you specify. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2</b></description></item>
        /// <item><description><b>3</b></description></item>
        /// <item><description><b>4</b></description></item>
        /// <item><description><b>5</b></description></item>
        /// <item><description><b>10</b></description></item>
        /// <item><description><b>50</b></description></item>
        /// <item><description><b>80</b></description></item>
        /// <item><description><b>100</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ForbiddenTime")]
        [Validation(Required=false)]
        public int? ForbiddenTime { get; set; }

        /// <summary>
        /// <para>The ID of the defense rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>65778</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The name of the defense rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestRule</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public ModifyAntiBruteForceRuleRequestProtocolType ProtocolType { get; set; }
        public class ModifyAntiBruteForceRuleRequestProtocolType : TeaModel {
            [NameInMap("Rdp")]
            [Validation(Required=false)]
            public string Rdp { get; set; }

            [NameInMap("SqlServer")]
            [Validation(Required=false)]
            public string SqlServer { get; set; }

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
        /// <para>1.2.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The period of time during which logon failures from an account are measured. Unit: minutes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b></description></item>
        /// <item><description><b>2</b></description></item>
        /// <item><description><b>5</b></description></item>
        /// <item><description><b>10</b></description></item>
        /// <item><description><b>15</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Span")]
        [Validation(Required=false)]
        public int? Span { get; set; }

        /// <summary>
        /// <para>An array consisting of the UUIDs of the servers to which the defense rule is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>uuid-13213-dasda</para>
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public List<string> UuidList { get; set; }

    }

}
