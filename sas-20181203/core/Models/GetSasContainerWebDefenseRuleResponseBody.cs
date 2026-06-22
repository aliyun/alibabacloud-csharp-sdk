// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetSasContainerWebDefenseRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the container file defense rule.</para>
        /// </summary>
        [NameInMap("ContainerWebDefenseRule")]
        [Validation(Required=false)]
        public GetSasContainerWebDefenseRuleResponseBodyContainerWebDefenseRule ContainerWebDefenseRule { get; set; }
        public class GetSasContainerWebDefenseRuleResponseBodyContainerWebDefenseRule : TeaModel {
            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000**0002</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The total number of applications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AppTotalCount")]
            [Validation(Required=false)]
            public int? AppTotalCount { get; set; }

            /// <summary>
            /// <para>The timestamp when the rule was created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1709173360000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The timestamp when the rule was modified. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1655432638000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The list of configured file paths.</para>
            /// </summary>
            [NameInMap("PathConfDTOList")]
            [Validation(Required=false)]
            public List<GetSasContainerWebDefenseRuleResponseBodyContainerWebDefenseRulePathConfDTOList> PathConfDTOList { get; set; }
            public class GetSasContainerWebDefenseRuleResponseBodyContainerWebDefenseRulePathConfDTOList : TeaModel {
                /// <summary>
                /// <para>The backup path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/usr/path/</para>
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
                /// <para>/test11*</para>
                /// </summary>
                [NameInMap("DefensePath")]
                [Validation(Required=false)]
                public string DefensePath { get; set; }

                /// <summary>
                /// <para>The excluded file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>file1</para>
                /// </summary>
                [NameInMap("ExcludeFile")]
                [Validation(Required=false)]
                public string ExcludeFile { get; set; }

                /// <summary>
                /// <para>The excluded file path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/test2/sub1,/test2/sub2</para>
                /// </summary>
                [NameInMap("ExcludeFilePath")]
                [Validation(Required=false)]
                public string ExcludeFilePath { get; set; }

                /// <summary>
                /// <para>The excluded file type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>doc</para>
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
                /// <para>webapp</para>
                /// </summary>
                [NameInMap("IncludeFile")]
                [Validation(Required=false)]
                public string IncludeFile { get; set; }

                /// <summary>
                /// <para>The included file type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>doc</para>
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
            /// <para>防篡改规则</para>
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
        /// <para>The request ID. Alibaba Cloud generates a unique ID for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BA674E4**62FB5133</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
