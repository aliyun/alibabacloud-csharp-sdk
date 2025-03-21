// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAntiBruteForceRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeAntiBruteForceRulesResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeAntiBruteForceRulesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4E5BFDCF-B9DD-430D-9DA4-151BCB581C9D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array that consists of the defense rules returned.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<DescribeAntiBruteForceRulesResponseBodyRules> Rules { get; set; }
        public class DescribeAntiBruteForceRulesResponseBodyRules : TeaModel {
            /// <summary>
            /// <para>防暴力破解规则创建时间戳。单位：毫秒。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1669800181000</para>
            /// </summary>
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// <para>Indicates whether the defense rule is the default rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b>: no</description></item>
            /// </list>
            /// <remarks>
            /// <para> The default rule takes effect on all servers that are not protected by defense rules against brute-force attacks.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DefaultRule")]
            [Validation(Required=false)]
            public bool? DefaultRule { get; set; }

            /// <summary>
            /// <para>This parameter is deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableSmartRule")]
            [Validation(Required=false)]
            public bool? EnableSmartRule { get; set; }

            /// <summary>
            /// <para>The threshold of logon failures that you specify.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("FailCount")]
            [Validation(Required=false)]
            public int? FailCount { get; set; }

            /// <summary>
            /// <para>The period of time during which logons from an account are not allowed. Unit: minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>360</para>
            /// </summary>
            [NameInMap("ForbiddenTime")]
            [Validation(Required=false)]
            public int? ForbiddenTime { get; set; }

            /// <summary>
            /// <para>The ID of the defense rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1629</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The number of servers to which the defense rule is applied.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("MachineCount")]
            [Validation(Required=false)]
            public int? MachineCount { get; set; }

            /// <summary>
            /// <para>The name of the defense rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AntiBruteForceRule01</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The types of protocols that the brute force cracking rule supports to intercept.</para>
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public DescribeAntiBruteForceRulesResponseBodyRulesProtocolType ProtocolType { get; set; }
            public class DescribeAntiBruteForceRulesResponseBodyRulesProtocolType : TeaModel {
                /// <summary>
                /// <para>RDP interception method, values: </para>
                /// <list type="bullet">
                /// <item><description><b>on</b>: enable </description></item>
                /// <item><description><b>off</b>: disable</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Rdp")]
                [Validation(Required=false)]
                public string Rdp { get; set; }

                /// <summary>
                /// <para>SqlServer interception mode, with values: </para>
                /// <list type="bullet">
                /// <item><description><b>on</b>: enable </description></item>
                /// <item><description><b>off</b>: disable</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("SqlServer")]
                [Validation(Required=false)]
                public string SqlServer { get; set; }

                /// <summary>
                /// <para>SSH interception method, with values: </para>
                /// <list type="bullet">
                /// <item><description><b>on</b>: enabled </description></item>
                /// <item><description><b>off</b>: disabled</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Ssh")]
                [Validation(Required=false)]
                public string Ssh { get; set; }

            }

            /// <summary>
            /// <para>The period of time during which logon failures from an account are measured. Unit: minutes. If <b>Span</b> is set to 10, the defense rule takes effect when the logon failures measured within 10 minutes reaches the specified threshold. The IP address of attackers cannot be used to log on to the server in the specified period of time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Span")]
            [Validation(Required=false)]
            public int? Span { get; set; }

            /// <summary>
            /// <para>An array consisting of the UUIDs of servers to which the defense rule is applied.</para>
            /// </summary>
            [NameInMap("UuidList")]
            [Validation(Required=false)]
            public List<string> UuidList { get; set; }

        }

    }

}
