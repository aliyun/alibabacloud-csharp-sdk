// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAgentlessMaliciousFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The malicious files.</para>
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListAgentlessMaliciousFilesResponseBodyList> List { get; set; }
        public class ListAgentlessMaliciousFilesResponseBodyList : TeaModel {
            /// <summary>
            /// <para>The details of the alert event.</para>
            /// </summary>
            [NameInMap("Details")]
            [Validation(Required=false)]
            public List<ListAgentlessMaliciousFilesResponseBodyListDetails> Details { get; set; }
            public class ListAgentlessMaliciousFilesResponseBodyListDetails : TeaModel {
                /// <summary>
                /// <para>The name of the detailed item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MD5</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The name key of the detailed item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>${suspicious.mp.db.maliciousfilemd5}</para>
                /// </summary>
                [NameInMap("NameKey")]
                [Validation(Required=false)]
                public string NameKey { get; set; }

                /// <summary>
                /// <para>The type of the detailed item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The value of the detailed item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The URL to download the malicious image sample.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://upgrade-rule-pkg.oss-cn-beijing.aliyuncs.com/totalpackage/rule/V3.166.2/totalpackage_rule_V3.16_6.2_tip_20230220110">https://upgrade-rule-pkg.oss-cn-beijing.aliyuncs.com/totalpackage/rule/V3.166.2/totalpackage_rule_V3.16_6.2_tip_20230220110</a>****</para>
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// <para>The file path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/root/etc/g****</para>
            /// </summary>
            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public long? FilePath { get; set; }

            /// <summary>
            /// <para>The timestamp generated when the first scan was performed. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>168257753****</para>
            /// </summary>
            [NameInMap("FirstScanTimestamp")]
            [Validation(Required=false)]
            public long? FirstScanTimestamp { get; set; }

            /// <summary>
            /// <para>The highlighted JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;highlight\&quot;:{\&quot;ruleVersion\&quot;:\&quot;20230223\&quot;,\&quot;ruleId\&quot;:600139,\&quot;events\&quot;:[[207,284]]}}</para>
            /// </summary>
            [NameInMap("HighLight")]
            [Validation(Required=false)]
            public string HighLight { get; set; }

            /// <summary>
            /// <para>The event ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sql-test-001****</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.210.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.25.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The timestamp generated when the last scan was performed. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>168257753****</para>
            /// </summary>
            [NameInMap("LatestScanTimestamp")]
            [Validation(Required=false)]
            public long? LatestScanTimestamp { get; set; }

            /// <summary>
            /// <para>The severity of the malicious file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>serious</description></item>
            /// <item><description>suspicious</description></item>
            /// <item><description>remind</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>serious</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The MD5 hash value of the malicious file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1f2e13a7c51ee89316ae50066515****</para>
            /// </summary>
            [NameInMap("MaliciousMd5")]
            [Validation(Required=false)]
            public string MaliciousMd5 { get; set; }

            /// <summary>
            /// <para>The name of the malicious file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WebShell</para>
            /// </summary>
            [NameInMap("MaliciousName")]
            [Validation(Required=false)]
            public string MaliciousName { get; set; }

            /// <summary>
            /// <para>The type of the virus.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WebShell</para>
            /// </summary>
            [NameInMap("MaliciousType")]
            [Validation(Required=false)]
            public string MaliciousType { get; set; }

            /// <summary>
            /// <para>The remarks.</para>
            /// </summary>
            [NameInMap("Notes")]
            [Validation(Required=false)]
            public List<ListAgentlessMaliciousFilesResponseBodyListNotes> Notes { get; set; }
            public class ListAgentlessMaliciousFilesResponseBodyListNotes : TeaModel {
                /// <summary>
                /// <para>The remark.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Serious***</para>
                /// </summary>
                [NameInMap("Note")]
                [Validation(Required=false)]
                public string Note { get; set; }

                /// <summary>
                /// <para>The ID of the remark.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50****</para>
                /// </summary>
                [NameInMap("NoteId")]
                [Validation(Required=false)]
                public string NoteId { get; set; }

                /// <summary>
                /// <para>The time when the remark was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-04-27 14:49:21</para>
                /// </summary>
                [NameInMap("NoteTime")]
                [Validation(Required=false)]
                public string NoteTime { get; set; }

            }

            /// <summary>
            /// <para>The handling result of the alert.</para>
            /// 
            /// <b>Example:</b>
            /// <para>addWhitelist.USER.Success</para>
            /// </summary>
            [NameInMap("OperateResult")]
            [Validation(Required=false)]
            public string OperateResult { get; set; }

            /// <summary>
            /// <para>The timestamp generated when the alert is handled. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>168257753****</para>
            /// </summary>
            [NameInMap("OperateTimestamp")]
            [Validation(Required=false)]
            public string OperateTimestamp { get; set; }

            /// <summary>
            /// <para>The partition of the disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/dev/xvda1</para>
            /// </summary>
            [NameInMap("Partition")]
            [Validation(Required=false)]
            public string Partition { get; set; }

            /// <summary>
            /// <para>The ID of the asset that is scanned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m-****</para>
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// <para>The name of the asset that is scanned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jenkins****</para>
            /// </summary>
            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

            /// <summary>
            /// <para>The type of the asset that is scanned. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>2: The scanned asset is an image.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// <para>The UUID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>49e25e0f-bb51-4a5a-a1b3-13a4ddaa****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListAgentlessMaliciousFilesResponseBodyPageInfo PageInfo { get; set; }
        public class ListAgentlessMaliciousFilesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
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
            /// <para>23</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CE343162-35BF-565E-B85E-8E3B7A2B****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
