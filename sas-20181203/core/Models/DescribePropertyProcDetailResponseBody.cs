// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyProcDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information of the query result.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribePropertyProcDetailResponseBodyPageInfo PageInfo { get; set; }
        public class DescribePropertyProcDetailResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of process Asset Fingerprints entries displayed on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The NextToken value returned when the NextToken method is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>B604532DEF982B875E8360A6EFA3B***</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The number of entries per page in a paged query. Default value: <b>10</b>, which indicates that 10 entries of process Asset Fingerprints information are displayed per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of process Asset Fingerprints entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The details of the process Asset Fingerprints information returned.</para>
        /// </summary>
        [NameInMap("Propertys")]
        [Validation(Required=false)]
        public List<DescribePropertyProcDetailResponseBodyPropertys> Propertys { get; set; }
        public class DescribePropertyProcDetailResponseBodyPropertys : TeaModel {
            /// <summary>
            /// <para>The startup parameters of the process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>./8888</para>
            /// </summary>
            [NameInMap("Cmdline")]
            [Validation(Required=false)]
            public string Cmdline { get; set; }

            /// <summary>
            /// <para>The timestamp of the most recent data collection. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1565686951000</para>
            /// </summary>
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// <para>The running permission of the process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root</para>
            /// </summary>
            [NameInMap("EuidName")]
            [Validation(Required=false)]
            public string EuidName { get; set; }

            /// <summary>
            /// <para>The file hash of the process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>935c1861df1f4018d698e8b65abfa02d7e9037d8f68ca3c2065b6ca165d4****</para>
            /// </summary>
            [NameInMap("FileHash")]
            [Validation(Required=false)]
            public string FileHash { get; set; }

            /// <summary>
            /// <para>The instance ID of the server associated with the process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-hp35tftuh52wbp1g****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the server associated with the process.</para>
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
            /// <para>The private IP address of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>Indicates whether the process is an installation package process. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Yes.</description></item>
            /// <item><description><b>0</b>: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsPackage")]
            [Validation(Required=false)]
            public int? IsPackage { get; set; }

            /// <summary>
            /// <para>The MD5 hash of the process file.</para>
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
            /// <para>The process ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12826</para>
            /// </summary>
            [NameInMap("Pid")]
            [Validation(Required=false)]
            public string Pid { get; set; }

            /// <summary>
            /// <para>The name of the parent process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>start***.s</para>
            /// </summary>
            [NameInMap("Pname")]
            [Validation(Required=false)]
            public string Pname { get; set; }

            /// <summary>
            /// <para>The time when the process started. The value is in the YYYY-MM-DD HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-08-07 10:09:05</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The timestamp when the process started. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1648783107000</para>
            /// </summary>
            [NameInMap("StartTimeDt")]
            [Validation(Required=false)]
            public long? StartTimeDt { get; set; }

            /// <summary>
            /// <para>The running state of the process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sleeping</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The user that runs the process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root</para>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

            /// <summary>
            /// <para>The UUID of the server associated with the process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>162eb349-c2d9-4f8b-805c-75b43d4c****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AA47D46F-10DE-138C-BBB4-8A0003F75CD7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
