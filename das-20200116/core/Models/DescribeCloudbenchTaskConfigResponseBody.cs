// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeCloudbenchTaskConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The detailed information, including the error codes and the number of entries that are returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCloudbenchTaskConfigResponseBodyData Data { get; set; }
        public class DescribeCloudbenchTaskConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The path in which the files are archived.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/tmp/das/cloudbench/archive-sqls/</para>
            /// </summary>
            [NameInMap("ArchiveFolder")]
            [Validation(Required=false)]
            public string ArchiveFolder { get; set; }

            /// <summary>
            /// <para>The command that was run to start the stress testing task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>java -jar /tmp/das/cloudbench/CloudBenchClient.jar --bench --rocksdb /tmp/das/cloudbench/rocksdb --meta /tmp/das/cloudbench/cl-1621353601000-360****.meta --task_name 2777bba9-a836-49e6-9f70-1c3822fc9239 --result_file /tmp/das/cloudbench/null.result --user cloudb**** --pwd \&quot;cloudbench@<b><b>\&quot; --host rm-bp1j5f8s5x26kq79216</b></b>.mysql.rds.aliyuncs.com --port 3306 --charset utf8mb4 --interval 1 --bench_time 3600 --rate_factor 1.0 --start_time 1621353601 --rt &gt; /tmp/das/cloudbench/null.log</para>
            /// </summary>
            [NameInMap("BenchCmd")]
            [Validation(Required=false)]
            public string BenchCmd { get; set; }

            /// <summary>
            /// <para>The path to the JAR file that is used for stress testing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/tmp/das/cloudbench/CloudBenchClient.jar</para>
            /// </summary>
            [NameInMap("ClientJarPath")]
            [Validation(Required=false)]
            public string ClientJarPath { get; set; }

            /// <summary>
            /// <para>The path to the JAR file that is stored in OSS. The JAR file is used for stress testing.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://cloudbench-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/CloudBenchClient.jar?OSSAccessKeyId=LTAI5tKj8B4wikkVtupK****&Expires=1622441372&Signature=28p%2BCe4tNHpr9VPOcHc3Si9iOb">https://cloudbench-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/CloudBenchClient.jar?OSSAccessKeyId=LTAI5tKj8B4wikkVtupK****&amp;Expires=1622441372&amp;Signature=28p%2BCe4tNHpr9VPOcHc3Si9iOb</a>****</para>
            /// </summary>
            [NameInMap("JarOnOss")]
            [Validation(Required=false)]
            public string JarOnOss { get; set; }

            /// <summary>
            /// <para>The command that was run to preload the file that stores the analysis result of full SQL statistics.</para>
            /// 
            /// <b>Example:</b>
            /// <para>java -jar /tmp/das/cloudbench/CloudBenchClient.jar --load --out /tmp/das/cloudbench/cl-1621353601000-360****.sc --meta /tmp/das/cloudbench/cl-1621353601000-360****.meta --task_name 2777bba9-<b><b>-49e6-9f70-1c3822fc</b></b> --rocksdb /tmp/das/cloudbench/rocksdb</para>
            /// </summary>
            [NameInMap("LoadCmd")]
            [Validation(Required=false)]
            public string LoadCmd { get; set; }

            /// <summary>
            /// <para>The name of the metadata file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cl-1621353601000-360****.meta</para>
            /// </summary>
            [NameInMap("MetaFileName")]
            [Validation(Required=false)]
            public string MetaFileName { get; set; }

            /// <summary>
            /// <para>The name of the metadata file stored in Object Storage Service (OSS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;<a href="https://cb-rm-bp1w9g06h560l****.oss-cn-hangzhou.aliyuncs.com/cl-1621353601000-360****.meta?OSSAccessKeyId=LTAI5tKj8B4wikkVtupK****&Expires=1622441372&Signature=Qsehg3tzeA57M%2BIixAbWPWAtvl">https://cb-rm-bp1w9g06h560l****.oss-cn-hangzhou.aliyuncs.com/cl-1621353601000-360****.meta?OSSAccessKeyId=LTAI5tKj8B4wikkVtupK****&amp;Expires=1622441372&amp;Signature=Qsehg3tzeA57M%2BIixAbWPWAtvl</a>****</para>
            /// </summary>
            [NameInMap("MetaFileOnOss")]
            [Validation(Required=false)]
            public string MetaFileOnOss { get; set; }

            /// <summary>
            /// <para>The path to the metadata file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/tmp/das/cloudbench/cl-1621353601000-360****.meta</para>
            /// </summary>
            [NameInMap("MetaFilePath")]
            [Validation(Required=false)]
            public string MetaFilePath { get; set; }

            /// <summary>
            /// <para>The command that was run to parse the file that stores the analysis result of full SQL statistics.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cd /tmp/das/cloudbench &amp;&amp; java -jar CloudBenchClient.jar --parse --threads 32 --file /tmp/das/cloudbench/2777bba9-a836-49e6-9f70-1c3822fc9239.archiveSql --meta /tmp/das/cloudbench/cl-1621353601000-360****.meta --out /tmp/das/cloudbench/cl-1621353601000-360****.sc --parent_patmp/das/cloudbench --source RDS --h /thost rm-bp1j5f8s5x266****.mysql.rds.aliyuncs.com --port 3306 --user cloudb**** --pwd \&quot;cloudbench@****\&quot; --cutSqlLen 8192 --db_black_list=information_schema,test,unknow,null</para>
            /// </summary>
            [NameInMap("ParseCmd")]
            [Validation(Required=false)]
            public string ParseCmd { get; set; }

            /// <summary>
            /// <para>The path to the file that is parsed. The file stores the analysis result of full SQL statistics.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/tmp/das/cloudbench/2777bba9-a836-49e6-9f70-1c3822fc****.archiveSql</para>
            /// </summary>
            [NameInMap("ParseFilePath")]
            [Validation(Required=false)]
            public string ParseFilePath { get; set; }

            /// <summary>
            /// <para>The location where the RocksDB storage system is deployed in the stress testing client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/tmp/das/cloudbench/rocksdb</para>
            /// </summary>
            [NameInMap("RocksDbPath")]
            [Validation(Required=false)]
            public string RocksDbPath { get; set; }

            /// <summary>
            /// <para>The name of the file that stores the analysis result of full SQL statistics.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cl-1621353601000-360****.sc</para>
            /// </summary>
            [NameInMap("SqlFileName")]
            [Validation(Required=false)]
            public string SqlFileName { get; set; }

            /// <summary>
            /// <para>The name of the file that stores the analysis result of full SQL statistics and that is stored in OSS.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://cb-rm-bp1w9g06h560l****.oss-cn-hangzhou.aliyuncs.com/cl-1621353601000-360****.sc?OSSAccessKeyId=LTAI5tKj8B4wikkVtupK****&Expires=1622441372&Signature=LYMADwo%2BRrJeqR3e4d8OlIkVmw">https://cb-rm-bp1w9g06h560l****.oss-cn-hangzhou.aliyuncs.com/cl-1621353601000-360****.sc?OSSAccessKeyId=LTAI5tKj8B4wikkVtupK****&amp;Expires=1622441372&amp;Signature=LYMADwo%2BRrJeqR3e4d8OlIkVmw</a>****</para>
            /// </summary>
            [NameInMap("SqlFileOnOss")]
            [Validation(Required=false)]
            public string SqlFileOnOss { get; set; }

            /// <summary>
            /// <para>The path to the file that stores the analysis result of full SQL statistics.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/tmp/das/cloudbench/cl-1621353601000-360****.sc</para>
            /// </summary>
            [NameInMap("SqlFilePath")]
            [Validation(Required=false)]
            public string SqlFilePath { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e5cec704-0518-430f-8263-76f4dcds****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1091411816252****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The path of the temporary directory that is generated for stress testing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/tmp/bench/</para>
            /// </summary>
            [NameInMap("WorkDir")]
            [Validation(Required=false)]
            public string WorkDir { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para> If the request was successful, <b>Successful</b> is returned. If the request failed, an error message such as an error code is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6D17591-B48B-4D31-9CD6-9B9796B2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
