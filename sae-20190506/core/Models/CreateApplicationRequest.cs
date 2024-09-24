// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateApplicationRequest : TeaModel {
        /// <summary>
        /// acs:ram::123456789012\\*\\*\\*\\*:role/adminrole
        /// </summary>
        [NameInMap("AcrAssumeRoleArn")]
        [Validation(Required=false)]
        public string AcrAssumeRoleArn { get; set; }

        /// <summary>
        /// cri-xxxxxx
        /// </summary>
        [NameInMap("AcrInstanceId")]
        [Validation(Required=false)]
        public string AcrInstanceId { get; set; }

        /// <summary>
        /// This is a test description.
        /// </summary>
        [NameInMap("AppDescription")]
        [Validation(Required=false)]
        public string AppDescription { get; set; }

        /// <summary>
        /// test
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("AppSource")]
        [Validation(Required=false)]
        public string AppSource { get; set; }

        /// <summary>
        /// true
        /// </summary>
        [NameInMap("AssociateEip")]
        [Validation(Required=false)]
        public bool? AssociateEip { get; set; }

        /// <summary>
        /// true
        /// </summary>
        [NameInMap("AutoConfig")]
        [Validation(Required=false)]
        public bool? AutoConfig { get; set; }

        [NameInMap("BaseAppId")]
        [Validation(Required=false)]
        public string BaseAppId { get; set; }

        /// <summary>
        /// sleep
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        /// <summary>
        /// 1d
        /// </summary>
        [NameInMap("CommandArgs")]
        [Validation(Required=false)]
        public string CommandArgs { get; set; }

        /// <summary>
        /// [{"configMapId":16,"key":"test","mountPath":"/tmp"}]
        /// </summary>
        [NameInMap("ConfigMapMountDesc")]
        [Validation(Required=false)]
        public string ConfigMapMountDesc { get; set; }

        /// <summary>
        /// 1000
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        /// <summary>
        /// [{"hostName":"samplehost","ip":"127.0.0.1"}]
        /// </summary>
        [NameInMap("CustomHostAlias")]
        [Validation(Required=false)]
        public string CustomHostAlias { get; set; }

        /// <summary>
        /// true
        /// </summary>
        [NameInMap("Deploy")]
        [Validation(Required=false)]
        public bool? Deploy { get; set; }

        [NameInMap("Dotnet")]
        [Validation(Required=false)]
        public string Dotnet { get; set; }

        /// <summary>
        /// 3.5.3
        /// </summary>
        [NameInMap("EdasContainerVersion")]
        [Validation(Required=false)]
        public string EdasContainerVersion { get; set; }

        [NameInMap("EnableEbpf")]
        [Validation(Required=false)]
        public string EnableEbpf { get; set; }

        [NameInMap("EnableNewArms")]
        [Validation(Required=false)]
        public bool? EnableNewArms { get; set; }

        /// <summary>
        /// [{"name":"envtmp","value":"0"}]
        /// </summary>
        [NameInMap("Envs")]
        [Validation(Required=false)]
        public string Envs { get; set; }

        [NameInMap("ImagePullSecrets")]
        [Validation(Required=false)]
        public string ImagePullSecrets { get; set; }

        /// <summary>
        /// registry.cn-hangzhou.aliyuncs.com/sae_test/ali_sae_test:0.0.1
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// custom-args
        /// </summary>
        [NameInMap("JarStartArgs")]
        [Validation(Required=false)]
        public string JarStartArgs { get; set; }

        /// <summary>
        /// \\-Xms4G -Xmx4G
        /// </summary>
        [NameInMap("JarStartOptions")]
        [Validation(Required=false)]
        public string JarStartOptions { get; set; }

        /// <summary>
        /// Open JDK 8
        /// </summary>
        [NameInMap("Jdk")]
        [Validation(Required=false)]
        public string Jdk { get; set; }

        [NameInMap("KafkaConfigs")]
        [Validation(Required=false)]
        public string KafkaConfigs { get; set; }

        /// <summary>
        /// {"exec":{"command":["sh","-c","cat /home/admin/start.sh"]},"initialDelaySeconds":30,"periodSeconds":30,"timeoutSeconds":2}
        /// </summary>
        [NameInMap("Liveness")]
        [Validation(Required=false)]
        public string Liveness { get; set; }

        /// <summary>
        /// 1024
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        [NameInMap("MicroRegistration")]
        [Validation(Required=false)]
        public string MicroRegistration { get; set; }

        [NameInMap("MicroRegistrationConfig")]
        [Validation(Required=false)]
        public string MicroRegistrationConfig { get; set; }

        /// <summary>
        /// [{mountPath: "/tmp", nasPath: "/"}]
        /// </summary>
        [NameInMap("MountDesc")]
        [Validation(Required=false)]
        public string MountDesc { get; set; }

        /// <summary>
        /// example.com
        /// </summary>
        [NameInMap("MountHost")]
        [Validation(Required=false)]
        public string MountHost { get; set; }

        /// <summary>
        /// cn-beijing:test
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        [NameInMap("NasConfigs")]
        [Validation(Required=false)]
        public string NasConfigs { get; set; }

        /// <summary>
        /// KSAK\\*\\*\\*\\*
        /// </summary>
        [NameInMap("NasId")]
        [Validation(Required=false)]
        public string NasId { get; set; }

        /// <summary>
        /// xxxxxx
        /// </summary>
        [NameInMap("OssAkId")]
        [Validation(Required=false)]
        public string OssAkId { get; set; }

        /// <summary>
        /// xxxxxx
        /// </summary>
        [NameInMap("OssAkSecret")]
        [Validation(Required=false)]
        public string OssAkSecret { get; set; }

        /// <summary>
        /// [{"bucketName": "oss-bucket", "bucketPath": "data/user.data", "mountPath": "/usr/data/user.data", "readOnly": true}]
        /// </summary>
        [NameInMap("OssMountDescs")]
        [Validation(Required=false)]
        public string OssMountDescs { get; set; }

        /// <summary>
        /// FatJar
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PackageType")]
        [Validation(Required=false)]
        public string PackageType { get; set; }

        /// <summary>
        /// http://myoss.oss-cn-\\*\\*\\*\\*.aliyuncs.com/my-buc/2019-06-30/\\*\\*\\*\\*.jar
        /// </summary>
        [NameInMap("PackageUrl")]
        [Validation(Required=false)]
        public string PackageUrl { get; set; }

        /// <summary>
        /// 1.0.0
        /// </summary>
        [NameInMap("PackageVersion")]
        [Validation(Required=false)]
        public string PackageVersion { get; set; }

        [NameInMap("Php")]
        [Validation(Required=false)]
        public string Php { get; set; }

        /// <summary>
        /// /usr/local/etc/php/conf.d/arms.ini
        /// </summary>
        [NameInMap("PhpArmsConfigLocation")]
        [Validation(Required=false)]
        public string PhpArmsConfigLocation { get; set; }

        /// <summary>
        /// k1=v1
        /// </summary>
        [NameInMap("PhpConfig")]
        [Validation(Required=false)]
        public string PhpConfig { get; set; }

        /// <summary>
        /// /usr/local/etc/php/php.ini
        /// </summary>
        [NameInMap("PhpConfigLocation")]
        [Validation(Required=false)]
        public string PhpConfigLocation { get; set; }

        /// <summary>
        /// {"exec":{"command":["cat","/etc/group"]}}
        /// </summary>
        [NameInMap("PostStart")]
        [Validation(Required=false)]
        public string PostStart { get; set; }

        /// <summary>
        /// {"exec":{"command":["cat","/etc/group"]}}
        /// </summary>
        [NameInMap("PreStop")]
        [Validation(Required=false)]
        public string PreStop { get; set; }

        [NameInMap("ProgrammingLanguage")]
        [Validation(Required=false)]
        public string ProgrammingLanguage { get; set; }

        [NameInMap("PvtzDiscoverySvc")]
        [Validation(Required=false)]
        public string PvtzDiscoverySvc { get; set; }

        [NameInMap("Python")]
        [Validation(Required=false)]
        public string Python { get; set; }

        [NameInMap("PythonModules")]
        [Validation(Required=false)]
        public string PythonModules { get; set; }

        /// <summary>
        /// {"exec":{"command":["sh","-c","cat /home/admin/start.sh"]},"initialDelaySeconds":30,"periodSeconds":30,"timeoutSeconds":2}
        /// </summary>
        [NameInMap("Readiness")]
        [Validation(Required=false)]
        public string Readiness { get; set; }

        /// <summary>
        /// 1
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public int? Replicas { get; set; }

        [NameInMap("SaeVersion")]
        [Validation(Required=false)]
        public string SaeVersion { get; set; }

        /// <summary>
        /// sg-wz969ngg2e49q5i4\\*\\*\\*\\*
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        [NameInMap("ServiceTags")]
        [Validation(Required=false)]
        public string ServiceTags { get; set; }

        /// <summary>
        /// [{"logDir":"","logType":"stdout"},{"logDir":"/tmp/a.log"}]
        /// </summary>
        [NameInMap("SlsConfigs")]
        [Validation(Required=false)]
        public string SlsConfigs { get; set; }

        /// <summary>
        /// 30
        /// </summary>
        [NameInMap("TerminationGracePeriodSeconds")]
        [Validation(Required=false)]
        public int? TerminationGracePeriodSeconds { get; set; }

        /// <summary>
        /// Asia/Shanghai
        /// </summary>
        [NameInMap("Timezone")]
        [Validation(Required=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// {"port":8080,"contextPath":"/","maxThreads":400,"uriEncoding":"ISO-8859-1","useBodyEncodingForUri":true}
        /// </summary>
        [NameInMap("TomcatConfig")]
        [Validation(Required=false)]
        public string TomcatConfig { get; set; }

        /// <summary>
        /// vsw-bp12mw1f8k3jgygk9\\*\\*\\*\\*
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// vpc-bp1aevy8sofi8mh1q\\*\\*\\*\\*
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// CATALINA_OPTS=\\\\"$CATALINA_OPTS $Options\\\\" catalina.sh run
        /// </summary>
        [NameInMap("WarStartOptions")]
        [Validation(Required=false)]
        public string WarStartOptions { get; set; }

        /// <summary>
        /// apache-tomcat-7.0.91
        /// </summary>
        [NameInMap("WebContainer")]
        [Validation(Required=false)]
        public string WebContainer { get; set; }

    }

}
