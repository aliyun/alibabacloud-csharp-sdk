// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OssMfd20231017.Models
{
    public class ListObjectScanEventResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListObjectScanEventResponseBodyData> Data { get; set; }
        public class ListObjectScanEventResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>testBucket******</para>
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            [NameInMap("Details")]
            [Validation(Required=false)]
            public List<ListObjectScanEventResponseBodyDataDetails> Details { get; set; }
            public class ListObjectScanEventResponseBodyDataDetails : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>DownloadUrl</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DownloadUrl</para>
                /// </summary>
                [NameInMap("NameDisplay")]
                [Validation(Required=false)]
                public string NameDisplay { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>html</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://gcx.cn-hangzhou.aliyuncs.com/">http://gcx.cn-hangzhou.aliyuncs.com/</a>****</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://gcx.cn-hangzhou.aliyuncs.com/">http://gcx.cn-hangzhou.aliyuncs.com/</a>****</para>
                /// </summary>
                [NameInMap("ValueDisplay")]
                [Validation(Required=false)]
                public string ValueDisplay { get; set; }

            }

            /// <summary>
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
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public long? EventId { get; set; }

            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/usr/local****</para>
            /// </summary>
            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1694576692000</para>
            /// </summary>
            [NameInMap("FirstTime")]
            [Validation(Required=false)]
            public long? FirstTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasSubEvent")]
            [Validation(Required=false)]
            public bool? HasSubEvent { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1694576692000</para>
            /// </summary>
            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public long? LastTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>e991e62f484bb6accd676e57a9******</para>
            /// </summary>
            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            [NameInMap("OperateResult")]
            [Validation(Required=false)]
            public string OperateResult { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1/2022/06/23/15/41/16559701077444693a0c6-33b2-4cc2-a99f-9f38b8b8****</para>
            /// </summary>
            [NameInMap("OssKey")]
            [Validation(Required=false)]
            public string OssKey { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3c01bdbb26f358bab27f267924aa2c9a03fc****</para>
            /// </summary>
            [NameInMap("Sha1")]
            [Validation(Required=false)]
            public string Sha1 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3a6fed5fc11392b3ee9f81caf017b48640d7458766a8eb0382899a605b41****</para>
            /// </summary>
            [NameInMap("Sha256")]
            [Validation(Required=false)]
            public string Sha256 { get; set; }

            /// <summary>
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

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListObjectScanEventResponseBodyPageInfo PageInfo { get; set; }
        public class ListObjectScanEventResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>187</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E99D386F-5546-5BCD-BADD-F4EF4B******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
