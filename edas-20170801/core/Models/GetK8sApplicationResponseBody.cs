// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetK8sApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the application.</para>
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
                /// <para>The annotation of an application pod.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;test-annokey&quot;:&quot;test-annovalue&quot;}</para>
                /// </summary>
                [NameInMap("Annotations")]
                [Validation(Required=false)]
                public string Annotations { get; set; }

                /// <summary>
                /// <para>The ID of the application. You can call the ListApplication operation to query the application ID. For more information, see <a href="https://help.aliyun.com/document_detail/149390.html">ListApplication</a>.</para>
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
                /// <para>The type of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>War</para>
                /// </summary>
                [NameInMap("ApplicationType")]
                [Validation(Required=false)]
                public string ApplicationType { get; set; }

                /// <summary>
                /// <para>The build package number of Enterprise Distributed Application Service (EDAS) Container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>57</para>
                /// </summary>
                [NameInMap("BuildpackId")]
                [Validation(Required=false)]
                public int? BuildpackId { get; set; }

                /// <summary>
                /// <para>The ID of the cluster.</para>
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

                /// <summary>
                /// <para>The list of commands.</para>
                /// </summary>
                [NameInMap("CmdArgs")]
                [Validation(Required=false)]
                public GetK8sApplicationResponseBodyApplcationAppCmdArgs CmdArgs { get; set; }
                public class GetK8sApplicationResponseBodyApplcationAppCmdArgs : TeaModel {
                    [NameInMap("CmdArg")]
                    [Validation(Required=false)]
                    public List<string> CmdArg { get; set; }

                }

                /// <summary>
                /// <para>The ID of the cluster to which the container belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c383bc813c1974e<b><b>451b50c0c8</b></b></para>
                /// </summary>
                [NameInMap("CsClusterId")]
                [Validation(Required=false)]
                public string CsClusterId { get; set; }

                /// <summary>
                /// <para>The deployment type of the application. Example: Image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Image</para>
                /// </summary>
                [NameInMap("DeployType")]
                [Validation(Required=false)]
                public string DeployType { get; set; }

                /// <summary>
                /// <para>The application type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>General: native Java application</description></item>
                /// <item><description>Pandora: Pandora application</description></item>
                /// <item><description>Multilingual: multilingual application</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>General</para>
                /// </summary>
                [NameInMap("DevelopType")]
                [Validation(Required=false)]
                public string DevelopType { get; set; }

                /// <summary>
                /// <para>The version of EDAS Container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.60.0</para>
                /// </summary>
                [NameInMap("EdasContainerVersion")]
                [Validation(Required=false)]
                public string EdasContainerVersion { get; set; }

                /// <summary>
                /// <para>Indicates whether the Empty List Protection feature is enabled for the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableEmptyPushReject")]
                [Validation(Required=false)]
                public bool? EnableEmptyPushReject { get; set; }

                /// <summary>
                /// <para>Indicates whether the Graceful Release feature is enabled for the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableLosslessRule")]
                [Validation(Required=false)]
                public bool? EnableLosslessRule { get; set; }

                /// <summary>
                /// <para>The list of environment variables.</para>
                /// </summary>
                [NameInMap("EnvList")]
                [Validation(Required=false)]
                public GetK8sApplicationResponseBodyApplcationAppEnvList EnvList { get; set; }
                public class GetK8sApplicationResponseBodyApplcationAppEnvList : TeaModel {
                    [NameInMap("Env")]
                    [Validation(Required=false)]
                    public List<GetK8sApplicationResponseBodyApplcationAppEnvListEnv> Env { get; set; }
                    public class GetK8sApplicationResponseBodyApplcationAppEnvListEnv : TeaModel {
                        /// <summary>
                        /// <para>The name of the environment variable.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CATALINA_OPTS</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The value of the environment variable.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-Xmx 1024m -Dhsf.default.tid=false $(EDAS_CATALINA_OPTS)</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The feature annotations. Possible values:</para>
                /// <list type="bullet">
                /// <item><description>base.combination.edas: enables EDAS integrated management solution.</description></item>
                /// <item><description>base.combination.arms: enables ARMS monitoring.</description></item>
                /// <item><description>base.combination.mse: enables MSE microservices governance.</description></item>
                /// <item><description>base.combination.none: enables lifecycle management.</description></item>
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
                /// <para>The number of application instances before the last auto scaling operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("InstancesBeforeScaling")]
                [Validation(Required=false)]
                public int? InstancesBeforeScaling { get; set; }

                /// <summary>
                /// <para>The namespace of the Kubernetes cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("K8sNamespace")]
                [Validation(Required=false)]
                public string K8sNamespace { get; set; }

                /// <summary>
                /// <para>The label of an application pod.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;test-labelkey&quot;:&quot;test-labelvalue&quot;}</para>
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public string Labels { get; set; }

                /// <summary>
                /// <para>The maximum number of CPU cores allowed. Unit: millicores. 1,000 millicores equal one CPU core.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("LimitCpuM")]
                [Validation(Required=false)]
                public int? LimitCpuM { get; set; }

                /// <summary>
                /// <para>The maximum size of space required by ephemeral storage. Unit: GB. Value 0 indicates that no limit is set on the space size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("LimitEphemeralStorage")]
                [Validation(Required=false)]
                public string LimitEphemeralStorage { get; set; }

                /// <summary>
                /// <para>The maximum size of the memory allowed. Unit: MiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("LimitMem")]
                [Validation(Required=false)]
                public int? LimitMem { get; set; }

                /// <summary>
                /// <para>Indicates whether the Graceful Rolling Release and Configure Complete Service Registration before Readiness Probing feature is enabled for the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("LosslessRuleAligned")]
                [Validation(Required=false)]
                public bool? LosslessRuleAligned { get; set; }

                /// <summary>
                /// <para>The delay of service registration. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("LosslessRuleDelayTime")]
                [Validation(Required=false)]
                public int? LosslessRuleDelayTime { get; set; }

                /// <summary>
                /// <para>The number of prefetching curves.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("LosslessRuleFuncType")]
                [Validation(Required=false)]
                public int? LosslessRuleFuncType { get; set; }

                /// <summary>
                /// <para>Indicates whether the Graceful Rolling Release and Configure Complete Service Prefetching before Readiness Probing feature is enabled for the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("LosslessRuleRelated")]
                [Validation(Required=false)]
                public bool? LosslessRuleRelated { get; set; }

                /// <summary>
                /// <para>The service prefetching duration. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("LosslessRuleWarmupTime")]
                [Validation(Required=false)]
                public int? LosslessRuleWarmupTime { get; set; }

                /// <summary>
                /// <para>The ID of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The number of requested CPU cores. Unit: millicores. 1,000 millicores equal one CPU core.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("RequestCpuM")]
                [Validation(Required=false)]
                public int? RequestCpuM { get; set; }

                /// <summary>
                /// <para>The size of space reserved for ephemeral storage resources. Unit: GB. Value 0 indicates that no limit is set on the space size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RequestEphemeralStorage")]
                [Validation(Required=false)]
                public string RequestEphemeralStorage { get; set; }

                /// <summary>
                /// <para>The size of the reserved memory. Unit: MiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("RequestMem")]
                [Validation(Required=false)]
                public int? RequestMem { get; set; }

                [NameInMap("SecurityContext")]
                [Validation(Required=false)]
                public string SecurityContext { get; set; }

                /// <summary>
                /// <para>The configuration information about the Server Load Balancer (SLB).</para>
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
                /// <para>The workload type. Valid values: Deployment and StatefulSet. If you do not specify this parameter, Deployment is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Deployment</para>
                /// </summary>
                [NameInMap("WorkloadType")]
                [Validation(Required=false)]
                public string WorkloadType { get; set; }

            }

            /// <summary>
            /// <para>The ID of the application. You can call the ListApplication operation to query the application ID. For more information, see <a href="https://help.aliyun.com/document_detail/149390.html">ListApplication</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a5281053-<b><b>-47a5-b2ab-5c0323de</b></b></para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The configurations.</para>
            /// </summary>
            [NameInMap("Conf")]
            [Validation(Required=false)]
            public GetK8sApplicationResponseBodyApplcationConf Conf { get; set; }
            public class GetK8sApplicationResponseBodyApplcationConf : TeaModel {
                /// <summary>
                /// <para>The affinity configuration of the pod.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;{\&quot;nodeAffinity\&quot;:{\&quot;requiredDuringSchedulingIgnoredDuringExecution\&quot;:{\&quot;nodeSelectorTerms\&quot;:[{\&quot;matchExpressions\&quot;:[{\&quot;key\&quot;:\&quot;beta.kubernetes.io/arch\&quot;,\&quot;operator\&quot;:\&quot;NotIn\&quot;,\&quot;values\&quot;:[\&quot;arm64\&quot;,\&quot;arm32\&quot;]}]}]},\&quot;preferredDuringSchedulingIgnoredDuringExecution\&quot;:[{\&quot;weight\&quot;:5,\&quot;preference\&quot;:{\&quot;matchExpressions\&quot;:[{\&quot;key\&quot;:\&quot;kubernetes.io/os\&quot;,\&quot;operator\&quot;:\&quot;In\&quot;,\&quot;values\&quot;:[\&quot;linux\&quot;]}]}}]},\&quot;podAffinity\&quot;:{\&quot;requiredDuringSchedulingIgnoredDuringExecution\&quot;:[{\&quot;labelSelector\&quot;:{\&quot;matchExpressions\&quot;:[{\&quot;key\&quot;:\&quot;edas.oam.acname\&quot;,\&quot;operator\&quot;:\&quot;NotIn\&quot;,\&quot;values\&quot;:[\&quot;edas-test-app\&quot;]}]},\&quot;namespaces\&quot;:[\&quot;default\&quot;],\&quot;topologyKey\&quot;:\&quot;kubernetes.io/hostname\&quot;}]},\&quot;podAntiAffinity\&quot;:{\&quot;preferredDuringSchedulingIgnoredDuringExecution\&quot;:[{\&quot;weight\&quot;:15,\&quot;podAffinityTerm\&quot;:{\&quot;labelSelector\&quot;:{\&quot;matchExpressions\&quot;:[{\&quot;key\&quot;:\&quot;edas.oam.acname\&quot;,\&quot;operator\&quot;:\&quot;In\&quot;,\&quot;values\&quot;:[\&quot;edas-test-app-2\&quot;]}]},\&quot;namespaces\&quot;:[\&quot;default\&quot;],\&quot;topologyKey\&quot;:\&quot;failure-domain.beta.kubernetes.io/zone\&quot;}}]}}&quot;</para>
                /// </summary>
                [NameInMap("Affinity")]
                [Validation(Required=false)]
                public string Affinity { get; set; }

                /// <summary>
                /// <para>Indicates whether the application is connected to Application High Availability Service (AHAS).</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AhasEnabled")]
                [Validation(Required=false)]
                public bool? AhasEnabled { get; set; }

                /// <summary>
                /// <para>Indicates whether the application instances are deployed across nodes.</para>
                /// <list type="bullet">
                /// <item><description>Value <c>true</c> indicates that the application instances are deployed across nodes.</description></item>
                /// <item><description>Other values indicate that the application instances are not deployed across nodes.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DeployAcrossNodes")]
                [Validation(Required=false)]
                public string DeployAcrossNodes { get; set; }

                /// <summary>
                /// <para>Indicates whether the application instances are deployed across zones.</para>
                /// <list type="bullet">
                /// <item><description>Value <c>true</c> indicates that the application instances are deployed across zones.</description></item>
                /// <item><description>Other values indicate that the application instances are not deployed across zones.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DeployAcrossZones")]
                [Validation(Required=false)]
                public string DeployAcrossZones { get; set; }

                /// <summary>
                /// <para>The startup parameters for a JAR application. This parameter is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-lh</para>
                /// </summary>
                [NameInMap("JarStartArgs")]
                [Validation(Required=false)]
                public string JarStartArgs { get; set; }

                /// <summary>
                /// <para>The startup options for a JAR application. This parameter is deprecated.</para>
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
                /// <para>The information about the local storage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;type&quot;:&quot;&quot;,&quot;nodePath&quot;:&quot;/mnt/&quot;,&quot;mountPath&quot;:&quot;/mnt/&quot;}]</para>
                /// </summary>
                [NameInMap("K8sLocalvolumeInfo")]
                [Validation(Required=false)]
                public string K8sLocalvolumeInfo { get; set; }

                /// <summary>
                /// <para>The information about the File Storage NAS (NAS) storage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;nasPath&quot;:&quot;/mnt/&quot;,&quot;mountPath&quot;:&quot;/mnt/&quot;}]</para>
                /// </summary>
                [NameInMap("K8sNasInfo")]
                [Validation(Required=false)]
                public string K8sNasInfo { get; set; }

                /// <summary>
                /// <para>The information about the storage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;{\&quot;hostPaths\&quot;:\&quot;[]\&quot;,\&quot;emptyDirs\&quot;:\&quot;[]\&quot;}&quot;</para>
                /// </summary>
                [NameInMap("K8sVolumeInfo")]
                [Validation(Required=false)]
                public string K8sVolumeInfo { get; set; }

                /// <summary>
                /// <para>The information about the liveness check on the container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;failureThreshold&quot;: 3,&quot;initialDelaySeconds&quot;: 5,&quot;successThreshold&quot;: 1,&quot;timeoutSeconds&quot;: 1,&quot;tcpSocket&quot;:{&quot;host&quot;:&quot;&quot;, &quot;port&quot;:8080}}</para>
                /// </summary>
                [NameInMap("Liveness")]
                [Validation(Required=false)]
                public string Liveness { get; set; }

                /// <summary>
                /// <para>The script executed after the container is started.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;exec\&quot;:{\&quot;command\&quot;:[\&quot;ls\&quot;,\&quot;/\&quot;]}}&quot;</para>
                /// </summary>
                [NameInMap("PostStart")]
                [Validation(Required=false)]
                public string PostStart { get; set; }

                /// <summary>
                /// <para>The script executed before the container is stopped.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;exec\&quot;:{\&quot;command\&quot;:[\&quot;ls\&quot;,\&quot;/\&quot;]}}&quot;</para>
                /// </summary>
                [NameInMap("PreStop")]
                [Validation(Required=false)]
                public string PreStop { get; set; }

                /// <summary>
                /// <para>The information about the readiness check on the container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;failureThreshold&quot;: 3,&quot;initialDelaySeconds&quot;: 5,&quot;successThreshold&quot;: 1,&quot;timeoutSeconds&quot;: 1,&quot;httpGet&quot;: {&quot;path&quot;: &quot;/consumer&quot;,&quot;port&quot;: 8080,&quot;scheme&quot;: &quot;HTTP&quot;,&quot;httpHeaders&quot;: [{&quot;name&quot;: &quot;test&quot;,&quot;value&quot;: &quot;testvalue&quot;}\]}}</para>
                /// </summary>
                [NameInMap("Readiness")]
                [Validation(Required=false)]
                public string Readiness { get; set; }

                /// <summary>
                /// <para>The type of the container runtime. This parameter is applicable only to clusters that use sandboxed containers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>runc</para>
                /// </summary>
                [NameInMap("RuntimeClassName")]
                [Validation(Required=false)]
                public string RuntimeClassName { get; set; }

                /// <summary>
                /// <para>The scheduling tolerance configuration of the pod.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;[{\&quot;key\&quot;:\&quot;edas-taint-key2\&quot;,\&quot;operator\&quot;:\&quot;Exists\&quot;,\&quot;effect\&quot;:\&quot;NoExecute\&quot;,\&quot;tolerationSeconds\&quot;:50},{\&quot;key\&quot;:\&quot;edas-taint-key\&quot;,\&quot;operator\&quot;:\&quot;Equal\&quot;,\&quot;value\&quot;:\&quot;edas-taint-value\&quot;,\&quot;effect\&quot;:\&quot;PreferNoSchedule\&quot;}]&quot;</para>
                /// </summary>
                [NameInMap("Tolerations")]
                [Validation(Required=false)]
                public string Tolerations { get; set; }

                /// <summary>
                /// <para>The URL of the base image. If you use a custom Java Development Kit (JDK) runtime, you must specify this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>openjdk:8u302</para>
                /// </summary>
                [NameInMap("UserBaseImageUrl")]
                [Validation(Required=false)]
                public string UserBaseImageUrl { get; set; }

            }

            /// <summary>
            /// <para>The information about the instance group in which the application is deployed.</para>
            /// </summary>
            [NameInMap("DeployGroups")]
            [Validation(Required=false)]
            public GetK8sApplicationResponseBodyApplcationDeployGroups DeployGroups { get; set; }
            public class GetK8sApplicationResponseBodyApplcationDeployGroups : TeaModel {
                [NameInMap("DeployGroup")]
                [Validation(Required=false)]
                public List<GetK8sApplicationResponseBodyApplcationDeployGroupsDeployGroup> DeployGroup { get; set; }
                public class GetK8sApplicationResponseBodyApplcationDeployGroupsDeployGroup : TeaModel {
                    /// <summary>
                    /// <para>The information about the component.</para>
                    /// </summary>
                    [NameInMap("Components")]
                    [Validation(Required=false)]
                    public GetK8sApplicationResponseBodyApplcationDeployGroupsDeployGroupComponents Components { get; set; }
                    public class GetK8sApplicationResponseBodyApplcationDeployGroupsDeployGroupComponents : TeaModel {
                        [NameInMap("Components")]
                        [Validation(Required=false)]
                        public List<GetK8sApplicationResponseBodyApplcationDeployGroupsDeployGroupComponentsComponents> Components { get; set; }
                        public class GetK8sApplicationResponseBodyApplcationDeployGroupsDeployGroupComponentsComponents : TeaModel {
                            /// <summary>
                            /// <para>The component ID.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>5</para>
                            /// </summary>
                            [NameInMap("ComponentId")]
                            [Validation(Required=false)]
                            public string ComponentId { get; set; }

                            /// <summary>
                            /// <para>The keyword that is included in the component name.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Open JDK 8</para>
                            /// </summary>
                            [NameInMap("ComponentKey")]
                            [Validation(Required=false)]
                            public string ComponentKey { get; set; }

                            /// <summary>
                            /// <para>The component type. Valid values:</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>JDK</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The environment variable. This parameter is different from the EnvList parameter. This parameter specifies the referenced configuration of the ConfigMap or Secret.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;[&quot;{\&quot;name\&quot;:\&quot;test1\&quot;,\&quot;valueFrom\&quot;:{\&quot;configMapKeyRef\&quot;:{\&quot;name\&quot;:\&quot;edas-demo-configmap\&quot;,\&quot;key\&quot;:\&quot;key1\&quot;}}}&quot;,&quot;{\&quot;name\&quot;:\&quot;k2\&quot;,\&quot;value\&quot;:\&quot;v2\&quot;}&quot;,&quot;{\&quot;name\&quot;:\&quot;s1\&quot;,\&quot;valueFrom\&quot;:{\&quot;secretKeyRef\&quot;:{\&quot;name\&quot;:\&quot;edas-demo-secret\&quot;,\&quot;key\&quot;:\&quot;k1\&quot;}}}&quot;]&quot;</para>
                    /// </summary>
                    [NameInMap("Env")]
                    [Validation(Required=false)]
                    public string Env { get; set; }

                    /// <summary>
                    /// <para>The source of the environment variable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[{&quot;configMapRef&quot;:{&quot;name&quot;:&quot;test-cm&quot;}}]</para>
                    /// </summary>
                    [NameInMap("EnvFrom")]
                    [Validation(Required=false)]
                    public string EnvFrom { get; set; }

                }

            }

            /// <summary>
            /// <para>The information about the image.</para>
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
                /// <para>The region ID of the image repository.</para>
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
                /// <para>The namespace to which the image repository belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>edas-server****-user</para>
                /// </summary>
                [NameInMap("RepoNamespace")]
                [Validation(Required=false)]
                public string RepoNamespace { get; set; }

                /// <summary>
                /// <para>The source type of the image repository.</para>
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
                /// <para>The version of the deployment package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20200720</para>
                /// </summary>
                [NameInMap("PackageVersion")]
                [Validation(Required=false)]
                public string PackageVersion { get; set; }

                /// <summary>
                /// <para>The URL of the deployment package. This parameter is required if you use a FatJar or WAR package to deploy the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://e***.oss-cn-beijing.aliyuncs.com/s***-1.0-SNAPSHOT-spring-boot.jar">https://e***.oss-cn-beijing.aliyuncs.com/s***-1.0-SNAPSHOT-spring-boot.jar</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// <para>The URL of the deployment package. This parameter is required if you use a FatJar or WAR package to deploy the application.</para>
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
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The additional information that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1053-08e4-47a5-b2ab-5c0323de7b5a</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
