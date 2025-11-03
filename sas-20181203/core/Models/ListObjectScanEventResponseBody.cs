// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListObjectScanEventResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListObjectScanEventResponseBodyData> Data { get; set; }
        public class ListObjectScanEventResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The name of the OSS bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hz-new01****</para>
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <para>The details of the file.</para>
            /// </summary>
            [NameInMap("Details")]
            [Validation(Required=false)]
            public List<ListObjectScanEventResponseBodyDataDetails> Details { get; set; }
            public class ListObjectScanEventResponseBodyDataDetails : TeaModel {
                /// <summary>
                /// <para>The name of the parameter in the file details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DownloadUrl</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The display name of the alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DownloadUrl</para>
                /// </summary>
                [NameInMap("NameDisplay")]
                [Validation(Required=false)]
                public string NameDisplay { get; set; }

                /// <summary>
                /// <para>The value type of the parameter in the file details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>html</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The value of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://gcx.cn-hangzhou.aliyuncs.com/">http://gcx.cn-hangzhou.aliyuncs.com/</a>****</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// <para>The value of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://gcx.cn-hangzhou.aliyuncs.com/">http://gcx.cn-hangzhou.aliyuncs.com/</a>****</para>
                /// </summary>
                [NameInMap("ValueDisplay")]
                [Validation(Required=false)]
                public string ValueDisplay { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the file can be detected by cloud sandbox. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DisplaySandboxResult")]
            [Validation(Required=false)]
            public string DisplaySandboxResult { get; set; }

            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// <para>The ID of the alert.</para>
            /// 
            /// <b>Example:</b>
            /// <para>911273</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public long? EventId { get; set; }

            /// <summary>
            /// <para>The name of the alert.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WebShell</para>
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <para>The path to the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/usr/local****</para>
            /// </summary>
            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// <para>The timestamp at which the alert was first detected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1694576692000</para>
            /// </summary>
            [NameInMap("FirstTime")]
            [Validation(Required=false)]
            public long? FirstTime { get; set; }

            /// <summary>
            /// <para>Indicates whether an alert is generated for the file extracted from the package. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasSubEvent")]
            [Validation(Required=false)]
            public bool? HasSubEvent { get; set; }

            /// <summary>
            /// <para>The timestamp at which the alert was last detected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1694576692000</para>
            /// </summary>
            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public long? LastTime { get; set; }

            [NameInMap("MatchedWhiteListRuleI18nStr")]
            [Validation(Required=false)]
            public string MatchedWhiteListRuleI18nStr { get; set; }

            /// <summary>
            /// <para>The MD5 hash value of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5b394b54ca632fe51c4ab4a6dbaf****</para>
            /// </summary>
            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            [NameInMap("OperateResult")]
            [Validation(Required=false)]
            public string OperateResult { get; set; }

            /// <summary>
            /// <para>The key of the file that is stored in the OSS bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1/2023/07/21/10/18/16899059356518bcf6c64-a04e-492d-a421-4ae8b888****</para>
            /// </summary>
            [NameInMap("OssKey")]
            [Validation(Required=false)]
            public string OssKey { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The risk level of the alert. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>high</b></description></item>
            /// <item><description><b>medium</b></description></item>
            /// <item><description><b>low</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>medium</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The SHA-1 hash value of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3c01bdbb26f358bab27f267924aa2c9a03fc****</para>
            /// </summary>
            [NameInMap("Sha1")]
            [Validation(Required=false)]
            public string Sha1 { get; set; }

            /// <summary>
            /// <para>The SHA-256 hash value of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3a6fed5fc11392b3ee9f81caf017b48640d7458766a8eb0382899a605b41****</para>
            /// </summary>
            [NameInMap("Sha256")]
            [Validation(Required=false)]
            public string Sha256 { get; set; }

            /// <summary>
            /// <para>The method that is used to detect the malicious file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>API</b>: uses API operations.</description></item>
            /// <item><description><b>OSS</b>: uses OSS file check.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListObjectScanEventResponseBodyPageInfo PageInfo { get; set; }
        public class ListObjectScanEventResponseBodyPageInfo : TeaModel {
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
            /// <para>253</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7BC55C8F-226E-5AF5-9A2C-2EC43864****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
