// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListEiamInstancesResponseBody : TeaModel {
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<ListEiamInstancesResponseBodyInstances> Instances { get; set; }
        public class ListEiamInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>实例描述信息</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>实例developer私网域名地址</para>
            /// 
            /// <b>Example:</b>
            /// <para>eiam-developerapi-cn.vpc-proxy.aliyuncs.com</para>
            /// </summary>
            [NameInMap("DeveloperAPIPrivateDomain")]
            [Validation(Required=false)]
            public string DeveloperAPIPrivateDomain { get; set; }

            /// <summary>
            /// <para>实例developer公网域名地址</para>
            /// 
            /// <b>Example:</b>
            /// <para>eiam-developerapi.cn-hangzhou.aliyuncs.com</para>
            /// </summary>
            [NameInMap("DeveloperAPIPublicDomain")]
            [Validation(Required=false)]
            public string DeveloperAPIPublicDomain { get; set; }

            /// <summary>
            /// <para>实例id</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_eypq6ljgyeuwmlw672sulxxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>实例状态，Pending(初始状态)、Creating(创建中)、Running(运行中)、Disabled(禁用)、CreateFailed(创建失败)</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            /// <summary>
            /// <para>实例版本，EIAM2.0/ EIAM1.0</para>
            /// 
            /// <b>Example:</b>
            /// <para>EIAM 2.0</para>
            /// </summary>
            [NameInMap("InstanceVersion")]
            [Validation(Required=false)]
            public string InstanceVersion { get; set; }

            /// <summary>
            /// <para>实例openApi私网域名地址</para>
            /// 
            /// <b>Example:</b>
            /// <para>eiam-cn.vpc-proxy.aliyuncs.com</para>
            /// </summary>
            [NameInMap("OpenAPIPrivateDomain")]
            [Validation(Required=false)]
            public string OpenAPIPrivateDomain { get; set; }

            /// <summary>
            /// <para>实例openApi公网域名地址</para>
            /// 
            /// <b>Example:</b>
            /// <para>eiam.cn-hangzhou.aliyuncs.com</para>
            /// </summary>
            [NameInMap("OpenAPIPublicDomain")]
            [Validation(Required=false)]
            public string OpenAPIPublicDomain { get; set; }

            /// <summary>
            /// <para>实例域名地址</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx.aliyunidaas.com</para>
            /// </summary>
            [NameInMap("SSODomain")]
            [Validation(Required=false)]
            public string SSODomain { get; set; }

            /// <summary>
            /// <para>实例的创建时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>1677810869300</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
