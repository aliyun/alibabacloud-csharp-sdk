// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAgentlessRelateMaliciousResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of hosts that are associated with the risk.</para>
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListAgentlessRelateMaliciousResponseBodyList> List { get; set; }
        public class ListAgentlessRelateMaliciousResponseBodyList : TeaModel {
            /// <summary>
            /// <para>The details of the alert events.</para>
            /// </summary>
            [NameInMap("Details")]
            [Validation(Required=false)]
            public List<ListAgentlessRelateMaliciousResponseBodyListDetails> Details { get; set; }
            public class ListAgentlessRelateMaliciousResponseBodyListDetails : TeaModel {
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
                /// <para>1f2e13a7c51ee89316ae50066515****</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The URL to download the malicious image sample.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://upgrade-rule-pkg.oss-cn-beijing.aliyuncs.com/totalpackage/">https://upgrade-rule-pkg.oss-cn-beijing.aliyuncs.com/totalpackage/</a>***</para>
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// <para>The file path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/root/logs/arms/tracelogs/log****</para>
            /// </summary>
            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// <para>The timestamp when the first scan was performed. Unit: milliseconds.</para>
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
            /// <para>8012</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sql-test-0****</para>
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
            /// <para>The timestamp when the last scan was performed. Unit: milliseconds.</para>
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
            /// <para>The handling result of the alert.</para>
            /// 
            /// <b>Example:</b>
            /// <para>addWhitelist.USER.Success</para>
            /// </summary>
            [NameInMap("OperateResult")]
            [Validation(Required=false)]
            public string OperateResult { get; set; }

            /// <summary>
            /// <para>The timestamp when the alert is handled. Unit: milliseconds.</para>
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
            /// <para>The ID of the task object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m-****</para>
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// <para>The name of the task object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>image_***</para>
            /// </summary>
            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

            /// <summary>
            /// <para>The type of the task object. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: snapshot.</description></item>
            /// <item><description><b>2</b>: image.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// <para>The UUID of the server.</para>
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
        public ListAgentlessRelateMaliciousResponseBodyPageInfo PageInfo { get; set; }
        public class ListAgentlessRelateMaliciousResponseBodyPageInfo : TeaModel {
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
            /// <para>197</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FCA270CC-24C8-5DA1-9184-20F2605C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
