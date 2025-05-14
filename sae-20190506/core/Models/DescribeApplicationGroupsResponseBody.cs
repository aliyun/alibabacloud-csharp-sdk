// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeApplicationGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: indicates that the request was successful.</description></item>
        /// <item><description><b>3xx</b>: indicates that the request was redirected.</description></item>
        /// <item><description><b>4xx</b>: indicates that the request was invalid.</description></item>
        /// <item><description><b>5xx</b>: indicates that a server error occurred.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The information about the instance groups of the application.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeApplicationGroupsResponseBodyData> Data { get; set; }
        public class DescribeApplicationGroupsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The version of the container, such as Ali-Tomcat, in which a High-speed Service Framework (HSF) application runs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.5.3</para>
            /// </summary>
            [NameInMap("EdasContainerVersion")]
            [Validation(Required=false)]
            public string EdasContainerVersion { get; set; }

            /// <summary>
            /// <para>The ID of the group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b2a8a925-477a-eswa-b823-d5e22500****</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The name of the group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>_DEFAULT_GROUP</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The type of the group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("GroupType")]
            [Validation(Required=false)]
            public int? GroupType { get; set; }

            /// <summary>
            /// <para>The address of the image. This parameter is required when the <b>PackageType</b> parameter is set to <b>Image</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>registry-vpc.cn-hangzhou.aliyuncs.com/demo/nginx:latest</para>
            /// </summary>
            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            /// <summary>
            /// <para>The version of the Java development kit (JDK) on which the deployment package of the application depends. This parameter is invalid when the <b>PackageType</b> parameter is set to <b>Image</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Open JDK 8</para>
            /// </summary>
            [NameInMap("Jdk")]
            [Validation(Required=false)]
            public string Jdk { get; set; }

            /// <summary>
            /// <para>The type of the application deployment package. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>When you use a Java package, set this value to <b>FatJar</b>, <b>War</b>, or <b>Image</b>.</para>
            /// </description></item>
            /// <item><description><para>When you use a PHP package, the following values are valid:</para>
            /// <list type="bullet">
            /// <item><description><b>PhpZip</b></description></item>
            /// <item><description><b>IMAGE_PHP_5_4</b></description></item>
            /// <item><description><b>IMAGE_PHP_5_4_ALPINE</b></description></item>
            /// <item><description><b>IMAGE_PHP_5_5</b></description></item>
            /// <item><description><b>IMAGE_PHP_5_5_ALPINE</b></description></item>
            /// <item><description><b>IMAGE_PHP_5_6</b></description></item>
            /// <item><description><b>IMAGE_PHP_5_6_ALPINE</b></description></item>
            /// <item><description><b>IMAGE_PHP_7_0</b></description></item>
            /// <item><description><b>IMAGE_PHP_7_0_ALPINE</b></description></item>
            /// <item><description><b>IMAGE_PHP_7_1</b></description></item>
            /// <item><description><b>IMAGE_PHP_7_1_ALPINE</b></description></item>
            /// <item><description><b>IMAGE_PHP_7_2</b></description></item>
            /// <item><description><b>IMAGE_PHP_7_2_ALPINE</b></description></item>
            /// <item><description><b>IMAGE_PHP_7_3</b></description></item>
            /// <item><description><b>IMAGE_PHP_7_3_ALPINE</b></description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Image</para>
            /// </summary>
            [NameInMap("PackageType")]
            [Validation(Required=false)]
            public string PackageType { get; set; }

            /// <summary>
            /// <para>The address of the deployment package. This parameter is required when the <b>PackageType</b> parameter is set to <b>FatJar</b>, <b>War</b>, or <b>PhpZip</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>registry-vpc.cn-hangzhou.aliyuncs.com/demo/nginx:latest</para>
            /// </summary>
            [NameInMap("PackageUrl")]
            [Validation(Required=false)]
            public string PackageUrl { get; set; }

            /// <summary>
            /// <para>The version of the deployment package. This parameter is required when the <b>PackageType</b> parameter is set to <b>FatJar</b>, <b>War</b>, or <b>PhpZip</b>. The parameter value will be automatically generated when you use an image to deploy the application and specify the <b>ImageUrl</b> parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("PackageVersion")]
            [Validation(Required=false)]
            public string PackageVersion { get; set; }

            [NameInMap("PackageVersionId")]
            [Validation(Required=false)]
            public string PackageVersionId { get; set; }

            /// <summary>
            /// <para>The total number of instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Replicas")]
            [Validation(Required=false)]
            public int? Replicas { get; set; }

            /// <summary>
            /// <para>The number of running instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RunningInstances")]
            [Validation(Required=false)]
            public int? RunningInstances { get; set; }

            /// <summary>
            /// <para>The version of the Apache Tomcat container on which the deployment package of the application depends. This parameter is invalid when the <b>PackageType</b> parameter is set to <b>Image</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Apache Tomcat 7</para>
            /// </summary>
            [NameInMap("WebContainer")]
            [Validation(Required=false)]
            public string WebContainer { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// <list type="bullet">
        /// <item><description>The <b>ErrorCode</b> parameter is not returned when the request succeeds.</description></item>
        /// <item><description>The <b>ErrorCode</b> parameter is returned when the request fails. For more information, see <b>Error codes</b> in this topic.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
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
        /// <para>91F93257-7A4A-4BD3-9A7E-2F6EAE6D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the information about instance groups of an application was obtained. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: indicates that the information was obtained.</description></item>
        /// <item><description><b>false</b>: indicates that the information could not be obtained.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The ID of the trace. It is used to query the details of a request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
