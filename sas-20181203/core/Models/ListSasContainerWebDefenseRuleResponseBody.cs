// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListSasContainerWebDefenseRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of container file defense rules.</para>
        /// </summary>
        [NameInMap("ContainerWebDefenseRuleList")]
        [Validation(Required=false)]
        public List<ListSasContainerWebDefenseRuleResponseBodyContainerWebDefenseRuleList> ContainerWebDefenseRuleList { get; set; }
        public class ListSasContainerWebDefenseRuleResponseBodyContainerWebDefenseRuleList : TeaModel {
            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1766185894104675</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The number of configured applications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ApptotalCount")]
            [Validation(Required=false)]
            public int? ApptotalCount { get; set; }

            /// <summary>
            /// <para>The creation time. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1698978109000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The timestamp when the alert event was last modified. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1678852686000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>420336648</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The list of rule defense paths.</para>
            /// </summary>
            [NameInMap("PathConfDTOList")]
            [Validation(Required=false)]
            public List<ListSasContainerWebDefenseRuleResponseBodyContainerWebDefenseRuleListPathConfDTOList> PathConfDTOList { get; set; }
            public class ListSasContainerWebDefenseRuleResponseBodyContainerWebDefenseRuleListPathConfDTOList : TeaModel {
                /// <summary>
                /// <para>The backup path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/tmp/test</para>
                /// </summary>
                [NameInMap("BackupPath")]
                [Validation(Required=false)]
                public string BackupPath { get; set; }

                /// <summary>
                /// <para>The action to take. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>block</b>: Block.</description></item>
                /// <item><description><b>audit</b>: Alert.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>audit</para>
                /// </summary>
                [NameInMap("DefenseMode")]
                [Validation(Required=false)]
                public string DefenseMode { get; set; }

                /// <summary>
                /// <para>The defense path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/usr/test/</para>
                /// </summary>
                [NameInMap("DefensePath")]
                [Validation(Required=false)]
                public string DefensePath { get; set; }

                /// <summary>
                /// <para>The excluded file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>php</para>
                /// </summary>
                [NameInMap("ExcludeFile")]
                [Validation(Required=false)]
                public string ExcludeFile { get; set; }

                /// <summary>
                /// <para>The excluded file path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/usr/tt</para>
                /// </summary>
                [NameInMap("ExcludeFilePath")]
                [Validation(Required=false)]
                public string ExcludeFilePath { get; set; }

                /// <summary>
                /// <para>The excluded file type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>jsp</para>
                /// </summary>
                [NameInMap("ExcludeFileType")]
                [Validation(Required=false)]
                public string ExcludeFileType { get; set; }

                /// <summary>
                /// <para>The defense mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Basic pattern (whitelist).</description></item>
                /// <item><description><b>1</b>: Advanced pattern (blacklist).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("GuardType")]
                [Validation(Required=false)]
                public int? GuardType { get; set; }

                /// <summary>
                /// <para>The included file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/usr/test</para>
                /// </summary>
                [NameInMap("IncludeFile")]
                [Validation(Required=false)]
                public string IncludeFile { get; set; }

                /// <summary>
                /// <para>The type of the included file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>php</para>
                /// </summary>
                [NameInMap("IncludeFileType")]
                [Validation(Required=false)]
                public string IncludeFileType { get; set; }

                /// <summary>
                /// <para>The list of whitelisted processes.</para>
                /// </summary>
                [NameInMap("ProcessPathList")]
                [Validation(Required=false)]
                public List<string> ProcessPathList { get; set; }

            }

            /// <summary>
            /// <para>The rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test2</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The rule status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Enabled.</description></item>
            /// <item><description><b>0</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RuleStatus")]
            [Validation(Required=false)]
            public int? RuleStatus { get; set; }

        }

        /// <summary>
        /// <para>The pagination information of the query result.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListSasContainerWebDefenseRuleResponseBodyPageInfo PageInfo { get; set; }
        public class ListSasContainerWebDefenseRuleResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries on the current page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The maximum number of entries per page in a paged query.</para>
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
            /// <para>42</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID. It is used to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8C376***AE74FB4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
