// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetK8sApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>The application information.</para>
        /// </summary>
        [NameInMap("Applcation")]
        [Validation(Required=false)]
        public GetK8sApplicationResponseBodyApplcation Applcation { get; set; }
        public class GetK8sApplicationResponseBodyApplcation : TeaModel {
            /// <summary>
            /// <para>The basic information about the application.</para>
            /// </summary>
            [NameInMap("App")]
            [Validation(Required=false)]
            public GetK8sApplicationResponseBodyApplcationApp App { get; set; }
            public class GetK8sApplicationResponseBodyApplcationApp : TeaModel {
                /// <summary>
                /// <para>The annotations of the application pod.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;test-annokey&quot;:&quot;test-annovalue&quot;}</para>
                /// </summary>
                [NameInMap("Annotations")]
                [Validation(Required=false)]
                public string Annotations { get; set; }

                /// <summary>
                /// <para>The ID of the application. You can call the <a href="https://help.aliyun.com/document_detail/149390.html">ListApplication</a> operation to obtain the application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00ee517d-dd7d-4d4e-<b><b>-</b></b></para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The name of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ApplicationName")]
                [Validation(Required=false)]
                public string ApplicationName { get; set; }

                /// <summary>
                /// <para>The application type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>War</para>
                /// </summary>
                [NameInMap("ApplicationType")]
                [Validation(Required=false)]
                public string ApplicationType { get; set; }

                /// <summary>
                /// <para>The ID of the application build type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>57</para>
                /// </summary>
                [NameInMap("BuildpackId")]
                [Validation(Required=false)]
                public int? BuildpackId { get; set; }

                /// <summary>
                /// <para>The cluster ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c37aec2a-bcca-4ec1-<b><b>-</b></b></para>
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>The startup command.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ls</para>
                /// </summary>
                [NameInMap("Cmd")]
                [Validation(Required=false)]
                public string Cmd { get; set; }

                [NameInMap("CmdArgs")]
                [Validation(Required=false)]
                public GetK8sApplicationResponseBodyApplcationAppCmdArgs CmdArgs { get; set; }
                public class GetK8sApplicationResponseBodyApplcationAppCmdArgs : TeaModel {
                    [NameInMap("CmdArg")]
                    [Validation(Required=false)]
                    public List<string> CmdArg { get; set; }

                }

                /// <summary>
                /// <para>The ID of the container cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c383bc813c1974e<b><b>451b50c0c8</b></b></para>
                /// </summary>
                [NameInMap("CsClusterId")]
                [Validation(Required=false)]
                public string CsClusterId { get; set; }

                /// <summary>
                /// <para>The deployment type. The value is Image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Image</para>
                /// </summary>
                [NameInMap("DeployType")]
                [Validation(Required=false)]
                public string DeployType { get; set; }

                /// <summary>
                /// <para>The application type:</para>
                /// <list type="bullet">
                /// <item><description><para>General: a native Java application.</para>
                /// </description></item>
                /// <item><description><para>Pandora: a Pandora application.</para>
                /// </description></item>
                /// <item><description><para>Multilingual: a multilingual application.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>General</para>
                /// </summary>
                [NameInMap("DevelopType")]
                [Validation(Required=false)]
                public string DevelopType { get; set; }

                /// <summary>
                /// <para>The version of the EDAS container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.60.0</para>
                /// </summary>
                [NameInMap("EdasContainerVersion")]
                [Validation(Required=false)]
                public string EdasContainerVersion { get; set; }

                /// <summary>
                /// <para>Indicates whether empty-push protection is enabled for the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableEmptyPushReject")]
                [Validation(Required=false)]
                public bool? EnableEmptyPushReject { get; set; }

                /// <summary>
                /// <para>Indicates whether graceful start is enabled for the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableLosslessRule")]
                [Validation(Required=false)]
                public bool? EnableLosslessRule { get; set; }

                [NameInMap("EnvList")]
                [Validation(Required=false)]
                public GetK8sApplicationResponseBodyApplcationAppEnvList EnvList { get; set; }
                public class GetK8sApplicationResponseBodyApplcationAppEnvList : TeaModel {
                    [NameInMap("Env")]
                    [Validation(Required=false)]
                    public List<GetK8sApplicationResponseBodyApplcationAppEnvListEnv> Env { get; set; }
                    public class GetK8sApplicationResponseBodyApplcationAppEnvListEnv : TeaModel {
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The tags of advanced configurations for the current application. This parameter indicates the features that are enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>base.combination.edas: the EDAS integrated management solution.</para>
                /// </description></item>
                /// <item><description><para>base.combination.arms: ARMS monitoring is enabled.</para>
                /// </description></item>
                /// <item><description><para>base.combination.mse: MSE is enabled.</para>
                /// </description></item>
                /// <item><description><para>base.combination.none: Only lifecycle management is enabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>base.combination.edas</para>
                /// </summary>
                [NameInMap("FeatureAnnotations")]
                [Validation(Required=false)]
                public string FeatureAnnotations { get; set; }

                /// <summary>
                /// <para>The number of application instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("Instances")]
                [Validation(Required=false)]
                public int? Instances { get; set; }

                /// <summary>
                /// <para>The number of application instances before the last scaling event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("InstancesBeforeScaling")]
                [Validation(Required=false)]
                public int? InstancesBeforeScaling { get; set; }

                /// <summary>
                /// <para>The Kubernetes namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("K8sNamespace")]
                [Validation(Required=false)]
                public string K8sNamespace { get; set; }

                /// <summary>
                /// <para>The labels of the application pod.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;test-labelkey&quot;:&quot;test-labelvalue&quot;}</para>
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public string Labels { get; set; }

                /// <summary>
                /// <para>The CPU limit. Unit: millicores. 1,000 millicores are equal to one CPU core.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("LimitCpuM")]
                [Validation(Required=false)]
                public int? LimitCpuM { get; set; }

                /// <summary>
                /// <para>The limit of ephemeral storage resources. Unit: GB. A value of 0 indicates that no limit is set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("LimitEphemeralStorage")]
                [Validation(Required=false)]
                public string LimitEphemeralStorage { get; set; }

                /// <summary>
                /// <para>The memory limit. Unit: MiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("LimitMem")]
                [Validation(Required=false)]
                public int? LimitMem { get; set; }

                /// <summary>
                /// <para>Indicates whether the application, in graceful rolling deployment mode, is configured to complete service registration before it passes the readiness probe.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("LosslessRuleAligned")]
                [Validation(Required=false)]
                public bool? LosslessRuleAligned { get; set; }

                /// <summary>
                /// <para>The duration of delayed service registration that is configured for the application. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("LosslessRuleDelayTime")]
                [Validation(Required=false)]
                public int? LosslessRuleDelayTime { get; set; }

                /// <summary>
                /// <para>The service prefetch curve that is set for the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("LosslessRuleFuncType")]
                [Validation(Required=false)]
                public int? LosslessRuleFuncType { get; set; }

                /// <summary>
                /// <para>Indicates whether the application, in graceful rolling deployment mode, is configured to complete service prefetch before it passes the readiness probe.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("LosslessRuleRelated")]
                [Validation(Required=false)]
                public bool? LosslessRuleRelated { get; set; }

                /// <summary>
                /// <para>The service prefetch duration that is set for the application. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("LosslessRuleWarmupTime")]
                [Validation(Required=false)]
                public int? LosslessRuleWarmupTime { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The number of CPU cores that are requested. Unit: millicores. 1,000 millicores are equal to one CPU core.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("RequestCpuM")]
                [Validation(Required=false)]
                public int? RequestCpuM { get; set; }

                /// <summary>
                /// <para>The amount of ephemeral storage resources to reserve. Unit: GB. A value of 0 indicates that no limit is set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RequestEphemeralStorage")]
                [Validation(Required=false)]
                public string RequestEphemeralStorage { get; set; }

                /// <summary>
                /// <para>The amount of memory that is reserved. Unit: MiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("RequestMem")]
                [Validation(Required=false)]
                public int? RequestMem { get; set; }

                /// <summary>
                /// <para>The SecurityContext properties of the application pod container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;runAsUser\&quot;:0,\&quot;runAsGroup\&quot;:0}</para>
                /// </summary>
                [NameInMap("SecurityContext")]
                [Validation(Required=false)]
                public string SecurityContext { get; set; }

                /// <summary>
                /// <para>The SLB configurations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[
                ///   {
                ///     &quot;addressType&quot;: &quot;intranet&quot;,
                ///     &quot;externalTrafficPolicy&quot;: &quot;Local&quot;,
                ///     &quot;ip&quot;: &quot;192.168.254.<em><b>&quot;,
                ///     &quot;name&quot;: &quot;intranet-testapp&quot;,
                ///     &quot;portMappings&quot;: [
                ///       {
                ///         &quot;loadBalancerProtocol&quot;: &quot;TCP&quot;,
                ///         &quot;servicePort&quot;: {
                ///           &quot;port&quot;: 8080,
                ///           &quot;protocol&quot;: &quot;TCP&quot;,
                ///           &quot;targetPort&quot;: 18081,
                ///           &quot;vServerGroupName&quot;: &quot;k8s/31414/intranet-testapp/default/cc90e0c9508a44667bdae2e83d3</b></em><em><b>&quot;
                ///         }
                ///       }
                ///     ],
                ///     &quot;scheduler&quot;: &quot;rr&quot;,
                ///     &quot;serviceType&quot;: &quot;LoadBalancer&quot;,
                ///     &quot;slbId&quot;: &quot;lb-bp1ikoh3nrpgqsm</b></em>***&quot;,
                ///     &quot;source&quot;: &quot;create&quot;,
                ///     &quot;specification&quot;: &quot;slb.s3.large&quot;
                ///   }
                /// ]</para>
                /// </summary>
                [NameInMap("SlbInfo")]
                [Validation(Required=false)]
                public string SlbInfo { get; set; }

                /// <summary>
                /// <para>The version of Apache Tomcat.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8.5.55</para>
                /// </summary>
                [NameInMap("TomcatVersion")]
                [Validation(Required=false)]
                public string TomcatVersion { get; set; }

                /// <summary>
                /// <para>The type of the workload that is used to create the application. Valid values: Deployment and StatefulSet. If you leave this parameter empty, Deployment is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Deployment</para>
                /// </summary>
                [NameInMap("WorkloadType")]
                [Validation(Required=false)]
                public string WorkloadType { get; set; }

            }

            /// <summary>
            /// <para>The ID of the application. You can call the <a href="https://help.aliyun.com/document_detail/149390.html">ListApplication</a> operation to obtain the application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a5281053-<b><b>-47a5-b2ab-5c0323de</b></b></para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The configuration information.</para>
            /// </summary>
            [NameInMap("Conf")]
            [Validation(Required=false)]
            public GetK8sApplicationResponseBodyApplcationConf Conf { get; set; }
            public class GetK8sApplicationResponseBodyApplcationConf : TeaModel {
                /// <summary>
                /// <para>The pod affinity configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;{\&quot;nodeAffinity\&quot;:{\&quot;requiredDuringSchedulingIgnoredDuringExecution\&quot;:{\&quot;nodeSelectorTerms\&quot;:[{\&quot;matchExpressions\&quot;:[{\&quot;key\&quot;:\&quot;beta.kubernetes.io/arch\&quot;,\&quot;operator\&quot;:\&quot;NotIn\&quot;,\&quot;values\&quot;:[\&quot;arm64\&quot;,\&quot;arm32\&quot;]}]}]},\&quot;preferredDuringSchedulingIgnoredDuringExecution\&quot;:[{\&quot;weight\&quot;:5,\&quot;preference\&quot;:{\&quot;matchExpressions\&quot;:[{\&quot;key\&quot;:\&quot;kubernetes.io/os\&quot;,\&quot;operator\&quot;:\&quot;In\&quot;,\&quot;values\&quot;:[\&quot;linux\&quot;]}]}}]},\&quot;podAffinity\&quot;:{\&quot;requiredDuringSchedulingIgnoredDuringExecution\&quot;:[{\&quot;labelSelector\&quot;:{\&quot;matchExpressions\&quot;:[{\&quot;key\&quot;:\&quot;edas.oam.acname\&quot;,\&quot;operator\&quot;:\&quot;NotIn\&quot;,\&quot;values\&quot;:[\&quot;edas-test-app\&quot;]}]},\&quot;namespaces\&quot;:[\&quot;default\&quot;],\&quot;topologyKey\&quot;:\&quot;kubernetes.io/hostname\&quot;}]},\&quot;podAntiAffinity\&quot;:{\&quot;preferredDuringSchedulingIgnoredDuringExecution\&quot;:[{\&quot;weight\&quot;:15,\&quot;podAffinityTerm\&quot;:{\&quot;labelSelector\&quot;:{\&quot;matchExpressions\&quot;:[{\&quot;key\&quot;:\&quot;edas.oam.acname\&quot;,\&quot;operator\&quot;:\&quot;In\&quot;,\&quot;values\&quot;:[\&quot;edas-test-app-2\&quot;]}]},\&quot;namespaces\&quot;:[\&quot;default\&quot;],\&quot;topologyKey\&quot;:\&quot;failure-domain.beta.kubernetes.io/zone\&quot;}}]}}&quot;</para>
                /// </summary>
                [NameInMap("Affinity")]
                [Validation(Required=false)]
                public string Affinity { get; set; }

                /// <summary>
                /// <para>Indicates whether the application is connected to AHAS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AhasEnabled")]
                [Validation(Required=false)]
                public bool? AhasEnabled { get; set; }

                /// <summary>
                /// <para>Indicates whether to distribute application instances across multiple nodes:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: The application instances are distributed across multiple nodes.</para>
                /// </description></item>
                /// <item><description><para>Other values: The application instances are not distributed across multiple nodes.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DeployAcrossNodes")]
                [Validation(Required=false)]
                public string DeployAcrossNodes { get; set; }

                /// <summary>
                /// <para>Indicates whether to distribute application instances across multiple zones:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: The application instances are distributed across multiple zones.</para>
                /// </description></item>
                /// <item><description><para>Other values: The application instances are not distributed across multiple zones.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DeployAcrossZones")]
                [Validation(Required=false)]
                public string DeployAcrossZones { get; set; }

                /// <summary>
                /// <para>The startup parameters of the JAR package. This parameter is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-lh</para>
                /// </summary>
                [NameInMap("JarStartArgs")]
                [Validation(Required=false)]
                public string JarStartArgs { get; set; }

                /// <summary>
                /// <para>The startup options of the JAR package. This parameter is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-h</para>
                /// </summary>
                [NameInMap("JarStartOptions")]
                [Validation(Required=false)]
                public string JarStartOptions { get; set; }

                /// <summary>
                /// <para>The startup command.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ls</para>
                /// </summary>
                [NameInMap("K8sCmd")]
                [Validation(Required=false)]
                public string K8sCmd { get; set; }

                /// <summary>
                /// <para>The parameters of the startup command.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-lh</para>
                /// </summary>
                [NameInMap("K8sCmdArgs")]
                [Validation(Required=false)]
                public string K8sCmdArgs { get; set; }

                /// <summary>
                /// <para>The local storage information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;type&quot;:&quot;&quot;,&quot;nodePath&quot;:&quot;/mnt/&quot;,&quot;mountPath&quot;:&quot;/mnt/&quot;}]</para>
                /// </summary>
                [NameInMap("K8sLocalvolumeInfo")]
                [Validation(Required=false)]
                public string K8sLocalvolumeInfo { get; set; }

                /// <summary>
                /// <para>The NAS storage information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;nasPath&quot;:&quot;/mnt/&quot;,&quot;mountPath&quot;:&quot;/mnt/&quot;}]</para>
                /// </summary>
                [NameInMap("K8sNasInfo")]
                [Validation(Required=false)]
                public string K8sNasInfo { get; set; }

                /// <summary>
                /// <para>The storage information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;{\&quot;hostPaths\&quot;:\&quot;[]\&quot;,\&quot;emptyDirs\&quot;:\&quot;[]\&quot;}&quot;</para>
                /// </summary>
                [NameInMap("K8sVolumeInfo")]
                [Validation(Required=false)]
                public string K8sVolumeInfo { get; set; }

                /// <summary>
                /// <para>The information about the liveness probe of the Kubernetes container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;failureThreshold&quot;: 3,&quot;initialDelaySeconds&quot;: 5,&quot;successThreshold&quot;: 1,&quot;timeoutSeconds&quot;: 1,&quot;tcpSocket&quot;:{&quot;host&quot;:&quot;&quot;, &quot;port&quot;:8080}}</para>
                /// </summary>
                [NameInMap("Liveness")]
                [Validation(Required=false)]
                public string Liveness { get; set; }

                /// <summary>
                /// <para>The information about the post-start execution of the Kubernetes container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;exec\&quot;:{\&quot;command\&quot;:[\&quot;ls\&quot;,\&quot;/\&quot;]}}&quot;</para>
                /// </summary>
                [NameInMap("PostStart")]
                [Validation(Required=false)]
                public string PostStart { get; set; }

                /// <summary>
                /// <para>The information about the pre-stop execution of the Kubernetes container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;exec\&quot;:{\&quot;command\&quot;:[\&quot;ls\&quot;,\&quot;/\&quot;]}}&quot;</para>
                /// </summary>
                [NameInMap("PreStop")]
                [Validation(Required=false)]
                public string PreStop { get; set; }

                /// <summary>
                /// <para>The information about the readiness probe of the Kubernetes container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;failureThreshold&quot;: 3,&quot;initialDelaySeconds&quot;: 5,&quot;successThreshold&quot;: 1,&quot;timeoutSeconds&quot;: 1,&quot;httpGet&quot;: {&quot;path&quot;: &quot;/consumer&quot;,&quot;port&quot;: 8080,&quot;scheme&quot;: &quot;HTTP&quot;,&quot;httpHeaders&quot;: [{&quot;name&quot;: &quot;test&quot;,&quot;value&quot;: &quot;testvalue&quot;}\]}}</para>
                /// </summary>
                [NameInMap("Readiness")]
                [Validation(Required=false)]
                public string Readiness { get; set; }

                /// <summary>
                /// <para>The pod runtime class. This parameter is applicable only to clusters that use sandboxed containers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>runc</para>
                /// </summary>
                [NameInMap("RuntimeClassName")]
                [Validation(Required=false)]
                public string RuntimeClassName { get; set; }

                /// <summary>
                /// <para>The pod scheduling toleration configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;[{\&quot;key\&quot;:\&quot;edas-taint-key2\&quot;,\&quot;operator\&quot;:\&quot;Exists\&quot;,\&quot;effect\&quot;:\&quot;NoExecute\&quot;,\&quot;tolerationSeconds\&quot;:50},{\&quot;key\&quot;:\&quot;edas-taint-key\&quot;,\&quot;operator\&quot;:\&quot;Equal\&quot;,\&quot;value\&quot;:\&quot;edas-taint-value\&quot;,\&quot;effect\&quot;:\&quot;PreferNoSchedule\&quot;}]&quot;</para>
                /// </summary>
                [NameInMap("Tolerations")]
                [Validation(Required=false)]
                public string Tolerations { get; set; }

                /// <summary>
                /// <para>The URL of the base image. This parameter is configured when a custom OpenJDK runtime is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>openjdk:8u302</para>
                /// </summary>
                [NameInMap("UserBaseImageUrl")]
                [Validation(Required=false)]
                public string UserBaseImageUrl { get; set; }

            }

            [NameInMap("DeployGroups")]
            [Validation(Required=false)]
            public GetK8sApplicationResponseBodyApplcationDeployGroups DeployGroups { get; set; }
            public class GetK8sApplicationResponseBodyApplcationDeployGroups : TeaModel {
                [NameInMap("DeployGroup")]
                [Validation(Required=false)]
                public List<GetK8sApplicationResponseBodyApplcationDeployGroupsDeployGroup> DeployGroup { get; set; }
                public class GetK8sApplicationResponseBodyApplcationDeployGroupsDeployGroup : TeaModel {
                    [NameInMap("Components")]
                    [Validation(Required=false)]
                    public GetK8sApplicationResponseBodyApplcationDeployGroupsDeployGroupComponents Components { get; set; }
                    public class GetK8sApplicationResponseBodyApplcationDeployGroupsDeployGroupComponents : TeaModel {
                        [NameInMap("Components")]
                        [Validation(Required=false)]
                        public List<GetK8sApplicationResponseBodyApplcationDeployGroupsDeployGroupComponentsComponents> Components { get; set; }
                        public class GetK8sApplicationResponseBodyApplcationDeployGroupsDeployGroupComponentsComponents : TeaModel {
                            [NameInMap("ComponentId")]
                            [Validation(Required=false)]
                            public string ComponentId { get; set; }

                            [NameInMap("ComponentKey")]
                            [Validation(Required=false)]
                            public string ComponentKey { get; set; }

                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                    }

                    [NameInMap("Env")]
                    [Validation(Required=false)]
                    public string Env { get; set; }

                    [NameInMap("EnvFrom")]
                    [Validation(Required=false)]
                    public string EnvFrom { get; set; }

                }

            }

            /// <summary>
            /// <para>The image information.</para>
            /// </summary>
            [NameInMap("ImageInfo")]
            [Validation(Required=false)]
            public GetK8sApplicationResponseBodyApplcationImageInfo ImageInfo { get; set; }
            public class GetK8sApplicationResponseBodyApplcationImageInfo : TeaModel {
                /// <summary>
                /// <para>The URL of the image.</para>
                /// </summary>
                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                /// <summary>
                /// <para>The ID of the region where the image is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The ID of the image repository.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RepoId")]
                [Validation(Required=false)]
                public string RepoId { get; set; }

                /// <summary>
                /// <para>The name of the image repository.</para>
                /// 
                /// <b>Example:</b>
                /// <para>131****067006888_shared_repo</para>
                /// </summary>
                [NameInMap("RepoName")]
                [Validation(Required=false)]
                public string RepoName { get; set; }

                /// <summary>
                /// <para>The namespace of the image repository.</para>
                /// 
                /// <b>Example:</b>
                /// <para>edas-server****-user</para>
                /// </summary>
                [NameInMap("RepoNamespace")]
                [Validation(Required=false)]
                public string RepoNamespace { get; set; }

                /// <summary>
                /// <para>The type of the source of the image repository.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALI_HUB</para>
                /// </summary>
                [NameInMap("RepoOriginType")]
                [Validation(Required=false)]
                public string RepoOriginType { get; set; }

                /// <summary>
                /// <para>The tag of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5a166fbd-9d76-4f98-****-781659d9f54c_1572485443282</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

            }

            /// <summary>
            /// <para>The information about the latest version.</para>
            /// </summary>
            [NameInMap("LatestVersion")]
            [Validation(Required=false)]
            public GetK8sApplicationResponseBodyApplcationLatestVersion LatestVersion { get; set; }
            public class GetK8sApplicationResponseBodyApplcationLatestVersion : TeaModel {
                /// <summary>
                /// <para>The version number of the deployment package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20200720</para>
                /// </summary>
                [NameInMap("PackageVersion")]
                [Validation(Required=false)]
                public string PackageVersion { get; set; }

                /// <summary>
                /// <para>The URL of the deployment package. This parameter is required for applications that are deployed using a FatJar or WAR package.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://e***.oss-cn-beijing.aliyuncs.com/s***-1.0-SNAPSHOT-spring-boot.jar">https://e***.oss-cn-beijing.aliyuncs.com/s***-1.0-SNAPSHOT-spring-boot.jar</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// <para>The URL of the deployment package. This parameter is required for applications that are deployed using a FatJar or WAR package.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://e***.oss-cn-beijing.aliyuncs.com/s***-1.0-SNAPSHOT-spring-boot.jar">https://e***.oss-cn-beijing.aliyuncs.com/s***-1.0-SNAPSHOT-spring-boot.jar</a></para>
                /// </summary>
                [NameInMap("WarUrl")]
                [Validation(Required=false)]
                public string WarUrl { get; set; }

            }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The additional information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1053-08e4-47a5-b2ab-5c0323de7b5a</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
