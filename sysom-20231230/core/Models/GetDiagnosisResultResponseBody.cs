// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetDiagnosisResultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetDiagnosisResultResponseBodyData Data { get; set; }
        public class GetDiagnosisResultResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public int? Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;jobs&quot;:[
            ///         {
            ///             &quot;cmd&quot;:&quot;mkdir -p /var/log/sysak &amp;&amp; sysak podmem -r 100  -a -j /var/log/sysak/podmem.json &gt; /dev/null 2&gt;&amp;1 &amp;&amp; cat /var/log/sysak/podmem.json&quot;,
            ///             &quot;instance&quot;:&quot;172.20.12.174&quot;,
            ///             &quot;fetch_file_list&quot;:[</para>
            /// <pre><c>        ]
            ///     }
            /// ],
            /// &quot;in_order&quot;:true,
            /// &quot;offline_mode&quot;:false,
            /// &quot;offline_results&quot;:[
            /// 
            /// ]
            /// </c></pre>
            /// <para>}</para>
            /// </summary>
            [NameInMap("command")]
            [Validation(Required=false)]
            public object Command { get; set; }

            [NameInMap("created_at")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Diagnosis failed</para>
            /// </summary>
            [NameInMap("err_msg")]
            [Validation(Required=false)]
            public string ErrMsg { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;type&quot;:&quot;all&quot;,
            ///     &quot;value&quot;:&quot;&quot;,
            ///     &quot;channel&quot;:&quot;ssh&quot;,
            ///     &quot;instance&quot;:&quot;172.1.2.174&quot;,
            ///     &quot;service_name&quot;:&quot;filecache&quot;
            /// }</para>
            /// </summary>
            [NameInMap("params")]
            [Validation(Required=false)]
            public object Params { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;summary&quot;:&quot;  memory cgroup leak&quot;,
            ///     &quot;dataMemEvent&quot;:{
            ///         &quot;data&quot;:[
            ///             {
            ///                 &quot;key&quot;:&quot;Util&quot;,
            ///                 &quot;value&quot;:20
            ///             },
            ///             {
            ///                 &quot;key&quot;:&quot;MemLeak&quot;,
            ///                 &quot;value&quot;:&quot;OK&quot;
            ///             },
            ///             {
            ///                 &quot;key&quot;:&quot;MemcgLeak&quot;,
            ///                 &quot;value&quot;:&quot;NG&quot;
            ///             },
            ///             {
            ///                 &quot;key&quot;:&quot;MemFrag&quot;,
            ///                 &quot;value&quot;:&quot;OK&quot;
            ///             }
            ///         ]
            ///     },
            ///     &quot;dataMemOverView&quot;:{
            ///         &quot;data&quot;:[
            ///             {
            ///                 &quot;key&quot;:&quot;app&quot;,
            ///                 &quot;value&quot;:10937332
            ///             },
            ///             {
            ///                 &quot;key&quot;:&quot;free&quot;,
            ///                 &quot;value&quot;:806800
            ///             },
            ///             {
            ///                 &quot;key&quot;:&quot;kernel&quot;,
            ///                 &quot;value&quot;:4527660
            ///             }
            ///         ]
            ///     },
            ///     &quot;dataKerMem&quot;:{
            ///         &quot;data&quot;:[
            ///             {
            ///                 &quot;key&quot;:&quot;SReclaimable&quot;,
            ///                 &quot;value&quot;:3411292
            ///             },
            ///             {
            ///                 &quot;key&quot;:&quot;VmallocUsed&quot;,
            ///                 &quot;value&quot;:30980
            ///             },
            ///             {
            ///                 &quot;key&quot;:&quot;allocPage&quot;,
            ///                 &quot;value&quot;:177732
            ///             },
            ///             {
            ///                 &quot;key&quot;:&quot;KernelStack&quot;,
            ///                 &quot;value&quot;:9280
            ///             },
            ///             {
            ///                 &quot;key&quot;:&quot;PageTables&quot;,
            ///                 &quot;value&quot;:38056
            ///             },
            ///             {
            ///                 &quot;key&quot;:&quot;SUnreclaim&quot;,
            ///                 &quot;value&quot;:170248
            ///             },
            ///             {
            ///                 &quot;key&quot;:&quot;reserved&quot;,
            ///                 &quot;value&quot;:690072
            ///             }
            ///         ]
            ///     },
            ///     &quot;dataUserMem&quot;:{
            ///         &quot;data&quot;:[
            ///             {
            ///                 &quot;key&quot;:&quot;filecache&quot;,
            ///                 &quot;value&quot;:8010008
            ///             },
            ///             {
            ///                 &quot;key&quot;:&quot;anon&quot;,
            ///                 &quot;value&quot;:2468608
            ///             },
            ///             {
            ///                 &quot;key&quot;:&quot;mlock&quot;,
            ///                 &quot;value&quot;:0
            ///             },
            ///             {
            ///                 &quot;key&quot;:&quot;huge1G&quot;,
            ///                 &quot;value&quot;:0
            ///             },
            ///             {
            ///                 &quot;key&quot;:&quot;huge2M&quot;,
            ///                 &quot;value&quot;:0
            ///             },
            ///             {
            ///                 &quot;key&quot;:&quot;buffers&quot;,
            ///                 &quot;value&quot;:458608
            ///             },
            ///             {
            ///                 &quot;key&quot;:&quot;shmem&quot;,
            ///                 &quot;value&quot;:2284
            ///             }
            ///         ]
            ///     },
            ///     &quot;dataCacheList&quot;:{
            ///         &quot;data&quot;:[
            ///             {
            ///                 &quot;key&quot;:0,
            ///                 &quot;Name&quot;:&quot;/var/lib/mysql/sysom/sys_handler_log.ibd&quot;,
            ///                 &quot;cached&quot;:576764,
            ///                 &quot;Task&quot;:&quot;mysqld_78575 &quot;
            ///             },
            ///             {
            ///                 &quot;key&quot;:1,
            ///                 &quot;Name&quot;:&quot;/var/log/sysom/sysom-migration-access.log&quot;,
            ///                 &quot;cached&quot;:276688,
            ///                 &quot;Task&quot;:&quot;gunicorn_33647 ,gunicorn_460836 ,gunicorn_559934 ,gunicorn_731758 ,gunicorn_2362682 &quot;
            ///             },
            ///             {
            ///                 &quot;key&quot;:2,
            ///                 &quot;Name&quot;:&quot;/var/log/sysom/sysom-rtdemo-access.log&quot;,
            ///                 &quot;cached&quot;:229404,
            ///                 &quot;Task&quot;:&quot;gunicorn_60718 ,gunicorn_720734 ,gunicorn_722168 &quot;
            ///             },
            ///             {
            ///                 &quot;key&quot;:3,
            ///                 &quot;Name&quot;:&quot;/var/log/sysom/sysom-monitor-server-access.log&quot;,
            ///                 &quot;cached&quot;:197368,
            ///                 &quot;Task&quot;:&quot;gunicorn_33682 ,gunicorn_671155 ,gunicorn_714998 &quot;
            ///             },
            ///             {
            ///                 &quot;key&quot;:4,
            ///                 &quot;Name&quot;:&quot;/var/log/sysom/sysom-channel-access.log&quot;,
            ///                 &quot;cached&quot;:180276,
            ///                 &quot;Task&quot;:&quot;gunicorn_33233 ,gunicorn_499735 ,gunicorn_725497 &quot;
            ///             },
            ///             {
            ///                 &quot;key&quot;:5,
            ///                 &quot;Name&quot;:&quot;total cached of close file&quot;,
            ///                 &quot;cached&quot;:3729668,
            ///                 &quot;Task&quot;:&quot;&quot;
            ///             }
            ///         ]
            ///     },
            ///     &quot;dataProcMemList&quot;:{
            ///         &quot;data&quot;:[
            ///             {
            ///                 &quot;key&quot;:0,
            ///                 &quot;task&quot;:&quot;mysqld&quot;,
            ///                 &quot;MemTotal&quot;:240856,
            ///                 &quot;RssAnon&quot;:218248,
            ///                 &quot;RssFile&quot;:22608
            ///             },
            ///             {
            ///                 &quot;key&quot;:1,
            ///                 &quot;task&quot;:&quot;systemd-journal&quot;,
            ///                 &quot;MemTotal&quot;:150248,
            ///                 &quot;RssAnon&quot;:74300,
            ///                 &quot;RssFile&quot;:75944
            ///             },
            ///             {
            ///                 &quot;key&quot;:2,
            ///                 &quot;task&quot;:&quot;gunicorn&quot;,
            ///                 &quot;MemTotal&quot;:144640,
            ///                 &quot;RssAnon&quot;:114200,
            ///                 &quot;RssFile&quot;:30440
            ///             },
            ///             {
            ///                 &quot;key&quot;:3,
            ///                 &quot;task&quot;:&quot;gunicorn&quot;,
            ///                 &quot;MemTotal&quot;:141480,
            ///                 &quot;RssAnon&quot;:111040,
            ///                 &quot;RssFile&quot;:30440
            ///             },
            ///             {
            ///                 &quot;key&quot;:4,
            ///                 &quot;task&quot;:&quot;grafana-server&quot;,
            ///                 &quot;MemTotal&quot;:103660,
            ///                 &quot;RssAnon&quot;:42732,
            ///                 &quot;RssFile&quot;:60928
            ///             },
            ///             {
            ///                 &quot;key&quot;:5,
            ///                 &quot;task&quot;:&quot;gunicorn&quot;,
            ///                 &quot;MemTotal&quot;:97444,
            ///                 &quot;RssAnon&quot;:76256,
            ///                 &quot;RssFile&quot;:21188
            ///             },
            ///             {
            ///                 &quot;key&quot;:6,
            ///                 &quot;task&quot;:&quot;gunicorn&quot;,
            ///                 &quot;MemTotal&quot;:97260,
            ///                 &quot;RssAnon&quot;:76072,
            ///                 &quot;RssFile&quot;:21188
            ///             },
            ///             {
            ///                 &quot;key&quot;:7,
            ///                 &quot;task&quot;:&quot;prometheus&quot;,
            ///                 &quot;MemTotal&quot;:95356,
            ///                 &quot;RssAnon&quot;:45376,
            ///                 &quot;RssFile&quot;:49980
            ///             },
            ///             {
            ///                 &quot;key&quot;:8,
            ///                 &quot;task&quot;:&quot;gunicorn&quot;,
            ///                 &quot;MemTotal&quot;:90144,
            ///                 &quot;RssAnon&quot;:76456,
            ///                 &quot;RssFile&quot;:13688
            ///             },
            ///             {
            ///                 &quot;key&quot;:9,
            ///                 &quot;task&quot;:&quot;gunicorn&quot;,
            ///                 &quot;MemTotal&quot;:89796,
            ///                 &quot;RssAnon&quot;:76108,
            ///                 &quot;RssFile&quot;:13688
            ///             }
            ///         ]
            ///     }
            /// }</para>
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public object Result { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>memgraph</para>
            /// </summary>
            [NameInMap("service_name")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>grcuU21a</para>
            /// </summary>
            [NameInMap("task_id")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("updated_at")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/diagnose/detail/qe3Z34sa</para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9515E5A0-8905-59B0-9BBF-5F0BE568C3A0</para>
        /// </summary>
        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
