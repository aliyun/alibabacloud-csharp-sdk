// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAssetsPropertyDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public GetAssetsPropertyDetailResponseBodyPageInfo PageInfo { get; set; }
        public class GetAssetsPropertyDetailResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
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
            /// <para>23</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>An array that consists of the details about the asset fingerprints.</para>
        /// </summary>
        [NameInMap("Propertys")]
        [Validation(Required=false)]
        public List<GetAssetsPropertyDetailResponseBodyPropertys> Propertys { get; set; }
        public class GetAssetsPropertyDetailResponseBodyPropertys : TeaModel {
            /// <summary>
            /// <para>The name of the container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5-rce_web_1</para>
            /// </summary>
            [NameInMap("ContainerName")]
            [Validation(Required=false)]
            public string ContainerName { get; set; }

            /// <summary>
            /// <para>The timestamp of the last fingerprint collection. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649149566000</para>
            /// </summary>
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// <para>The domain name of the website.</para>
            /// <remarks>
            /// <para>This parameter is returned only when <b>Biz</b> is set to <b>web_server</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>localhost</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("EndPoint")]
            [Validation(Required=false)]
            public string EndPoint { get; set; }

            [NameInMap("File")]
            [Validation(Required=false)]
            public string File { get; set; }

            /// <summary>
            /// <para>The path to the kernel module file.</para>
            /// <remarks>
            /// <para>This parameter is returned only when <b>Biz</b> is set to <b>lkm</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>/lib/modules/4****</para>
            /// </summary>
            [NameInMap("Filepath")]
            [Validation(Required=false)]
            public string Filepath { get; set; }

            /// <summary>
            /// <para>The name of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>registry-vpc.cn-beijing.aliyuncs.com/acs/aliyun-ingress-controller****</para>
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            [NameInMap("InstallationPath")]
            [Validation(Required=false)]
            public string InstallationPath { get; set; }

            /// <summary>
            /// <para>The ID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-hp35tftuh52wbp1g****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the server.</para>
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
            /// <para>47.42.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.104.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.42.XX.XX</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The listening protocol that the website uses.</para>
            /// <remarks>
            /// <para>This parameter is returned only when <b>Biz</b> is set to <b>web_server</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("ListenProtocol")]
            [Validation(Required=false)]
            public string ListenProtocol { get; set; }

            [NameInMap("MiddlewareName")]
            [Validation(Required=false)]
            public string MiddlewareName { get; set; }

            [NameInMap("MiddlewareVersion")]
            [Validation(Required=false)]
            public string MiddlewareVersion { get; set; }

            [NameInMap("ModelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <para>The name of the module.</para>
            /// <remarks>
            /// <para>This parameter is returned only when <b>Biz</b> is set to <b>lkm</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>alihids</para>
            /// </summary>
            [NameInMap("ModuleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

            /// <summary>
            /// <para>The path. The value of this parameter varies based on the value of <b>Biz</b>.</para>
            /// <list type="bullet">
            /// <item><description>If <b>Biz</b> is set to <b>web_server</b>, the value of this parameter indicates the path to the website root directory.</description></item>
            /// <item><description>If <b>Biz</b> is set to <b>autorun</b>, the value of this parameter indicates the path to the startup item.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>/lib/systemd/system****</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The permissions on the root directory of the website.</para>
            /// <remarks>
            /// <para>This parameter is returned only when <b>Biz</b> is set to <b>web_server</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>755</para>
            /// </summary>
            [NameInMap("PathMode")]
            [Validation(Required=false)]
            public string PathMode { get; set; }

            /// <summary>
            /// <para>The process ID (PID) of the process that runs the website service.</para>
            /// <remarks>
            /// <para>This parameter is returned only when <b>Biz</b> is set to <b>web_server</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>813</para>
            /// </summary>
            [NameInMap("Pid")]
            [Validation(Required=false)]
            public string Pid { get; set; }

            /// <summary>
            /// <para>The port of the website.</para>
            /// <remarks>
            /// <para>This parameter is returned only when <b>Biz</b> is set to <b>web_server</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>The timestamp generated when the process was started. Unit: milliseconds.</para>
            /// <remarks>
            /// <para>This parameter is returned only when <b>Biz</b> is set to <b>web_server</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1671186801000</para>
            /// </summary>
            [NameInMap("ProcessStarted")]
            [Validation(Required=false)]
            public long? ProcessStarted { get; set; }

            /// <summary>
            /// <para>The ID of the region in which the server resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The type of the website.</para>
            /// <remarks>
            /// <para>This parameter is returned only when <b>Biz</b> is set to <b>web_server</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>nginx</para>
            /// </summary>
            [NameInMap("ServerType")]
            [Validation(Required=false)]
            public string ServerType { get; set; }

            /// <summary>
            /// <para>The size of the kernel module.</para>
            /// <remarks>
            /// <para>This parameter is returned only when <b>Biz</b> is set to <b>lkm</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// <para>The number of times that the kernel module is referenced.</para>
            /// <remarks>
            /// <para>This parameter is returned only when <b>Biz</b> is set to <b>lkm</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("UsedByCount")]
            [Validation(Required=false)]
            public int? UsedByCount { get; set; }

            /// <summary>
            /// <para>The user who started the process of the website.</para>
            /// <remarks>
            /// <para>This parameter is returned only when <b>Biz</b> is set to <b>web_server</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>root</para>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

            /// <summary>
            /// <para>The UUID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>162eb349-c2d9-4f8b-805c-75b43d4c****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// <para>The path to the root directory of the website.</para>
            /// <remarks>
            /// <para>This parameter is returned only when <b>Biz</b> is set to <b>web_server</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>/usr/share/nginx/html</para>
            /// </summary>
            [NameInMap("WebPath")]
            [Validation(Required=false)]
            public string WebPath { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4C1AE3F3-18FA-4108-BBB9-AFA1A032****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
