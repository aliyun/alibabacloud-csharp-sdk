// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyScaDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribePropertyScaDetailResponseBodyPageInfo PageInfo { get; set; }
        public class DescribePropertyScaDetailResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
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
            /// <para>The value of NextToken that is returned when the NextToken method is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>B60***</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page. Default value: <b>10</b>.</para>
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
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The details about the asset fingerprints returned.</para>
        /// </summary>
        [NameInMap("Propertys")]
        [Validation(Required=false)]
        public List<DescribePropertyScaDetailResponseBodyPropertys> Propertys { get; set; }
        public class DescribePropertyScaDetailResponseBodyPropertys : TeaModel {
            /// <summary>
            /// <para>The type of the middleware, database, or web service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>system_service</b>: system service</description></item>
            /// <item><description><b>software_library</b>: software library</description></item>
            /// <item><description><b>docker_component</b>: container component</description></item>
            /// <item><description><b>database</b>: database</description></item>
            /// <item><description><b>web_container</b>: web container</description></item>
            /// <item><description><b>jar</b>: JAR package</description></item>
            /// <item><description><b>web_framework</b>: web framework</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>software_library</para>
            /// </summary>
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// <para>The display name of the type of the middleware, database, or web service . Valid values:</para>
            /// <list type="bullet">
            /// <item><description>System service</description></item>
            /// <item><description>Software library</description></item>
            /// <item><description>Container component</description></item>
            /// <item><description>Database</description></item>
            /// <item><description>Web container</description></item>
            /// <item><description>JAR package</description></item>
            /// <item><description>Web framework</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>System Service</para>
            /// </summary>
            [NameInMap("BizTypeDispaly")]
            [Validation(Required=false)]
            public string BizTypeDispaly { get; set; }

            /// <summary>
            /// <para>The command line of the process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/sbin/dhclient -H iz2zeflhhbtk8gtxzt087az -1 -q -lf /var/lib/dhclient/dhclient--eth0.lease -pf /var/run/dhclient-eth0.pid eth0</para>
            /// </summary>
            [NameInMap("Cmdline")]
            [Validation(Required=false)]
            public string Cmdline { get; set; }

            /// <summary>
            /// <para>The path to the configuration file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/etc/my.cnf</para>
            /// </summary>
            [NameInMap("ConfigPath")]
            [Validation(Required=false)]
            public string ConfigPath { get; set; }

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
            /// <para>The latest collection timestamp, which indicates the last timestamp when Security Center collected the information about the middleware, database, or web service. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1597987834000</para>
            /// </summary>
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// <para>The name of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>registry-vpc.cn-beijing.aliyuncs.com/acs/aliyun-ingress-controller****</para>
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// <para>The ID of the server on which the middleware, database, or web service is run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-2zeclqj7ti****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the server on which the middleware, database, or web service is run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test01</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the server on which the middleware, database, or web service is run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.42.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the server on which the middleware, database, or web service is run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.210.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The public IP address of the server on which the middleware, database, or web service is run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.42.XX.XX</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The IP address that the process monitors.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.XX.XX</para>
            /// </summary>
            [NameInMap("ListenIp")]
            [Validation(Required=false)]
            public string ListenIp { get; set; }

            /// <summary>
            /// <para>The protocol of the traffic on which the process listens. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>UDP</b></description></item>
            /// <item><description><b>TCP</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>UDP</para>
            /// </summary>
            [NameInMap("ListenProtocol")]
            [Validation(Required=false)]
            public string ListenProtocol { get; set; }

            /// <summary>
            /// <para>The listening status of the process. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NONE</b>: not listening</description></item>
            /// <item><description><b>LISTEN</b>: listening</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NONE</para>
            /// </summary>
            [NameInMap("ListenStatus")]
            [Validation(Required=false)]
            public string ListenStatus { get; set; }

            /// <summary>
            /// <para>The name of the middleware, database, or web service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>openssl</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The path of the middleware, database, or web service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/usr/lib64/libssl.so.1.0.2k</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The PID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>756</para>
            /// </summary>
            [NameInMap("Pid")]
            [Validation(Required=false)]
            public string Pid { get; set; }

            /// <summary>
            /// <para>The name of the Kubernetes pod.</para>
            /// 
            /// <b>Example:</b>
            /// <para>myapp-pod</para>
            /// </summary>
            [NameInMap("PodName")]
            [Validation(Required=false)]
            public string PodName { get; set; }

            /// <summary>
            /// <para>The port of the middleware, database, or web service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>68</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>The ID of the parent process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Ppid")]
            [Validation(Required=false)]
            public string Ppid { get; set; }

            /// <summary>
            /// <para>The timestamp when the process starts. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1596539788</para>
            /// </summary>
            [NameInMap("ProcessStarted")]
            [Validation(Required=false)]
            public long? ProcessStarted { get; set; }

            /// <summary>
            /// <para>The name of the user who runs the process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root</para>
            /// </summary>
            [NameInMap("ProcessUser")]
            [Validation(Required=false)]
            public string ProcessUser { get; set; }

            /// <summary>
            /// <para>The version verification information about the middleware, database, or web service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/usr/lib64/libssl.so.1.0.2k</para>
            /// </summary>
            [NameInMap("Proof")]
            [Validation(Required=false)]
            public string Proof { get; set; }

            /// <summary>
            /// <para>The version of the runtime environment.</para>
            /// <remarks>
            /// <para> The value of this parameter can be the Java Development Kit (JDK) version of the runtime environment for a Java process.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1.8.0_144</para>
            /// </summary>
            [NameInMap("RuntimeEnvVersion")]
            [Validation(Required=false)]
            public string RuntimeEnvVersion { get; set; }

            /// <summary>
            /// <para>The type of the middleware, database, or web service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>library</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The UUID of the server on which the middleware, database, or web service is run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>uuid-02ebabe7-1c19-a****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// <para>The version of the middleware, database, or web service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.2k</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>The web directory.</para>
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
        /// <para>F9146867-16C8-4AAB-BB4FB8C2A4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
