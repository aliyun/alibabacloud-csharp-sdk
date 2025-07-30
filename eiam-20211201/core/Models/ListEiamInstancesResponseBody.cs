// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListEiamInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance list.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<ListEiamInstancesResponseBodyInstances> Instances { get; set; }
        public class ListEiamInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>The instance description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The private domain name of the instance Developer API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eiam-developerapi-cn.vpc-proxy.aliyuncs.com</para>
            /// </summary>
            [NameInMap("DeveloperAPIPrivateDomain")]
            [Validation(Required=false)]
            public string DeveloperAPIPrivateDomain { get; set; }

            /// <summary>
            /// <para>The public domain of the instance Developer API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eiam-developerapi.cn-hangzhou.aliyuncs.com</para>
            /// </summary>
            [NameInMap("DeveloperAPIPublicDomain")]
            [Validation(Required=false)]
            public string DeveloperAPIPublicDomain { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_eypq6ljgyeuwmlw672sulxxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            /// <summary>
            /// <para>The instance version.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>EIAM 2.0</description></item>
            /// <item><description>EIAM 1.0</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>EIAM 2.0</para>
            /// </summary>
            [NameInMap("InstanceVersion")]
            [Validation(Required=false)]
            public string InstanceVersion { get; set; }

            /// <summary>
            /// <para>The private domain of the instance OpenAPI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eiam-cn.vpc-proxy.aliyuncs.com</para>
            /// </summary>
            [NameInMap("OpenAPIPrivateDomain")]
            [Validation(Required=false)]
            public string OpenAPIPrivateDomain { get; set; }

            /// <summary>
            /// <para>The public domain of the instance OpenAPI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eiam.cn-hangzhou.aliyuncs.com</para>
            /// </summary>
            [NameInMap("OpenAPIPublicDomain")]
            [Validation(Required=false)]
            public string OpenAPIPublicDomain { get; set; }

            /// <summary>
            /// <para>The single sign-on (SSO) domain  of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx.aliyunidaas.com</para>
            /// </summary>
            [NameInMap("SSODomain")]
            [Validation(Required=false)]
            public string SSODomain { get; set; }

            /// <summary>
            /// <para>The time when the instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1677810869300</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
