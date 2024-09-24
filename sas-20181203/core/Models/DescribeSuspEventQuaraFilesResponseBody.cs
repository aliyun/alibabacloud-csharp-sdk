// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSuspEventQuaraFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
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
        /// <para>An array that consists of the quarantined files.</para>
        /// </summary>
        [NameInMap("QuaraFiles")]
        [Validation(Required=false)]
        public List<DescribeSuspEventQuaraFilesResponseBodyQuaraFiles> QuaraFiles { get; set; }
        public class DescribeSuspEventQuaraFilesResponseBodyQuaraFiles : TeaModel {
            /// <summary>
            /// <para>The name of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WEBSHELL</para>
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <para>The type of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WebshellQuaraEventType</para>
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// <para>The ID of the quarantined file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>26918</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// <para>The instance ID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-2ze9t1qp36n1436m****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the server on which the quarantined file is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>iZwz98dkiw3vbrtqrt5v****</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the server on which the quarantined file is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.XX.XX.131</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the server on which the quarantined file is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The public IP address of the server on which the quarantined file is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.XX.XX.131</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The download link of the quarantined file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxx.xxx/xxx">https://xxx.xxx/xxx</a></para>
            /// </summary>
            [NameInMap("Link")]
            [Validation(Required=false)]
            public string Link { get; set; }

            /// <summary>
            /// <para>The MD5 hash value of the quarantined file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5ddebe926acc7ed39a664409bfd0ec10</para>
            /// </summary>
            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            /// <summary>
            /// <para>The time when the quarantined file was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-06-11 20:37:08</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The path to the quarantined file on the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/var/www/html/webshell-sample-master/others/defc3e21bab59e2a2ab49f7eda99f65f83d4d349.jpg</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The status of the quarantined file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>quaraFailed</b>: The file fails to be quarantined.</description></item>
            /// <item><description><b>quaraDone</b>: The file is quarantined.</description></item>
            /// <item><description><b>quaraing</b>: The file is being quarantined.</description></item>
            /// <item><description><b>rollbackFailed</b>: The system fails to cancel quarantining the file.</description></item>
            /// <item><description><b>rollbackDone</b>: The system cancelled quarantining the file.</description></item>
            /// <item><description><b>rollbacking</b>: The system is cancelling quarantining the file.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>rollbackDone</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The unique ID of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>228f890e56eae9eec6a42c7ea801b538</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>The UUID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>04a0e735-ad32-4835-b635-0458d77b****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32A73759-4C0F-4801-BE98-901223ACEE9A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>38</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
