// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListUnknownThreatDetectEventResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListUnknownThreatDetectEventResponseBodyData> Data { get; set; }
        public class ListUnknownThreatDetectEventResponseBodyData : TeaModel {
            [NameInMap("AnalyzeDesc")]
            [Validation(Required=false)]
            public string AnalyzeDesc { get; set; }

            [NameInMap("AnalyzeResult")]
            [Validation(Required=false)]
            public string AnalyzeResult { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[{&quot;5133&quot;:&quot;pickup -l -t unix -u&quot;},{&quot;1077&quot;:&quot;/usr/libexec/postfix/master -w&quot;},{&quot;1&quot;:&quot;/usr/lib/systemd/systemd --switched-root --system --deserialize 22&quot;}]</para>
            /// </summary>
            [NameInMap("CmdChain")]
            [Validation(Required=false)]
            public string CmdChain { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/usr/sbin/sshd -D</para>
            /// </summary>
            [NameInMap("Cmdline")]
            [Validation(Required=false)]
            public string Cmdline { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1694576692000</para>
            /// </summary>
            [NameInMap("FirstTime")]
            [Validation(Required=false)]
            public long? FirstTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30368144069e7567bbb10eabc2******</para>
            /// </summary>
            [NameInMap("HashKey")]
            [Validation(Required=false)]
            public string HashKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>centos****</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>172.16.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10.42.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1694576692000</para>
            /// </summary>
            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public long? LastTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5b394b54ca632fe51c4ab4a6dbaf****</para>
            /// </summary>
            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/usr/sbin/sshd -D</para>
            /// </summary>
            [NameInMap("ParentCmdline")]
            [Validation(Required=false)]
            public string ParentCmdline { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("ParentPid")]
            [Validation(Required=false)]
            public string ParentPid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/usr/bin/tar</para>
            /// </summary>
            [NameInMap("ParentProcessPath")]
            [Validation(Required=false)]
            public string ParentProcessPath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("Pid")]
            [Validation(Required=false)]
            public string Pid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/usr/bin/tar</para>
            /// </summary>
            [NameInMap("ProcessPath")]
            [Validation(Required=false)]
            public string ProcessPath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3a6fed5fc11392b3ee9f81caf017b48640d7458766a8eb0382899a605b41****</para>
            /// </summary>
            [NameInMap("Sha256")]
            [Validation(Required=false)]
            public string Sha256 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6690a46c-0edb-4663-a641-3629d1a9****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListUnknownThreatDetectEventResponseBodyPageInfo PageInfo { get; set; }
        public class ListUnknownThreatDetectEventResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

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
            /// <para>149</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>7532B7EE-7CE7-5F4D-BF04-B12447******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
