// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyProcDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribePropertyProcDetailResponseBodyPageInfo PageInfo { get; set; }
        public class DescribePropertyProcDetailResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
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

            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page. Default value: <b>10</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>An array that consists of the fingerprints of the processes.</para>
        /// </summary>
        [NameInMap("Propertys")]
        [Validation(Required=false)]
        public List<DescribePropertyProcDetailResponseBodyPropertys> Propertys { get; set; }
        public class DescribePropertyProcDetailResponseBodyPropertys : TeaModel {
            /// <summary>
            /// <para>The startup parameter of the process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>./8888</para>
            /// </summary>
            [NameInMap("Cmdline")]
            [Validation(Required=false)]
            public string Cmdline { get; set; }

            /// <summary>
            /// <para>The timestamp of last data collection. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1565686951000</para>
            /// </summary>
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// <para>The permission that is required to run the process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root</para>
            /// </summary>
            [NameInMap("EuidName")]
            [Validation(Required=false)]
            public string EuidName { get; set; }

            /// <summary>
            /// <para>Process file hash information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>935c1861df1f4018d698e8b65abfa02d7e9037d8f68ca3c2065b6ca165d4****</para>
            /// </summary>
            [NameInMap("FileHash")]
            [Validation(Required=false)]
            public string FileHash { get; set; }

            /// <summary>
            /// <para>The ID of the server that is associated with the process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-hp35tftuh52wbp1g****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the server that is associated with the process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hc-host-****</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>Indicates whether the process is a package installation process. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: yes</description></item>
            /// <item><description><b>0</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsPackage")]
            [Validation(Required=false)]
            public int? IsPackage { get; set; }

            /// <summary>
            /// <para>The MD5 hash value of the process file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>842644ea3d88bd7f7e14c1c089ef****</para>
            /// </summary>
            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            /// <summary>
            /// <para>The name of the process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agetty</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The path of the process.</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The ID of the process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12826</para>
            /// </summary>
            [NameInMap("Pid")]
            [Validation(Required=false)]
            public string Pid { get; set; }

            /// <summary>
            /// <para>The name of the parent process to which the process belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>start***.s</para>
            /// </summary>
            [NameInMap("Pname")]
            [Validation(Required=false)]
            public string Pname { get; set; }

            /// <summary>
            /// <para>The time when the process starts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-08-07 10:09:05</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The timestamp when the process starts. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1648783107000</para>
            /// </summary>
            [NameInMap("StartTimeDt")]
            [Validation(Required=false)]
            public long? StartTimeDt { get; set; }

            /// <summary>
            /// <para>The status of the process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sleeping</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The user who runs the process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root</para>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

            /// <summary>
            /// <para>The UUID of the server that is associated with the process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>162eb349-c2d9-4f8b-805c-75b43d4c****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AA47D46F-10DE-138C-BBB4-8A0003F75CD7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
