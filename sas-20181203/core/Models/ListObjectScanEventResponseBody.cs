// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListObjectScanEventResponseBody : TeaModel {
        /// <summary>
        /// <para>The data details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListObjectScanEventResponseBodyData> Data { get; set; }
        public class ListObjectScanEventResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The bucket name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hz-new01****</para>
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <para>The detailed information of the check item.</para>
            /// </summary>
            [NameInMap("Details")]
            [Validation(Required=false)]
            public List<ListObjectScanEventResponseBodyDataDetails> Details { get; set; }
            public class ListObjectScanEventResponseBodyDataDetails : TeaModel {
                /// <summary>
                /// <para>The name of the detail item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DownloadUrl</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The display name of the alert event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DownloadUrl</para>
                /// </summary>
                [NameInMap("NameDisplay")]
                [Validation(Required=false)]
                public string NameDisplay { get; set; }

                /// <summary>
                /// <para>The type of the detail information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>html</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The value of the detail item.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://gcx.cn-hangzhou.aliyuncs.com/">http://gcx.cn-hangzhou.aliyuncs.com/</a>****</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// <para>The display value of the detail item.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://gcx.cn-hangzhou.aliyuncs.com/">http://gcx.cn-hangzhou.aliyuncs.com/</a>****</para>
                /// </summary>
                [NameInMap("ValueDisplay")]
                [Validation(Required=false)]
                public string ValueDisplay { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether cloud sandbox detection is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Supported.</description></item>
            /// <item><description><b>false</b>: Not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DisplaySandboxResult")]
            [Validation(Required=false)]
            public string DisplaySandboxResult { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>connect timed out</para>
            /// </summary>
            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// <para>The event ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>911273</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public long? EventId { get; set; }

            /// <summary>
            /// <para>The alert name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WebShell</para>
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <para>The file path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/usr/local****</para>
            /// </summary>
            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// <para>The timestamp when the alert first occurred.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1694576692000</para>
            /// </summary>
            [NameInMap("FirstTime")]
            [Validation(Required=false)]
            public long? FirstTime { get; set; }

            /// <summary>
            /// <para>Indicates whether alerts exist for sub-files within a compressed archive. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes. You can obtain the corresponding <b>EventId</b> value and call this operation again with the <b>EventId</b> value passed to <b>ParentEventId</b> to view the alert events for the sub-files within the compressed archive.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasSubEvent")]
            [Validation(Required=false)]
            public bool? HasSubEvent { get; set; }

            /// <summary>
            /// <para>The timestamp when the alert was last detected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1694576692000</para>
            /// </summary>
            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public long? LastTime { get; set; }

            /// <summary>
            /// <para>The information about the matched whitelist rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b></b>&amp;nbsp&amp;nbspmd5&amp;nbsp&amp;nbsp contains &amp;nbsp&amp;nbsp23&amp;nbsp&amp;nbsp</para>
            /// </summary>
            [NameInMap("MatchedWhiteListRuleI18nStr")]
            [Validation(Required=false)]
            public string MatchedWhiteListRuleI18nStr { get; set; }

            /// <summary>
            /// <para>The MD5 hash of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5b394b54ca632fe51c4ab4a6dbaf****</para>
            /// </summary>
            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            /// <summary>
            /// <para>The alert handling result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fail</para>
            /// </summary>
            [NameInMap("OperateResult")]
            [Validation(Required=false)]
            public string OperateResult { get; set; }

            /// <summary>
            /// <para>The storage key of the file in the OSS bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1/2023/07/21/10/18/16899059356518bcf6c64-a04e-492d-a421-4ae8b888****</para>
            /// </summary>
            [NameInMap("OssKey")]
            [Validation(Required=false)]
            public string OssKey { get; set; }

            /// <summary>
            /// <para>The remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The risk level of the scanned alert. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>high</b>: high risk.</description></item>
            /// <item><description><b>medium</b>: medium risk.</description></item>
            /// <item><description><b>low</b>: low risk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>medium</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The SHA-1 hash of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3c01bdbb26f358bab27f267924aa2c9a03fc****</para>
            /// </summary>
            [NameInMap("Sha1")]
            [Validation(Required=false)]
            public string Sha1 { get; set; }

            /// <summary>
            /// <para>The SHA-256 hash of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3a6fed5fc11392b3ee9f81caf017b48640d7458766a8eb0382899a605b41****</para>
            /// </summary>
            [NameInMap("Sha256")]
            [Validation(Required=false)]
            public string Sha256 { get; set; }

            /// <summary>
            /// <para>The data source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>API</b>: API detection</description></item>
            /// <item><description><b>OSS</b>: OSS detection.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The event status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: unhandled </description></item>
            /// <item><description>1: manually handled</description></item>
            /// <item><description>2: whitelisted</description></item>
            /// <item><description>3: ignored</description></item>
            /// <item><description>4: access denied.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <para>The pagination information for the paged query.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListObjectScanEventResponseBodyPageInfo PageInfo { get; set; }
        public class ListObjectScanEventResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The page number of the current page in the paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The maximum number of entries displayed on each page in the paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>253</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for this request. You can use it to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7BC55C8F-226E-5AF5-9A2C-2EC43864****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
