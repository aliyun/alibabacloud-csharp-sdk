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
        /// <item><description><b>2xx</b>: The call was successful.</description></item>
        /// <item><description><b>3xx</b>: The call was redirected.</description></item>
        /// <item><description><b>4xx</b>: The call failed.</description></item>
        /// <item><description><b>5xx</b>: A server error occurred.</description></item>
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
            /// <para>The version of the container, such as Ali-Tomcat, in which an application that is developed based on High-speed Service Framework (HSF) is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.5.3</para>
            /// </summary>
            [NameInMap("EdasContainerVersion")]
            [Validation(Required=false)]
            public string EdasContainerVersion { get; set; }

            /// <summary>
            /// <para>The ID of the instance group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b2a8a925-477a-eswa-b823-d5e22500****</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The name of the instance group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>_DEFAULT_GROUP</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The type of the instance group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("GroupType")]
            [Validation(Required=false)]
            public int? GroupType { get; set; }

            /// <summary>
            /// <para>The URL of the image. This parameter is returned only if the <b>PackageType</b> parameter is set to <b>Image</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>registry-vpc.cn-hangzhou.aliyuncs.com/demo/nginx:latest</para>
            /// </summary>
            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            /// <summary>
            /// <para>The version of the JDK on which the deployment package of the application depends. This parameter is not returned if the <b>PackageType</b> parameter is set to <b>Image</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Open JDK 8</para>
            /// </summary>
            [NameInMap("Jdk")]
            [Validation(Required=false)]
            public string Jdk { get; set; }

            /// <summary>
            /// <para>The type of the deployment package. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>If you deploy a Java application, the value of this parameter can be <b>FatJar</b>, <b>War</b>, or <b>Image</b>.</para>
            /// </description></item>
            /// <item><description><para>If you deploy a PHP application, the value of this parameter can be one of the following values:</para>
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
            /// <para>The URL of the deployment package. This parameter is returned only if the <b>PackageType</b> parameter is set to <b>FatJar</b>, <b>War</b>, or <b>PhpZip</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>registry-vpc.cn-hangzhou.aliyuncs.com/demo/nginx:latest</para>
            /// </summary>
            [NameInMap("PackageUrl")]
            [Validation(Required=false)]
            public string PackageUrl { get; set; }

            /// <summary>
            /// <para>The version of the deployment package. This parameter is returned only if the <b>PackageType</b> parameter is set to <b>FatJar</b>, <b>War</b>, or <b>PhpZip</b>. The value of this parameter is automatically generated only if the <b>ImageUrl</b> is returned.</para>
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
            /// <para>The version of the Tomcat container on which the deployment package depends. This parameter is not returned if the <b>PackageType</b> parameter is set to <b>Image</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Apache Tomcat 7</para>
            /// </summary>
            [NameInMap("WebContainer")]
            [Validation(Required=false)]
            public string WebContainer { get; set; }

        }

        /// <summary>
        /// <para>The error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the call is successful, the <b>ErrorCode</b> parameter is not returned.</description></item>
        /// <item><description>If the call fails, the <b>ErrorCode</b> parameter is returned. For more information, see the <b>Error codes</b> section in this topic.</description></item>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>91F93257-7A4A-4BD3-9A7E-2F6EAE6D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance groups of an application were obtained. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The instance groups were obtained.</description></item>
        /// <item><description><b>false</b>: The instance groups failed to be obtained.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID that is used to query the details of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
