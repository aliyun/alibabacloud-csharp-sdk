// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class CreateContainerGroupRequest : TeaModel {
        [NameInMap("DnsConfig")]
        [Validation(Required=false)]
        public CreateContainerGroupRequestDnsConfig DnsConfig { get; set; }
        public class CreateContainerGroupRequestDnsConfig : TeaModel {
            /// <summary>
            /// <para>The IP addresses of DNS servers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.10.<em>.</em>*</para>
            /// </summary>
            [NameInMap("NameServer")]
            [Validation(Required=false)]
            public List<string> NameServer { get; set; }

            /// <summary>
            /// <para>Configuration options of the DNS server.</para>
            /// </summary>
            [NameInMap("Option")]
            [Validation(Required=false)]
            public List<CreateContainerGroupRequestDnsConfigOption> Option { get; set; }
            public class CreateContainerGroupRequestDnsConfigOption : TeaModel {
                /// <summary>
                /// <para>The name of the option.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The value of the option.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The search domains of DNS servers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>svc.local.kubenetes</para>
            /// </summary>
            [NameInMap("Search")]
            [Validation(Required=false)]
            public List<string> Search { get; set; }

        }

        [NameInMap("HostSecurityContext")]
        [Validation(Required=false)]
        public CreateContainerGroupRequestHostSecurityContext HostSecurityContext { get; set; }
        public class CreateContainerGroupRequestHostSecurityContext : TeaModel {
            /// <summary>
            /// <para>Configure a security context to modify unsafe sysctls. For more information, see <a href="https://help.aliyun.com/document_detail/462313.html">Configure a security context</a>.</para>
            /// </summary>
            [NameInMap("Sysctl")]
            [Validation(Required=false)]
            public List<CreateContainerGroupRequestHostSecurityContextSysctl> Sysctl { get; set; }
            public class CreateContainerGroupRequestHostSecurityContextSysctl : TeaModel {
                /// <summary>
                /// <para>The name of the unsafe sysctl when you modify sysctls by configuring a security context. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>kernel.shm \* (except kernel.shm_rmid_forced)</description></item>
                /// <item><description>kernel.msg\*</description></item>
                /// <item><description>kernel.sem</description></item>
                /// <item><description>fs.mqueue.\*</description></item>
                /// <item><description>net.\*(except net.ipv4.tcp_syncookies, net.ipv4.ping_group_range, and net.ipv4.ip_unprivileged_port_start)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>kernel.msgmax</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The value of the unsafe sysctl when you modify sysctls by configuring a security context.</para>
                /// 
                /// <b>Example:</b>
                /// <para>65536</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("SecurityContext")]
        [Validation(Required=false)]
        public CreateContainerGroupRequestSecurityContext SecurityContext { get; set; }
        public class CreateContainerGroupRequestSecurityContext : TeaModel {
            /// <summary>
            /// <para>Configure a security context to modify safe sysctls. For more information, see <a href="https://help.aliyun.com/document_detail/462313.html">Configure a security context</a>.</para>
            /// </summary>
            [NameInMap("Sysctl")]
            [Validation(Required=false)]
            public List<CreateContainerGroupRequestSecurityContextSysctl> Sysctl { get; set; }
            public class CreateContainerGroupRequestSecurityContextSysctl : TeaModel {
                /// <summary>
                /// <para>The name of the safe sysctl when you modify sysctls by configuring a security context. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>net.ipv4.ping_group_range</description></item>
                /// <item><description>net.ipv4.ip_unprivileged_port_start</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>kernel.msgmax</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The value of the safe sysctl when you modify sysctls by configuring a security context.</para>
                /// 
                /// <b>Example:</b>
                /// <para>65536</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The information about the Container Registry Enterprise Edition instance that provides the image for the creation of the elastic container instance. For more information, see <a href="https://help.aliyun.com/document_detail/194250.html">Pull images from a Container Registry Enterprise Edition instance without using a secret</a>.</para>
        /// </summary>
        [NameInMap("AcrRegistryInfo")]
        [Validation(Required=false)]
        public List<CreateContainerGroupRequestAcrRegistryInfo> AcrRegistryInfo { get; set; }
        public class CreateContainerGroupRequestAcrRegistryInfo : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the RAM role in the Alibaba Cloud account to which the elastic container instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::1609982529******:role/role-assume</para>
            /// </summary>
            [NameInMap("ArnService")]
            [Validation(Required=false)]
            public string ArnService { get; set; }

            /// <summary>
            /// <para>The ARN of the RAM role in the Alibaba Cloud account to which the Container Registry Enterprise Edition instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::1298452580******:role/role-acr</para>
            /// </summary>
            [NameInMap("ArnUser")]
            [Validation(Required=false)]
            public string ArnUser { get; set; }

            /// <summary>
            /// <para>The domain names of the Container Registry Enterprise Edition instance. By default, all domain names of the instance are displayed. You can specify multiple domain names. Separate multiple domain names with commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>*****-****-registry.cn-beijing.cr.aliyuncs.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public List<string> Domain { get; set; }

            /// <summary>
            /// <para>The ID of the Container Registry Enterprise Edition instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cri-nwj395hgf6f3****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the Container Registry Enterprise Edition instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acr-test</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The region ID of the Container Registry Enterprise Edition instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The active period of the elastic container instance. After this period expires, the instance is forced to exit. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("ActiveDeadlineSeconds")]
        [Validation(Required=false)]
        public long? ActiveDeadlineSeconds { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically create an EIP and associate it with the elastic container instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoCreateEip")]
        [Validation(Required=false)]
        public bool? AutoCreateEip { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically match image caches. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoMatchImageCache")]
        [Validation(Required=false)]
        public bool? AutoMatchImageCache { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotency</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-xxxx-12d3-xxxx-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The compute category of the instance. For more information, see <a href="https://help.aliyun.com/document_detail/2638061.html">Specify a compute category to create an elastic container instance</a>.</para>
        /// </summary>
        [NameInMap("ComputeCategory")]
        [Validation(Required=false)]
        public List<string> ComputeCategory { get; set; }

        /// <summary>
        /// <para>The information about the container.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Container")]
        [Validation(Required=false)]
        public List<CreateContainerGroupRequestContainer> Container { get; set; }
        public class CreateContainerGroupRequestContainer : TeaModel {
            [NameInMap("LivenessProbe")]
            [Validation(Required=false)]
            public CreateContainerGroupRequestContainerLivenessProbe LivenessProbe { get; set; }
            public class CreateContainerGroupRequestContainerLivenessProbe : TeaModel {
                [NameInMap("Exec")]
                [Validation(Required=false)]
                public CreateContainerGroupRequestContainerLivenessProbeExec Exec { get; set; }
                public class CreateContainerGroupRequestContainerLivenessProbeExec : TeaModel {
                    [NameInMap("Command")]
                    [Validation(Required=false)]
                    public List<string> Command { get; set; }

                }

                [NameInMap("FailureThreshold")]
                [Validation(Required=false)]
                public int? FailureThreshold { get; set; }

                [NameInMap("HttpGet")]
                [Validation(Required=false)]
                public CreateContainerGroupRequestContainerLivenessProbeHttpGet HttpGet { get; set; }
                public class CreateContainerGroupRequestContainerLivenessProbeHttpGet : TeaModel {
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    [NameInMap("Scheme")]
                    [Validation(Required=false)]
                    public string Scheme { get; set; }

                }

                [NameInMap("InitialDelaySeconds")]
                [Validation(Required=false)]
                public int? InitialDelaySeconds { get; set; }

                [NameInMap("PeriodSeconds")]
                [Validation(Required=false)]
                public int? PeriodSeconds { get; set; }

                [NameInMap("SuccessThreshold")]
                [Validation(Required=false)]
                public int? SuccessThreshold { get; set; }

                [NameInMap("TcpSocket")]
                [Validation(Required=false)]
                public CreateContainerGroupRequestContainerLivenessProbeTcpSocket TcpSocket { get; set; }
                public class CreateContainerGroupRequestContainerLivenessProbeTcpSocket : TeaModel {
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                }

                [NameInMap("TimeoutSeconds")]
                [Validation(Required=false)]
                public int? TimeoutSeconds { get; set; }

            }

            [NameInMap("ReadinessProbe")]
            [Validation(Required=false)]
            public CreateContainerGroupRequestContainerReadinessProbe ReadinessProbe { get; set; }
            public class CreateContainerGroupRequestContainerReadinessProbe : TeaModel {
                [NameInMap("Exec")]
                [Validation(Required=false)]
                public CreateContainerGroupRequestContainerReadinessProbeExec Exec { get; set; }
                public class CreateContainerGroupRequestContainerReadinessProbeExec : TeaModel {
                    [NameInMap("Command")]
                    [Validation(Required=false)]
                    public List<string> Command { get; set; }

                }

                [NameInMap("FailureThreshold")]
                [Validation(Required=false)]
                public int? FailureThreshold { get; set; }

                [NameInMap("HttpGet")]
                [Validation(Required=false)]
                public CreateContainerGroupRequestContainerReadinessProbeHttpGet HttpGet { get; set; }
                public class CreateContainerGroupRequestContainerReadinessProbeHttpGet : TeaModel {
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    [NameInMap("Scheme")]
                    [Validation(Required=false)]
                    public string Scheme { get; set; }

                }

                [NameInMap("InitialDelaySeconds")]
                [Validation(Required=false)]
                public int? InitialDelaySeconds { get; set; }

                [NameInMap("PeriodSeconds")]
                [Validation(Required=false)]
                public int? PeriodSeconds { get; set; }

                [NameInMap("SuccessThreshold")]
                [Validation(Required=false)]
                public int? SuccessThreshold { get; set; }

                [NameInMap("TcpSocket")]
                [Validation(Required=false)]
                public CreateContainerGroupRequestContainerReadinessProbeTcpSocket TcpSocket { get; set; }
                public class CreateContainerGroupRequestContainerReadinessProbeTcpSocket : TeaModel {
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                }

                [NameInMap("TimeoutSeconds")]
                [Validation(Required=false)]
                public int? TimeoutSeconds { get; set; }

            }

            [NameInMap("SecurityContext")]
            [Validation(Required=false)]
            public CreateContainerGroupRequestContainerSecurityContext SecurityContext { get; set; }
            public class CreateContainerGroupRequestContainerSecurityContext : TeaModel {
                [NameInMap("Capability")]
                [Validation(Required=false)]
                public CreateContainerGroupRequestContainerSecurityContextCapability Capability { get; set; }
                public class CreateContainerGroupRequestContainerSecurityContextCapability : TeaModel {
                    [NameInMap("Add")]
                    [Validation(Required=false)]
                    public List<string> Add { get; set; }

                }

                [NameInMap("ReadOnlyRootFilesystem")]
                [Validation(Required=false)]
                public bool? ReadOnlyRootFilesystem { get; set; }

                [NameInMap("RunAsUser")]
                [Validation(Required=false)]
                public long? RunAsUser { get; set; }

            }

            /// <summary>
            /// <para>The arguments that are passed to the startup command of the container. You can specify up to 10 arguments.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Arg")]
            [Validation(Required=false)]
            public List<string> Arg { get; set; }

            /// <summary>
            /// <para>The commands to be executed in the container when you use a CLI to perform health checks.</para>
            /// <remarks>
            /// <para> When you configure ReadinessProbe-related parameters, you can select only one of the HttpGet, Exec, and TcpSocket check methods.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>sleep</para>
            /// </summary>
            [NameInMap("Command")]
            [Validation(Required=false)]
            public List<string> Command { get; set; }

            /// <summary>
            /// <para>The number of vCPUs that you want to allocate to the container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.25</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public float? Cpu { get; set; }

            /// <summary>
            /// <para>The environment variables of the container.</para>
            /// </summary>
            [NameInMap("EnvironmentVar")]
            [Validation(Required=false)]
            public List<CreateContainerGroupRequestContainerEnvironmentVar> EnvironmentVar { get; set; }
            public class CreateContainerGroupRequestContainerEnvironmentVar : TeaModel {
                [NameInMap("FieldRef")]
                [Validation(Required=false)]
                public CreateContainerGroupRequestContainerEnvironmentVarFieldRef FieldRef { get; set; }
                public class CreateContainerGroupRequestContainerEnvironmentVarFieldRef : TeaModel {
                    [NameInMap("FieldPath")]
                    [Validation(Required=false)]
                    public string FieldPath { get; set; }

                }

                /// <summary>
                /// <para>The name of the environment variable. The name must be 1 to 128 characters in length and can contain letters, digits, and underscores (_). It cannot start with a digit.``</para>
                /// 
                /// <b>Example:</b>
                /// <para>PATH</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the environment variable. The value can be up to 256 characters in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/usr/local/bin</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to hide the information about environment variables when you query the details of an elastic container instance. Default value: false. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>false</description></item>
            /// <item><description>true If environment variables contain sensitive information, you can set this parameter to true to improve security of the information.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnvironmentVarHide")]
            [Validation(Required=false)]
            public bool? EnvironmentVarHide { get; set; }

            /// <summary>
            /// <para>The number of GPUs that you want to allocate to the container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Gpu")]
            [Validation(Required=false)]
            public int? Gpu { get; set; }

            /// <summary>
            /// <para>The image of the container.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>registry-vpc.cn-hangzhou.aliyuncs.com/eci_open/nginx:latest</para>
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            /// <summary>
            /// <para>The policy that you want to use to pull images. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Always: Each time instances are created, image pulling is performed.</description></item>
            /// <item><description>IfNotPresent: On-premises images are preferentially used. If no on-premises images are available, image pulling is performed.</description></item>
            /// <item><description>Never: On-premises images are always used. Image pulling is not performed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Always</para>
            /// </summary>
            [NameInMap("ImagePullPolicy")]
            [Validation(Required=false)]
            public string ImagePullPolicy { get; set; }

            /// <summary>
            /// <para>The commands to be executed in containers when you use a CLI to specify a postStart hook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;/bin/sh&quot;, &quot;-c&quot;, &quot;echo Hello from the postStart handler &gt; /usr/share/message&quot;]</para>
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerExec")]
            [Validation(Required=false)]
            public List<string> LifecyclePostStartHandlerExec { get; set; }

            /// <summary>
            /// <para>The IP address of the host that receives the HTTP GET request when you use an HTTP request to specify a postStart hook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.XX.XX</para>
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerHttpGetHost")]
            [Validation(Required=false)]
            public string LifecyclePostStartHandlerHttpGetHost { get; set; }

            /// <summary>
            /// <para>The HTTP GET request header.</para>
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerHttpGetHttpHeader")]
            [Validation(Required=false)]
            public List<CreateContainerGroupRequestContainerLifecyclePostStartHandlerHttpGetHttpHeader> LifecyclePostStartHandlerHttpGetHttpHeader { get; set; }
            public class CreateContainerGroupRequestContainerLifecyclePostStartHandlerHttpGetHttpHeader : TeaModel {
                /// <summary>
                /// <para>The name of the custom field in the HTTP GET request header when you use HTTP requests to specify a postStart hook.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Xiao-Custom-Header</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The value of the custom field in the HTTP GET request header when you use HTTP requests to specify a postStart hook.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-postStart</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The path to which the system sends an HTTP GET request for a health check when you use an HTTP request to specify a postStart hook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/healthyz</para>
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerHttpGetPath")]
            [Validation(Required=false)]
            public string LifecyclePostStartHandlerHttpGetPath { get; set; }

            /// <summary>
            /// <para>The port to which the system sends an HTTP GET request when you use an HTTP request to specify a postStart hook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5050</para>
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerHttpGetPort")]
            [Validation(Required=false)]
            public int? LifecyclePostStartHandlerHttpGetPort { get; set; }

            /// <summary>
            /// <para>The protocol type of HTTP GET requests when you use HTTP requests to specify a postStart hook. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>HTTP</description></item>
            /// <item><description>HTTPS</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HTTPS</para>
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerHttpGetScheme")]
            [Validation(Required=false)]
            public string LifecyclePostStartHandlerHttpGetScheme { get; set; }

            /// <summary>
            /// <para>The IP address of the host that receives the TCP socket request when you use a TCP socket request to specify a postStart hook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.XX.XX</para>
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerTcpSocketHost")]
            [Validation(Required=false)]
            public string LifecyclePostStartHandlerTcpSocketHost { get; set; }

            /// <summary>
            /// <para>The port to which the system sends a TCP socket request for a health check when you use TCP sockets to specify a postStart hook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("LifecyclePostStartHandlerTcpSocketPort")]
            [Validation(Required=false)]
            public int? LifecyclePostStartHandlerTcpSocketPort { get; set; }

            /// <summary>
            /// <para>The commands to be executed in containers when you use a CLI to specify a preStop hook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;/bin/sh&quot;, &quot;-c&quot;,&quot;echo Hello from the preStop handler &gt; /usr/share/message&quot;]</para>
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerExec")]
            [Validation(Required=false)]
            public List<string> LifecyclePreStopHandlerExec { get; set; }

            /// <summary>
            /// <para>The IP address of the host that receives the HTTP GET request when you use an HTTP request to specify a preStop hook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.XX.XX</para>
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerHttpGetHost")]
            [Validation(Required=false)]
            public string LifecyclePreStopHandlerHttpGetHost { get; set; }

            /// <summary>
            /// <para>The HTTP GET request header.</para>
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerHttpGetHttpHeader")]
            [Validation(Required=false)]
            public List<CreateContainerGroupRequestContainerLifecyclePreStopHandlerHttpGetHttpHeader> LifecyclePreStopHandlerHttpGetHttpHeader { get; set; }
            public class CreateContainerGroupRequestContainerLifecyclePreStopHandlerHttpGetHttpHeader : TeaModel {
                /// <summary>
                /// <para>The name of the custom field in the HTTP GET request header when you use HTTP requests to specify a presto hook.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Xiao-Custom-Header</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The value of the custom field in the HTTP GET request header when you use HTTP requests to specify a preStop hook.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-preStop</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The path to which the system sends an HTTP GET request for a health check when you use an HTTP request to specify a preSop hook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/healthyz</para>
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerHttpGetPath")]
            [Validation(Required=false)]
            public string LifecyclePreStopHandlerHttpGetPath { get; set; }

            /// <summary>
            /// <para>The port to which the system sends an HTTP GET request for a health check when you use HTTP requests to specify a preStop hook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>88</para>
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerHttpGetPort")]
            [Validation(Required=false)]
            public int? LifecyclePreStopHandlerHttpGetPort { get; set; }

            /// <summary>
            /// <para>The protocol type of the HTTP GET request when you use an HTTP request to specify a preStop hook. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>HTTP</description></item>
            /// <item><description>HTTPS</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerHttpGetScheme")]
            [Validation(Required=false)]
            public string LifecyclePreStopHandlerHttpGetScheme { get; set; }

            /// <summary>
            /// <para>The IP address of the host that receives the TCP socket request when you use a TCP socket request to specify a preStop hook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.XX.XX</para>
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerTcpSocketHost")]
            [Validation(Required=false)]
            public string LifecyclePreStopHandlerTcpSocketHost { get; set; }

            /// <summary>
            /// <para>The port to which the system sends a TCP socket request for a health check when you use TCP sockets to specify a preStop hook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("LifecyclePreStopHandlerTcpSocketPort")]
            [Validation(Required=false)]
            public int? LifecyclePreStopHandlerTcpSocketPort { get; set; }

            /// <summary>
            /// <para>The memory size of the container. Unit: GiB</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

            /// <summary>
            /// <para>The name of the container.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nginx</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The port to which the system sends an HTTP GET request for a health check when you use HTTP requests to perform health checks.</para>
            /// <remarks>
            /// <para> When you configure LivenessProbe-related parameters, you can select only one of the HttpGet, Exec, and TcpSocket check methods.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public List<CreateContainerGroupRequestContainerPort> Port { get; set; }
            public class CreateContainerGroupRequestContainerPort : TeaModel {
                /// <summary>
                /// <para>The port number. Valid values: 1 to 65535.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The type of the protocol. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>TCP</description></item>
                /// <item><description>UDP</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>TCP</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable privileged mode for the container. That is, whether to run the container in privileged mode. Default value: false. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SecurityContextPrivileged")]
            [Validation(Required=false)]
            public bool? SecurityContextPrivileged { get; set; }

            /// <summary>
            /// <para>The user group that runs the container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3000</para>
            /// </summary>
            [NameInMap("SecurityContextRunAsGroup")]
            [Validation(Required=false)]
            public long? SecurityContextRunAsGroup { get; set; }

            /// <summary>
            /// <para>Specifies whether to run the container as a non-root user. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SecurityContextRunAsNonRoot")]
            [Validation(Required=false)]
            public bool? SecurityContextRunAsNonRoot { get; set; }

            /// <summary>
            /// <para>Specifies whether the container allocates buffer resources to standard input streams when the container is running. If you do not specify this parameter, an end-of-file (EOF) error may occur when standard input streams in the container are read. Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Stdin")]
            [Validation(Required=false)]
            public bool? Stdin { get; set; }

            /// <summary>
            /// <para>Specifies whether standard input streams are disconnected from multiple sessions after a client is disconnected.\
            /// If StdinOnce is set to true, standard input streams are connected after the container is started, and remain idle until a client is connected to receive data. After the client is disconnected, standard input streams are also disconnected, and remain disconnected until the container restarts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("StdinOnce")]
            [Validation(Required=false)]
            public bool? StdinOnce { get; set; }

            /// <summary>
            /// <para>The path of the file from which the system retrieves termination messages of the container when the container exits.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/tmp/termination-log</para>
            /// </summary>
            [NameInMap("TerminationMessagePath")]
            [Validation(Required=false)]
            public string TerminationMessagePath { get; set; }

            /// <summary>
            /// <para>The message notification policy. This parameter is empty by default. Only Message Service (MNS) queue message notifications can be sent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FallbackToLogsOnError</para>
            /// </summary>
            [NameInMap("TerminationMessagePolicy")]
            [Validation(Required=false)]
            public string TerminationMessagePolicy { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable interaction. Default value: false.</para>
            /// <para>If the command is a /bin/bash command, set the value to true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Tty")]
            [Validation(Required=false)]
            public bool? Tty { get; set; }

            /// <summary>
            /// <para>The information about the volume that you want to mount on the container.</para>
            /// </summary>
            [NameInMap("VolumeMount")]
            [Validation(Required=false)]
            public List<CreateContainerGroupRequestContainerVolumeMount> VolumeMount { get; set; }
            public class CreateContainerGroupRequestContainerVolumeMount : TeaModel {
                /// <summary>
                /// <para>The directory to which the volume is mounted.</para>
                /// <remarks>
                /// <para> The data stored in this directory is overwritten by the data on the volume. Specify this parameter with caution.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>/pod/data</para>
                /// </summary>
                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The mount propagation settings of the volume. Mount propagation allows volumes that are mounted on one container to be shared with other containers in the same pod, or even with other pods on the same node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>None: The volume mount does not receive subsequent mounts that are performed on this volume or subdirectories of this volume.</description></item>
                /// <item><description>HostToCotainer: The volume mount receives subsequent mounts that are performed on this volume or the subdirectories of this volume.</description></item>
                /// <item><description>Bidirectional: This value is similar to HostToContainer. The volume mount receives subsequent mounts that are performed on this volume or the subdirectories of this volume. In addition, all volume mounts that are mounted on the container are propagated back to the host and all containers of all pods that use the same volume.</description></item>
                /// </list>
                /// <para>Default value: None.</para>
                /// 
                /// <b>Example:</b>
                /// <para>None</para>
                /// </summary>
                [NameInMap("MountPropagation")]
                [Validation(Required=false)]
                public string MountPropagation { get; set; }

                /// <summary>
                /// <para>The name of the volume. The value of this parameter is the same as the name of the volume that is mounted to containers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default-volume1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Specifies whether the volume is read-only. Default value: false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ReadOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

                /// <summary>
                /// <para>The subdirectory of the volume.</para>
                /// 
                /// <b>Example:</b>
                /// <para>data2/</para>
                /// </summary>
                [NameInMap("SubPath")]
                [Validation(Required=false)]
                public string SubPath { get; set; }

            }

            /// <summary>
            /// <para>The working directory of the container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/usr/local/</para>
            /// </summary>
            [NameInMap("WorkingDir")]
            [Validation(Required=false)]
            public string WorkingDir { get; set; }

        }

        /// <summary>
        /// <para>The name of the elastic container instance (container group). The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name must be 2 to 128 characters in length.</description></item>
        /// <item><description>The name can contain lowercase letters, digits, and hyphens (-). It cannot start or end with a hyphen (-).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nginx-test</para>
        /// </summary>
        [NameInMap("ContainerGroupName")]
        [Validation(Required=false)]
        public string ContainerGroupName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable container resource view. Container resource view displays the actual container resource data instead of data of the host. If the specifications of the generated elastic container instance are larger than the specifications that you request for when you create the instance, you can enable the ContainerResourceView feature to ensure that the resources that you view in the container are the same as the resources that you request for.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ContainerResourceView")]
        [Validation(Required=false)]
        public bool? ContainerResourceView { get; set; }

        /// <summary>
        /// <para>The path to core dump files. For more information, see <a href="https://help.aliyun.com/document_detail/167801.html">Save core files to volumes</a>.</para>
        /// <remarks>
        /// <para> The path cannot start with |. You cannot use core dump files to configure executable programs.``</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/xx/xx/core</para>
        /// </summary>
        [NameInMap("CorePattern")]
        [Validation(Required=false)]
        public string CorePattern { get; set; }

        /// <summary>
        /// <para>The number of vCPUs that you want to allocate to the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        /// <summary>
        /// <para>The CPU architecture of the instance. Default value: AMD64. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AMD64</description></item>
        /// <item><description>ARM64</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ARM64</para>
        /// </summary>
        [NameInMap("CpuArchitecture")]
        [Validation(Required=false)]
        public string CpuArchitecture { get; set; }

        /// <summary>
        /// <para>The number of physical CPU cores. You can specify this parameter for only specific ECS instance types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CpuOptionsCore")]
        [Validation(Required=false)]
        public int? CpuOptionsCore { get; set; }

        /// <summary>
        /// <para>This parameter is not available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CpuOptionsNuma")]
        [Validation(Required=false)]
        public string CpuOptionsNuma { get; set; }

        /// <summary>
        /// <para>The number of threads per core. You can specify this parameter for only specific ECS instance types. A value of 1 specifies that Hyper-Threading is disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CpuOptionsThreadsPerCore")]
        [Validation(Required=false)]
        public int? CpuOptionsThreadsPerCore { get; set; }

        /// <summary>
        /// <para>The bucket that stores the data cache.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("DataCacheBucket")]
        [Validation(Required=false)]
        public string DataCacheBucket { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the performance burst feature when ESSDs AutoPL are used to store data caches. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSDs AutoPL</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DataCacheBurstingEnabled")]
        [Validation(Required=false)]
        public bool? DataCacheBurstingEnabled { get; set; }

        /// <summary>
        /// <para>The performance level (PL) of the disk that you want to use to store data caches.\
        /// Enhanced SSDs (ESSDs) are preferentially used to store data caches. The default performance level is PL1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL1</para>
        /// </summary>
        [NameInMap("DataCachePL")]
        [Validation(Required=false)]
        public string DataCachePL { get; set; }

        /// <summary>
        /// <para>The input/output operations per second (IOPS) provisioned for ESSDs AutoPL when ESSDs AutoPL are used to store data caches.\
        /// Valid values: 0 to min{50000, 1000 × Storage capacity - Baseline IOPS}. Baseline IOPS = min{1,800 + 50 × Storage capacity, 50,000}.\
        /// For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSDs AutoPL</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40000</para>
        /// </summary>
        [NameInMap("DataCacheProvisionedIops")]
        [Validation(Required=false)]
        public long? DataCacheProvisionedIops { get; set; }

        /// <summary>
        /// <para>The Domain Name System (DNS) policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>None: uses the DNS that is specified by DnsConfig.</description></item>
        /// <item><description>Default: uses the DNS that is specified for the runtime environment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("DnsPolicy")]
        [Validation(Required=false)]
        public string DnsPolicy { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, service limits, and available resources. If the request passes the dry run, the DryRunOperation error code is returned. Otherwise, an error message is returned.</description></item>
        /// <item><description>false (default): performs a dry run and performs the actual request. If the request passes the dry run, the elastic container instance is created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The maximum outbound bandwidth. Unit: bit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024000</para>
        /// </summary>
        [NameInMap("EgressBandwidth")]
        [Validation(Required=false)]
        public long? EgressBandwidth { get; set; }

        /// <summary>
        /// <para>The maximum bandwidth value for the EIP. Unit: Mbit/s. Default value: 5.\
        /// This parameter is valid only when AutoCreateEip is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("EipBandwidth")]
        [Validation(Required=false)]
        public int? EipBandwidth { get; set; }

        /// <summary>
        /// <para>The EIP bandwidth plan that you want to associate with the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cbwp-2zeukbj916scmj51m****</para>
        /// </summary>
        [NameInMap("EipCommonBandwidthPackage")]
        [Validation(Required=false)]
        public string EipCommonBandwidthPackage { get; set; }

        /// <summary>
        /// <para>The line type of the EIP. Default value: BGP. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BGP: BGP (Multi-ISP) line</description></item>
        /// <item><description>BGP_PRO: BGP (Multi-ISP) Pro line</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BPG</para>
        /// </summary>
        [NameInMap("EipISP")]
        [Validation(Required=false)]
        public string EipISP { get; set; }

        /// <summary>
        /// <para>The ID of the elastic IP address (EIP).</para>
        /// 
        /// <b>Example:</b>
        /// <para>eip-uf66jeqopgqa9hdn****</para>
        /// </summary>
        [NameInMap("EipInstanceId")]
        [Validation(Required=false)]
        public string EipInstanceId { get; set; }

        /// <summary>
        /// <para>The increased capacity of the temporary storage space. Unit: GiB.\
        /// For more information, see <a href="https://help.aliyun.com/document_detail/204066.html">Increase the size of the temporary storage space</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("EphemeralStorage")]
        [Validation(Required=false)]
        public int? EphemeralStorage { get; set; }

        /// <summary>
        /// <para>Specifies whether to configure the instance to use a fixed IP address. For more information, see <a href="https://help.aliyun.com/document_detail/2381086.html">Configure an elastic container instance to use a fixed IP address</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("FixedIp")]
        [Validation(Required=false)]
        public string FixedIp { get; set; }

        /// <summary>
        /// <para>The retention period of the fixed IP address after the original instance is released and the fixed IP address becomes idle. Unit: hours. Default value: 48.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("FixedIpRetainHour")]
        [Validation(Required=false)]
        public int? FixedIpRetainHour { get; set; }

        /// <summary>
        /// <para>The version of the GPU driver. Default value: tesla=470.82.01. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>tesla=470.82.01</description></item>
        /// <item><description>tesla=525.85.12</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can switch the GPU driver version only for a few Elastic Compute Service (ECS) instance types. For more information, see <a href="https://help.aliyun.com/document_detail/2579486.html">Specify GPU-accelerated ECS instance types to create an elastic container instance</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>tesla=525.85.12</para>
        /// </summary>
        [NameInMap("GpuDriverVersion")]
        [Validation(Required=false)]
        public string GpuDriverVersion { get; set; }

        /// <summary>
        /// <para>The alias of the elastic container instance.</para>
        /// </summary>
        [NameInMap("HostAliase")]
        [Validation(Required=false)]
        public List<CreateContainerGroupRequestHostAliase> HostAliase { get; set; }
        public class CreateContainerGroupRequestHostAliase : TeaModel {
            /// <summary>
            /// <para>The hostnames of the elastic container instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hehe.com</para>
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public List<string> Hostname { get; set; }

            /// <summary>
            /// <para>The IP address of the elastic container instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.1.1</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

        }

        /// <summary>
        /// <para>The hostname.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <para>The image acceleration mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>nydus: uses Nydus to accelerate image pulling. The images must support Nydus.</description></item>
        /// <item><description>dadi: uses DADI to accelerate image pulling. The images must support DADI.</description></item>
        /// <item><description>p2p: uses P2P to accelerate image pulling. The images must support p2p.</description></item>
        /// <item><description>imc: uses image caches to accelerate image pulling.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>imc</para>
        /// </summary>
        [NameInMap("ImageAccelerateMode")]
        [Validation(Required=false)]
        public string ImageAccelerateMode { get; set; }

        /// <summary>
        /// <para>The information about the logon credentials.</para>
        /// </summary>
        [NameInMap("ImageRegistryCredential")]
        [Validation(Required=false)]
        public List<CreateContainerGroupRequestImageRegistryCredential> ImageRegistryCredential { get; set; }
        public class CreateContainerGroupRequestImageRegistryCredential : TeaModel {
            /// <summary>
            /// <para>The password that you use to access the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yourpassword</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The address of the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>registry-vpc.cn-shanghai.aliyuncs.com</para>
            /// </summary>
            [NameInMap("Server")]
            [Validation(Required=false)]
            public string Server { get; set; }

            /// <summary>
            /// <para>The username that you use to access the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yourusername</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the image cache. For more information, see <a href="https://help.aliyun.com/document_detail/141281.html">Use image caches to accelerate the creation of instances</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>imc-2zebxkiifuyzzlhl****</para>
        /// </summary>
        [NameInMap("ImageSnapshotId")]
        [Validation(Required=false)]
        public string ImageSnapshotId { get; set; }

        /// <summary>
        /// <para>The maximum inbound bandwidth. Unit: bit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024000</para>
        /// </summary>
        [NameInMap("IngressBandwidth")]
        [Validation(Required=false)]
        public long? IngressBandwidth { get; set; }

        /// <summary>
        /// <para>The information about the init containers.</para>
        /// </summary>
        [NameInMap("InitContainer")]
        [Validation(Required=false)]
        public List<CreateContainerGroupRequestInitContainer> InitContainer { get; set; }
        public class CreateContainerGroupRequestInitContainer : TeaModel {
            [NameInMap("SecurityContext")]
            [Validation(Required=false)]
            public CreateContainerGroupRequestInitContainerSecurityContext SecurityContext { get; set; }
            public class CreateContainerGroupRequestInitContainerSecurityContext : TeaModel {
                [NameInMap("Capability")]
                [Validation(Required=false)]
                public CreateContainerGroupRequestInitContainerSecurityContextCapability Capability { get; set; }
                public class CreateContainerGroupRequestInitContainerSecurityContextCapability : TeaModel {
                    [NameInMap("Add")]
                    [Validation(Required=false)]
                    public List<string> Add { get; set; }

                }

                [NameInMap("ReadOnlyRootFilesystem")]
                [Validation(Required=false)]
                public bool? ReadOnlyRootFilesystem { get; set; }

                [NameInMap("RunAsUser")]
                [Validation(Required=false)]
                public long? RunAsUser { get; set; }

            }

            /// <summary>
            /// <para>The arguments that are passed to the startup command of the init container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Arg")]
            [Validation(Required=false)]
            public List<string> Arg { get; set; }

            /// <summary>
            /// <para>The startup commands of the init container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sleep</para>
            /// </summary>
            [NameInMap("Command")]
            [Validation(Required=false)]
            public List<string> Command { get; set; }

            /// <summary>
            /// <para>The number of vCPUs that you want to allocate to the init container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public float? Cpu { get; set; }

            /// <summary>
            /// <para>The environment variable of the init container.</para>
            /// </summary>
            [NameInMap("EnvironmentVar")]
            [Validation(Required=false)]
            public List<CreateContainerGroupRequestInitContainerEnvironmentVar> EnvironmentVar { get; set; }
            public class CreateContainerGroupRequestInitContainerEnvironmentVar : TeaModel {
                [NameInMap("FieldRef")]
                [Validation(Required=false)]
                public CreateContainerGroupRequestInitContainerEnvironmentVarFieldRef FieldRef { get; set; }
                public class CreateContainerGroupRequestInitContainerEnvironmentVarFieldRef : TeaModel {
                    [NameInMap("FieldPath")]
                    [Validation(Required=false)]
                    public string FieldPath { get; set; }

                }

                /// <summary>
                /// <para>The name of the environment variable. The name must be 1 to 128 bits in length and can contain letters, digits, and underscores (_). It cannot start with a digit.``</para>
                /// 
                /// <b>Example:</b>
                /// <para>Path</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the environment variable. The value must be 0 to 256 bits in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/usr/bin/</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The number of GPUs that you want to allocate to the init container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Gpu")]
            [Validation(Required=false)]
            public int? Gpu { get; set; }

            /// <summary>
            /// <para>The image of the init container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nginx</para>
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            /// <summary>
            /// <para>The policy that you want to use to pull images. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Always: Each time instances are created, image pulling is performed.</description></item>
            /// <item><description>IfNotPresent: On-premises images are preferentially used. If no on-premises images are available, image pulling is performed.</description></item>
            /// <item><description>Never: On-premises images are always used. Image pulling is not performed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Always</para>
            /// </summary>
            [NameInMap("ImagePullPolicy")]
            [Validation(Required=false)]
            public string ImagePullPolicy { get; set; }

            /// <summary>
            /// <para>The memory size that you want to allocate to the init container. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

            /// <summary>
            /// <para>The name of the init container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-init</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The information about the port.</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public List<CreateContainerGroupRequestInitContainerPort> Port { get; set; }
            public class CreateContainerGroupRequestInitContainerPort : TeaModel {
                /// <summary>
                /// <para>The port number. Valid values: 1 to 65535.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8888</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The protocol type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>TCP</description></item>
                /// <item><description>UDP</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>TCP</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

            }

            /// <summary>
            /// <para>The path of the file from which the system retrieves termination messages of the init container when the init container exits.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/tmp/termination-log</para>
            /// </summary>
            [NameInMap("TerminationMessagePath")]
            [Validation(Required=false)]
            public string TerminationMessagePath { get; set; }

            /// <summary>
            /// <para>The message notification policy. This parameter is empty by default.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("TerminationMessagePolicy")]
            [Validation(Required=false)]
            public string TerminationMessagePolicy { get; set; }

            /// <summary>
            /// <para>The information about the volumes that you want to mount to the init containers.</para>
            /// </summary>
            [NameInMap("VolumeMount")]
            [Validation(Required=false)]
            public List<CreateContainerGroupRequestInitContainerVolumeMount> VolumeMount { get; set; }
            public class CreateContainerGroupRequestInitContainerVolumeMount : TeaModel {
                /// <summary>
                /// <para>The directory to which the volume is mounted. The data stored in this directory is overwritten by the data on the volume. Specify this parameter with caution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/usr/share/</para>
                /// </summary>
                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The mount propagation settings of the volume. Mount propagation allows volumes that are mounted on one init container to be shared with other init containers in the same pod, or even with other pods on the same node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>None: The volume mount does not receive subsequent mounts that are performed on this volume or subdirectories of this volume.</description></item>
                /// <item><description>HostToCotainer: The volume mount receives subsequent mounts that are performed on this volume or the subdirectories of this volume.</description></item>
                /// <item><description>Bidirectional: This value is similar to HostToContainer. The volume mount receives subsequent mounts that are performed on this volume or the subdirectories of this volume. In addition, all volume mounts that are mounted on the init container are propagated back to the host and all init containers of all pods that use the same volume.</description></item>
                /// </list>
                /// <para>Default value: None.</para>
                /// 
                /// <b>Example:</b>
                /// <para>None</para>
                /// </summary>
                [NameInMap("MountPropagation")]
                [Validation(Required=false)]
                public string MountPropagation { get; set; }

                /// <summary>
                /// <para>The name of the volume.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-empty</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Specifies whether the mount path is read-only. Default value: false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ReadOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

                /// <summary>
                /// <para>The subdirectory of the volume. The pod can mount different directories of the same volume to different subdirectories of init containers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/usr/sub/</para>
                /// </summary>
                [NameInMap("SubPath")]
                [Validation(Required=false)]
                public string SubPath { get; set; }

            }

            /// <summary>
            /// <para>The working directory of the init container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/usr/local</para>
            /// </summary>
            [NameInMap("WorkingDir")]
            [Validation(Required=false)]
            public string WorkingDir { get; set; }

        }

        /// <summary>
        /// <para>The address of the self-managed image repository. When you create an elastic container instance by using an image in a self-managed image repository that uses a self-signed certificate, you must specify this parameter to skip the certificate authentication. This prevents image pull failures caused by certificate authentication failures.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;harbor***.pre.com,192.168.XX.XX:5000,reg***.test.com:80&quot;</para>
        /// </summary>
        [NameInMap("InsecureRegistry")]
        [Validation(Required=false)]
        public string InsecureRegistry { get; set; }

        /// <summary>
        /// <para>The ECS instance types that you specify to create the elastic container instance. Multiple instance types are supported. For more information, see <a href="https://help.aliyun.com/document_detail/114664.html">Specify ECS instance types to create an elastic container instance</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.c5.xlarge</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The number of IPv6 addresses that are assigned to the instance. Set the value to 1. You can assign only one IPv6 address to an elastic container instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Ipv6AddressCount")]
        [Validation(Required=false)]
        public int? Ipv6AddressCount { get; set; }

        /// <summary>
        /// <para>The maximum IPv6 Internet bandwidth when you set Ipv6GatewayBandwidthEnable to true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If the billing method for IPv6 network usage is pay-by-bandwidth, the maximum IPv6 Internet bandwidth ranges from 1 to 2,000 Mbit/s.</para>
        /// </description></item>
        /// <item><description><para>If the billing method for IPv6 network usage is pay-by-traffic, the maximum IPv6 Internet bandwidth varies based on the edition of the IPv6 gateway.</para>
        /// <list type="bullet">
        /// <item><description>If the IPv6 gateway is of Free Edition, the maximum IPv6 Internet bandwidth ranges from 1 to 200 Mbit/s.</description></item>
        /// <item><description>If the IPv6 gateway is of Enterprise Edition, the maximum IPv6 Internet bandwidth ranges from 1 to 500 Mbit/s.</description></item>
        /// <item><description>If the IPv6 gateway is of Enhanced Enterprise Edition, the maximum IPv6 Internet bandwidth ranges from 1 to 1000 Mbit/s.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>The default value is the maximum value in the Internet bandwidth range of the IPv6 gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Ipv6GatewayBandwidth")]
        [Validation(Required=false)]
        public string Ipv6GatewayBandwidth { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Internet access to the elastic container instance over IPv6 addresses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Ipv6GatewayBandwidthEnable")]
        [Validation(Required=false)]
        public bool? Ipv6GatewayBandwidthEnable { get; set; }

        /// <summary>
        /// <para>The memory size that you want to allocate to the instance. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public float? Memory { get; set; }

        /// <summary>
        /// <para>The endpoints of the Network Time Protocol (NTP) servers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ntp.cloud.aliyuncs.com</para>
        /// </summary>
        [NameInMap("NtpServer")]
        [Validation(Required=false)]
        public List<string> NtpServer { get; set; }

        /// <summary>
        /// <para>The operating system of the elastic container instance. Default value: Linux. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Linux</description></item>
        /// <item><description>Windows</description></item>
        /// </list>
        /// <remarks>
        /// <para> Windows instances are in invitational preview. To use the operating system, submit a ticket.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Windows</para>
        /// </summary>
        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        /// <summary>
        /// <para>The options that you can configure when you enable the overhead reservation feature.</para>
        /// </summary>
        [NameInMap("OverheadReservationOption")]
        [Validation(Required=false)]
        public CreateContainerGroupRequestOverheadReservationOption OverheadReservationOption { get; set; }
        public class CreateContainerGroupRequestOverheadReservationOption : TeaModel {
            /// <summary>
            /// <para>Specify whether to enable the overhead reservation feature. Default: false. Valid values: true and false. After you enable the overhead reservation feature, the system automatically adds the overhead to the specification of the elastic container instance, and then adjusts the specification of the instance upward to the most approximate specification. You are charged based on the new specification after the adjustment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableOverheadReservation")]
            [Validation(Required=false)]
            public bool? EnableOverheadReservation { get; set; }

        }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The address of the self-managed image repository. When you create an elastic container instance by using an image in a self-managed image repository that uses the HTTP protocol, you must specify this parameter. This way, Elastic Container Instance pulls the image over the HTTP protocol instead of the default HTTPS protocol. This prevents image pull failures caused by different protocols.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;harbor***.pre.com,192.168.XX.XX:5000,reg***.test.com:80&quot;</para>
        /// </summary>
        [NameInMap("PlainHttpRegistry")]
        [Validation(Required=false)]
        public string PlainHttpRegistry { get; set; }

        /// <summary>
        /// <para>The private IP address of the elastic container instance. Only IPv4 addresses are supported. Make sure that the IP address is idle.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.0.1</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The name of the instance Resource Access Management (RAM) role. You can use the same RAM role to access elastic container instances and ECS instances. For more information, see <a href="https://help.aliyun.com/document_detail/61178.html">Use an instance RAM role by calling API operations</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RamTestRole</para>
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-uf66jeqopgqa9hdn****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The restart policy of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Always: Always restarts the instance if a container in the instance exits upon termination.</description></item>
        /// <item><description>Never: Never restarts the instance if a container in the instance exits upon termination.</description></item>
        /// <item><description>OnFailure: Restarts the instance only if a container in the instance exists upon failure with a status code of non-zero.</description></item>
        /// </list>
        /// <para>Default value: Always.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Always</para>
        /// </summary>
        [NameInMap("RestartPolicy")]
        [Validation(Required=false)]
        public string RestartPolicy { get; set; }

        /// <summary>
        /// <para>The resource scheduling policy when you specify multiple zones to create an elastic container instance. To specify multiple zones, you can use the VSwitchId to specify multiple vSwitches. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>VSwitchOrdered: The system schedules resources in the sequence of the vSwitches.</description></item>
        /// <item><description>VSwitchRandom: The system schedules resources at random.</description></item>
        /// </list>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/157290.html">Specify multiple zones to create an elastic container instance</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VSwitchOrdered</para>
        /// </summary>
        [NameInMap("ScheduleStrategy")]
        [Validation(Required=false)]
        public string ScheduleStrategy { get; set; }

        /// <summary>
        /// <para>The ID of the security group to which the instance belongs. Instances in the same security group can access each other.</para>
        /// <para>If you do not specify a security group, the system automatically uses the default security group in the region that you selected. Make sure that the inbound rules of the security group contain the container protocols and port numbers that you want to expose. If you do not have a default security group in the region, the system creates a default security group, and then adds the container protocols and port numbers that you specified to the inbound rules of the security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-uf66jeqopgqa9hdn****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to use a shared namespace. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ShareProcessNamespace")]
        [Validation(Required=false)]
        public bool? ShareProcessNamespace { get; set; }

        /// <summary>
        /// <para>The protection period of the preemptible elastic container instance. Unit: hours. Default value: 1. A value of 0 indicates no protection period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SpotDuration")]
        [Validation(Required=false)]
        public long? SpotDuration { get; set; }

        /// <summary>
        /// <para>The maximum hourly price of the preemptible elastic container instance. The value can be accurate to three decimal places.</para>
        /// <para>If you set SpotStrategy to SpotWithPriceLimit, you must specify the SpotPriceLimit parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.025</para>
        /// </summary>
        [NameInMap("SpotPriceLimit")]
        [Validation(Required=false)]
        public float? SpotPriceLimit { get; set; }

        /// <summary>
        /// <para>The bid policy for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoSpot: The instance is created as a pay-as-you-go instance.</description></item>
        /// <item><description>SpotWithPriceLimit: The instance is created as a preemptible instance for which you specify the maximum hourly price.</description></item>
        /// <item><description>SpotAsPriceGo: The instance is created as a preemptible instance for which the market price at the time of purchase is automatically used as the bid price.</description></item>
        /// </list>
        /// <para>Default value: NoSpot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SpotWithPriceLimit</para>
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable periodical execution.</para>
        /// <list type="bullet">
        /// <item><description>true: enables periodical execution.</description></item>
        /// <item><description>false: disables periodical execution.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("StrictSpot")]
        [Validation(Required=false)]
        public bool? StrictSpot { get; set; }

        /// <summary>
        /// <para>The tags that you want to add to the instance. You can bind a maximum of 20 tags. For more information, see <a href="https://help.aliyun.com/document_detail/146608.html">Use tags to manage elastic container instances</a>.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateContainerGroupRequestTag> Tag { get; set; }
        public class CreateContainerGroupRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. The tag key cannot be an empty string and must be unique. The tag key can be up to 64 characters in length and cannot contain <c>http://</c> or <c>https://</c>. The tag key cannot start with <c>acs:</c> or <c>aliyun</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>version</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The tag value can be an empty string. The tag value can be up to 128 characters in length. It cannot start with <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The buffer period of time during which the program handles operations before the program is stopped. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("TerminationGracePeriodSeconds")]
        [Validation(Required=false)]
        public long? TerminationGracePeriodSeconds { get; set; }

        /// <summary>
        /// <para>The IDs of the vSwitches that connect to the instance. You can specify up to 10 vSwitch IDs at a time. Separate multiple vSwitch IDs with commas (,). Example: <c>vsw-***,vsw-***</c>.</para>
        /// <para>If you do not specify a vSwitch, the system automatically uses the default vSwitch in the default VPC in the region that you selected. If you do not have a default VPC or a default vSwitch in the region, the system automatically creates a default VPC and a default vSwitch.</para>
        /// <remarks>
        /// <para> The number of IP addresses in the vSwitch CIDR block determines the maximum number of elastic container instances that you can create for the vSwitch. Before you create elastic container instances, you must plan the CIDR block of the vSwitch.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1xpiowfm5vo8o3c****,vsw-bp1rkyjgr1xwoho6k****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The information about the volume that you want to mount to the container.</para>
        /// </summary>
        [NameInMap("Volume")]
        [Validation(Required=false)]
        public List<CreateContainerGroupRequestVolume> Volume { get; set; }
        public class CreateContainerGroupRequestVolume : TeaModel {
            [NameInMap("ConfigFileVolume")]
            [Validation(Required=false)]
            public CreateContainerGroupRequestVolumeConfigFileVolume ConfigFileVolume { get; set; }
            public class CreateContainerGroupRequestVolumeConfigFileVolume : TeaModel {
                [NameInMap("ConfigFileToPath")]
                [Validation(Required=false)]
                public List<CreateContainerGroupRequestVolumeConfigFileVolumeConfigFileToPath> ConfigFileToPath { get; set; }
                public class CreateContainerGroupRequestVolumeConfigFileVolumeConfigFileToPath : TeaModel {
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("Mode")]
                    [Validation(Required=false)]
                    public int? Mode { get; set; }

                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                }

                [NameInMap("DefaultMode")]
                [Validation(Required=false)]
                public int? DefaultMode { get; set; }

            }

            [NameInMap("DiskVolume")]
            [Validation(Required=false)]
            public CreateContainerGroupRequestVolumeDiskVolume DiskVolume { get; set; }
            public class CreateContainerGroupRequestVolumeDiskVolume : TeaModel {
                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }

                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public int? DiskSize { get; set; }

                [NameInMap("FsType")]
                [Validation(Required=false)]
                public string FsType { get; set; }

            }

            [NameInMap("EmptyDirVolume")]
            [Validation(Required=false)]
            public CreateContainerGroupRequestVolumeEmptyDirVolume EmptyDirVolume { get; set; }
            public class CreateContainerGroupRequestVolumeEmptyDirVolume : TeaModel {
                [NameInMap("Medium")]
                [Validation(Required=false)]
                public string Medium { get; set; }

                [NameInMap("SizeLimit")]
                [Validation(Required=false)]
                public string SizeLimit { get; set; }

            }

            [NameInMap("FlexVolume")]
            [Validation(Required=false)]
            public CreateContainerGroupRequestVolumeFlexVolume FlexVolume { get; set; }
            public class CreateContainerGroupRequestVolumeFlexVolume : TeaModel {
                [NameInMap("Driver")]
                [Validation(Required=false)]
                public string Driver { get; set; }

                [NameInMap("FsType")]
                [Validation(Required=false)]
                public string FsType { get; set; }

                [NameInMap("Options")]
                [Validation(Required=false)]
                public string Options { get; set; }

            }

            [NameInMap("HostPathVolume")]
            [Validation(Required=false)]
            public CreateContainerGroupRequestVolumeHostPathVolume HostPathVolume { get; set; }
            public class CreateContainerGroupRequestVolumeHostPathVolume : TeaModel {
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("NFSVolume")]
            [Validation(Required=false)]
            public CreateContainerGroupRequestVolumeNFSVolume NFSVolume { get; set; }
            public class CreateContainerGroupRequestVolumeNFSVolume : TeaModel {
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                [NameInMap("ReadOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

                [NameInMap("Server")]
                [Validation(Required=false)]
                public string Server { get; set; }

            }

            /// <summary>
            /// <para>The name of the volume.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default-volume1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The type of the HostPath volume. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Directory</description></item>
            /// <item><description>File</description></item>
            /// </list>
            /// <remarks>
            /// <para> Only users in the whitelist can mount HostPath volumes.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ConfigFileVolume</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The zone ID of the instance. If you do not specify this parameter, the system selects a zone.</para>
        /// <para>This parameter is empty by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
