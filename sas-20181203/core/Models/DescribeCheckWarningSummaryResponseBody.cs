// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCheckWarningSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of check items returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The page number of the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00BD7CE2-284A-4534-BD09-FB69836DD750</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of check items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The statistics of check items.</para>
        /// </summary>
        [NameInMap("WarningSummarys")]
        [Validation(Required=false)]
        public List<DescribeCheckWarningSummaryResponseBodyWarningSummarys> WarningSummarys { get; set; }
        public class DescribeCheckWarningSummaryResponseBodyWarningSummarys : TeaModel {
            /// <summary>
            /// <para>The number of check items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("CheckCount")]
            [Validation(Required=false)]
            public int? CheckCount { get; set; }

            /// <summary>
            /// <para>Indicates whether the risk item can be exploited. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("CheckExploit")]
            [Validation(Required=false)]
            public bool? CheckExploit { get; set; }

            /// <summary>
            /// <para>Indicates  whether the risk item is a container runtime risk item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ContainerRisk")]
            [Validation(Required=false)]
            public bool? ContainerRisk { get; set; }

            /// <summary>
            /// <para>Indicates whether the risk item is a database risk item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DatabaseRisk")]
            [Validation(Required=false)]
            public bool? DatabaseRisk { get; set; }

            /// <summary>
            /// <para>The number of high-risk items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HighWarningCount")]
            [Validation(Required=false)]
            public int? HighWarningCount { get; set; }

            /// <summary>
            /// <para>The time when the last baseline check was performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-01-01 12:23:00</para>
            /// </summary>
            [NameInMap("LastFoundTime")]
            [Validation(Required=false)]
            public string LastFoundTime { get; set; }

            /// <summary>
            /// <para>The risk level of the risk item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>high</b></description></item>
            /// <item><description><b>medium</b></description></item>
            /// <item><description><b>low</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The number of low-risk items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("LowWarningCount")]
            [Validation(Required=false)]
            public int? LowWarningCount { get; set; }

            /// <summary>
            /// <para>The number of medium-risk items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MediumWarningCount")]
            [Validation(Required=false)]
            public int? MediumWarningCount { get; set; }

            /// <summary>
            /// <para>The ID of the risk item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>118</para>
            /// </summary>
            [NameInMap("RiskId")]
            [Validation(Required=false)]
            public long? RiskId { get; set; }

            /// <summary>
            /// <para>The name of the risk item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Redis</para>
            /// </summary>
            [NameInMap("RiskName")]
            [Validation(Required=false)]
            public string RiskName { get; set; }

            /// <summary>
            /// <para>The level-2 type of the risk item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Redis</para>
            /// </summary>
            [NameInMap("SubTypeAlias")]
            [Validation(Required=false)]
            public string SubTypeAlias { get; set; }

            /// <summary>
            /// <para>The level-1 type of the check item. Examples: database, system, weak password, and middleware.</para>
            /// 
            /// <b>Example:</b>
            /// <para>databases</para>
            /// </summary>
            [NameInMap("TypeAlias")]
            [Validation(Required=false)]
            public string TypeAlias { get; set; }

            /// <summary>
            /// <para>The number of assets on which risk items are detected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("WarningMachineCount")]
            [Validation(Required=false)]
            public int? WarningMachineCount { get; set; }

        }

    }

}
