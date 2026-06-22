// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAssetsPropertyDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The paging information displayed on the page.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public GetAssetsPropertyDetailResponseBodyPageInfo PageInfo { get; set; }
        public class GetAssetsPropertyDetailResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of Asset Fingerprints detail entries on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page in a paging query.</para>
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
            /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6k+AtdhNE3kgQEK36GujZ5on+tWdc+4WoaoMP/kUNxxxx</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The number of Asset Fingerprints details displayed per page in a paging query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of Asset Fingerprints detail entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The collection of Asset Fingerprints details.</para>
        /// </summary>
        [NameInMap("Propertys")]
        [Validation(Required=false)]
        public List<GetAssetsPropertyDetailResponseBodyPropertys> Propertys { get; set; }
        public class GetAssetsPropertyDetailResponseBodyPropertys : TeaModel {
            /// <summary>
            /// <para>The agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Mozilla/5.0 (Windows NT 10.0%3B Win64%3B x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/125.0.0.0 Safari/537.36 Edg/125.0.0.0</para>
            /// </summary>
            [NameInMap("Agent")]
            [Validation(Required=false)]
            public string Agent { get; set; }

            /// <summary>
            /// <para>The container name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5-rce_web_1</para>
            /// </summary>
            [NameInMap("ContainerName")]
            [Validation(Required=false)]
            public string ContainerName { get; set; }

            /// <summary>
            /// <para>The timestamp of the latest Asset Fingerprints scan, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649149566000</para>
            /// </summary>
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// <para>The asset description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;Type\&quot;: \&quot;text\&quot;, \&quot;Value\&quot;: u\&quot;\u786e\u4fdd\u7f51\u5173\u5b89\u5168\u9632\u62a4\u3002\u8981\u6c42\uff1a\u5f00\u542fWAF\u9632\u706b\u5899\u9632\u62a4\u529f\u80fd\u3002\&quot;}</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The domain name of the web site.</para>
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

            /// <summary>
            /// <para>The endpoint address of the large language model service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dashscope.aliyuncs.com</para>
            /// </summary>
            [NameInMap("EndPoint")]
            [Validation(Required=false)]
            public string EndPoint { get; set; }

            /// <summary>
            /// <para>The file path for requesting the large language model service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/root/llm.py</para>
            /// </summary>
            [NameInMap("File")]
            [Validation(Required=false)]
            public string File { get; set; }

            /// <summary>
            /// <para>The file path of the kernel module.</para>
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
            /// <para>The digest of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ImageDigest</para>
            /// </summary>
            [NameInMap("ImageDigest")]
            [Validation(Required=false)]
            public string ImageDigest { get; set; }

            /// <summary>
            /// <para>The image name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>registry-vpc.cn-beijing.aliyuncs.com/acs/aliyun-ingress-controller****</para>
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// <para>The installation path of the AI tool.</para>
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
            /// <para>The listening protocol of the web site process.</para>
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

            /// <summary>
            /// <para>The MCP name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>@modelcontextprotocol/server-github</para>
            /// </summary>
            [NameInMap("McpName")]
            [Validation(Required=false)]
            public string McpName { get; set; }

            /// <summary>
            /// <para>The name of the AI tool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vllm</para>
            /// </summary>
            [NameInMap("MiddlewareName")]
            [Validation(Required=false)]
            public string MiddlewareName { get; set; }

            /// <summary>
            /// <para>The version of the AI tool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.1</para>
            /// </summary>
            [NameInMap("MiddlewareVersion")]
            [Validation(Required=false)]
            public string MiddlewareVersion { get; set; }

            /// <summary>
            /// <para>The name of the large language model provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>阿里云百炼</para>
            /// </summary>
            [NameInMap("ModelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <para>The module name.</para>
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
            /// <para>The meaning of this parameter varies based on the value of <b>Biz</b>:</para>
            /// <list type="bullet">
            /// <item><description>When <b>Biz</b> is set to <b>web_server</b>, this parameter indicates the web root path.</description></item>
            /// <item><description>When <b>Biz</b> is set to <b>autorun</b>, this parameter indicates the startup item path.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>/lib/systemd/system****</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The directory permissions of the web site.</para>
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
            /// <para>The PID of the web site process.</para>
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
            /// <para>The port of the web site.</para>
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
            /// <para>The timestamp when the web site process started, in milliseconds.</para>
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
            /// <para>The region ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The RepoName of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACR-Example</para>
            /// </summary>
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            /// <summary>
            /// <para>The repo namespace of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default</para>
            /// </summary>
            [NameInMap("RepoNamespace")]
            [Validation(Required=false)]
            public string RepoNamespace { get; set; }

            /// <summary>
            /// <para>The type of the web site.</para>
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
            /// <para>The skill name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Analytics and Data Analysis</para>
            /// </summary>
            [NameInMap("SkillsName")]
            [Validation(Required=false)]
            public string SkillsName { get; set; }

            /// <summary>
            /// <para>The tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AI</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>The transport name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TransportName")]
            [Validation(Required=false)]
            public string TransportName { get; set; }

            /// <summary>
            /// <para>The number of dependencies on the kernel module.</para>
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
            /// <para>The user of the web site.</para>
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
            /// <para>The web path of the web site.</para>
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
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4C1AE3F3-18FA-4108-BBB9-AFA1A032****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
