// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeApplicationGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code or the POP error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>2xx</b>: The request is successful.</para>
        /// </description></item>
        /// <item><description><para><b>3xx</b>: The request is redirected.</para>
        /// </description></item>
        /// <item><description><para><b>4xx</b>: The request is invalid.</para>
        /// </description></item>
        /// <item><description><para><b>5xx</b>: A server error occurs.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>A list of application groups.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeApplicationGroupsResponseBodyData> Data { get; set; }
        public class DescribeApplicationGroupsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The version of the application runtime environment in the High-Speed Service Framework (HSF), such as an Ali-Tomcat container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.5.3</para>
            /// </summary>
            [NameInMap("EdasContainerVersion")]
            [Validation(Required=false)]
            public string EdasContainerVersion { get; set; }

            /// <summary>
            /// <para>The ID of the application group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b2a8a925-477a-eswa-b823-d5e22500****</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The name of the application group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>_DEFAULT_GROUP</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The type of the application group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("GroupType")]
            [Validation(Required=false)]
            public int? GroupType { get; set; }

            /// <summary>
            /// <para>The image URL. This parameter is required when <b>package type</b> is set to <b>Image</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>registry-vpc.cn-hangzhou.aliyuncs.com/demo/nginx:latest</para>
            /// </summary>
            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            /// <summary>
            /// <para>The JDK version required by the deployment package. This parameter is not supported when <b>package type</b> is set to <b>Image</b>.</para>
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
            /// <item><description><para>For Java applications, the supported types are <b>FatJar</b>, <b>War</b>, and <b>Image</b>.</para>
            /// </description></item>
            /// <item><description><para>For PHP applications, the supported types are:</para>
            /// <list type="bullet">
            /// <item><description><para><b>PhpZip</b></para>
            /// </description></item>
            /// <item><description><para><b>IMAGE_PHP_5_4</b></para>
            /// </description></item>
            /// <item><description><para><b>IMAGE_PHP_5_4_ALPINE</b></para>
            /// </description></item>
            /// <item><description><para><b>IMAGE_PHP_5_5</b></para>
            /// </description></item>
            /// <item><description><para><b>IMAGE_PHP_5_5_ALPINE</b></para>
            /// </description></item>
            /// <item><description><para><b>IMAGE_PHP_5_6</b></para>
            /// </description></item>
            /// <item><description><para><b>IMAGE_PHP_5_6_ALPINE</b></para>
            /// </description></item>
            /// <item><description><para><b>IMAGE_PHP_7_0</b></para>
            /// </description></item>
            /// <item><description><para><b>IMAGE_PHP_7_0_ALPINE</b></para>
            /// </description></item>
            /// <item><description><para><b>IMAGE_PHP_7_1</b></para>
            /// </description></item>
            /// <item><description><para><b>IMAGE_PHP_7_1_ALPINE</b></para>
            /// </description></item>
            /// <item><description><para><b>IMAGE_PHP_7_2</b></para>
            /// </description></item>
            /// <item><description><para><b>IMAGE_PHP_7_2_ALPINE</b></para>
            /// </description></item>
            /// <item><description><para><b>IMAGE_PHP_7_3</b></para>
            /// </description></item>
            /// <item><description><para><b>IMAGE_PHP_7_3_ALPINE</b></para>
            /// </description></item>
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
            /// <para>The URL of the deployment package. This parameter is required when <b>package type</b> is set to <b>FatJar</b>, <b>War</b>, or <b>PhpZip</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>registry-vpc.cn-hangzhou.aliyuncs.com/demo/nginx:latest</para>
            /// </summary>
            [NameInMap("PackageUrl")]
            [Validation(Required=false)]
            public string PackageUrl { get; set; }

            /// <summary>
            /// <para>The deployment package version. This parameter is required when <b>package type</b> is set to <b>FatJar</b>, <b>War</b>, or <b>PhpZip</b>. This parameter is automatically generated if you deploy the application by using an <b>image</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("PackageVersion")]
            [Validation(Required=false)]
            public string PackageVersion { get; set; }

            /// <summary>
            /// <para>The ID of the deployment package version.</para>
            /// </summary>
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
            /// <para>The Tomcat container version required by the deployment package. This parameter is not supported when <b>package type</b> is set to <b>Image</b>.</para>
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
        /// <item><description><para>This parameter is not returned if the request is successful.</para>
        /// </description></item>
        /// <item><description><para>This parameter is returned if the request fails. For more information, see the <b>error codes</b> section.</para>
        /// </description></item>
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
        /// <para>Indicates whether the application groups were successfully retrieved. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The application groups were retrieved.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The application groups were not retrieved.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID used to query the details of a request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
