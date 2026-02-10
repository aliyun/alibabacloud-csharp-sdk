// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAssetsPropertyDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>Information displayed on the page when performing a paginated query.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public GetAssetsPropertyDetailResponseBodyPageInfo PageInfo { get; set; }
        public class GetAssetsPropertyDetailResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of asset fingerprint details displayed on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page when performing a paginated query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The NextToken value returned when using the NextToken method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6k+AtdhNE3kgQEK36GujZ5on+tWdc+4WoaoMP/kUNxxxx</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The number of asset fingerprint details displayed per page when performing a paginated query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of detailed asset fingerprint information queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Collection of asset fingerprint details.</para>
        /// </summary>
        [NameInMap("Propertys")]
        [Validation(Required=false)]
        public List<GetAssetsPropertyDetailResponseBodyPropertys> Propertys { get; set; }
        public class GetAssetsPropertyDetailResponseBodyPropertys : TeaModel {
            [NameInMap("Agent")]
            [Validation(Required=false)]
            public string Agent { get; set; }

            /// <summary>
            /// <para>Container name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5-rce_web_1</para>
            /// </summary>
            [NameInMap("ContainerName")]
            [Validation(Required=false)]
            public string ContainerName { get; set; }

            /// <summary>
            /// <para>The timestamp of the latest asset fingerprint scan, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649149566000</para>
            /// </summary>
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Web site domain. </para>
            /// <remarks>
            /// <para>Only returned when <b>Biz</b> is <b>web_server</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>localhost</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>Large model service request interface address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dashscope.aliyuncs.com</para>
            /// </summary>
            [NameInMap("EndPoint")]
            [Validation(Required=false)]
            public string EndPoint { get; set; }

            /// <summary>
            /// <para>File path for requesting the large model service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/root/llm.py</para>
            /// </summary>
            [NameInMap("File")]
            [Validation(Required=false)]
            public string File { get; set; }

            /// <summary>
            /// <para>Kernel module file path.</para>
            /// <remarks>
            /// <para>Returned only when <b>Biz</b> is <b>lkm</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>/lib/modules/4****</para>
            /// </summary>
            [NameInMap("Filepath")]
            [Validation(Required=false)]
            public string Filepath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ImageDigest</para>
            /// </summary>
            [NameInMap("ImageDigest")]
            [Validation(Required=false)]
            public string ImageDigest { get; set; }

            /// <summary>
            /// <para>Image name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>registry-vpc.cn-beijing.aliyuncs.com/acs/aliyun-ingress-controller****</para>
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// <para>AI tool installation path</para>
            /// 
            /// <b>Example:</b>
            /// <para>/etc/pip3/env/vllm</para>
            /// </summary>
            [NameInMap("InstallationPath")]
            [Validation(Required=false)]
            public string InstallationPath { get; set; }

            /// <summary>
            /// <para>The instance ID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-hp35tftuh52wbp1g****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the server instance.</para>
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
            /// <para>Web site process listening protocol. </para>
            /// <remarks>
            /// <para>Only returned when <b>Biz</b> is <b>web_server</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("ListenProtocol")]
            [Validation(Required=false)]
            public string ListenProtocol { get; set; }

            [NameInMap("McpName")]
            [Validation(Required=false)]
            public string McpName { get; set; }

            /// <summary>
            /// <para>AI tool name</para>
            /// 
            /// <b>Example:</b>
            /// <para>vllm</para>
            /// </summary>
            [NameInMap("MiddlewareName")]
            [Validation(Required=false)]
            public string MiddlewareName { get; set; }

            /// <summary>
            /// <para>AI tool version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.1</para>
            /// </summary>
            [NameInMap("MiddlewareVersion")]
            [Validation(Required=false)]
            public string MiddlewareVersion { get; set; }

            /// <summary>
            /// <para>Name of the large model vendor</para>
            /// 
            /// <b>Example:</b>
            /// <para>OpenAI</para>
            /// </summary>
            [NameInMap("ModelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <para>Module name.</para>
            /// <remarks>
            /// <para>Returned only when <b>Biz</b> is <b>lkm</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>alihids</para>
            /// </summary>
            [NameInMap("ModuleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

            /// <summary>
            /// <para>The meaning varies based on the value of <b>Biz</b>:</para>
            /// <list type="bullet">
            /// <item><description>When <b>Biz</b> is <b>web_server</b>, it represents the Web root path</description></item>
            /// <item><description>When <b>Biz</b> is <b>autorun</b>, it represents the startup item path</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>/lib/systemd/system****</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>Web site directory permissions. </para>
            /// <remarks>
            /// <para>Only returned when <b>Biz</b> is <b>web_server</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>755</para>
            /// </summary>
            [NameInMap("PathMode")]
            [Validation(Required=false)]
            public string PathMode { get; set; }

            /// <summary>
            /// <para>Web site process Pid. </para>
            /// <remarks>
            /// <para>Only returned when <b>Biz</b> is <b>web_server</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>813</para>
            /// </summary>
            [NameInMap("Pid")]
            [Validation(Required=false)]
            public string Pid { get; set; }

            /// <summary>
            /// <para>Web site port.</para>
            /// <remarks>
            /// <para>Returned only when <b>Biz</b> is <b>web_server</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>Timestamp of the web site process startup, in milliseconds.  </para>
            /// <remarks>
            /// <para>Only returned when <b>Biz</b> is <b>web_server</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1671186801000</para>
            /// </summary>
            [NameInMap("ProcessStarted")]
            [Validation(Required=false)]
            public long? ProcessStarted { get; set; }

            /// <summary>
            /// <para>The ID of the region where the instance is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ACR-Example</para>
            /// </summary>
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Default</para>
            /// </summary>
            [NameInMap("RepoNamespace")]
            [Validation(Required=false)]
            public string RepoNamespace { get; set; }

            /// <summary>
            /// <para>Web site type.</para>
            /// <remarks>
            /// <para>Returned only when <b>Biz</b> is <b>web_server</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>nginx</para>
            /// </summary>
            [NameInMap("ServerType")]
            [Validation(Required=false)]
            public string ServerType { get; set; }

            /// <summary>
            /// <para>Kernel module size.</para>
            /// <remarks>
            /// <para>Returned only when <b>Biz</b> is <b>lkm</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            [NameInMap("SkillsName")]
            [Validation(Required=false)]
            public string SkillsName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AI</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            [NameInMap("TransportName")]
            [Validation(Required=false)]
            public string TransportName { get; set; }

            /// <summary>
            /// <para>Number of dependencies for the kernel module.</para>
            /// <remarks>
            /// <para>Returned only when <b>Biz</b> is <b>lkm</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("UsedByCount")]
            [Validation(Required=false)]
            public int? UsedByCount { get; set; }

            /// <summary>
            /// <para>Web site user. </para>
            /// <remarks>
            /// <para>Only returned when <b>Biz</b> is <b>web_server</b>.</para>
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
            /// <para>Web site web path. </para>
            /// <remarks>
            /// <para>Only returned when <b>Biz</b> is <b>web_server</b>.</para>
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
        /// <para>The ID of this call request, a unique identifier generated by Alibaba Cloud for the request, which can be used to troubleshoot and locate issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4C1AE3F3-18FA-4108-BBB9-AFA1A032****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
