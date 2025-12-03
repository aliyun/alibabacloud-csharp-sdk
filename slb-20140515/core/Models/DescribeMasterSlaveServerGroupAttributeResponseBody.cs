// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeMasterSlaveServerGroupAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the CLB instance was created. The time follows the <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-12-02T02:49:05Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The ID of the associated CLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-14fadafw4343a******</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>A list of backend servers in the primary/secondary server group.</para>
        /// </summary>
        [NameInMap("MasterSlaveBackendServers")]
        [Validation(Required=false)]
        public DescribeMasterSlaveServerGroupAttributeResponseBodyMasterSlaveBackendServers MasterSlaveBackendServers { get; set; }
        public class DescribeMasterSlaveServerGroupAttributeResponseBodyMasterSlaveBackendServers : TeaModel {
            [NameInMap("MasterSlaveBackendServer")]
            [Validation(Required=false)]
            public List<DescribeMasterSlaveServerGroupAttributeResponseBodyMasterSlaveBackendServersMasterSlaveBackendServer> MasterSlaveBackendServer { get; set; }
            public class DescribeMasterSlaveServerGroupAttributeResponseBodyMasterSlaveBackendServersMasterSlaveBackendServer : TeaModel {
                /// <summary>
                /// <para>The description of the primary/secondary server group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Primary and secondary server group description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The port that is used by the backend server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The ID of the backend server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eni-hhshhs****</para>
                /// </summary>
                [NameInMap("ServerId")]
                [Validation(Required=false)]
                public string ServerId { get; set; }

                /// <summary>
                /// <para>The type of backend server. Valid values: <b>Master</b> and <b>Slave</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Slave</para>
                /// </summary>
                [NameInMap("ServerType")]
                [Validation(Required=false)]
                public string ServerType { get; set; }

                /// <summary>
                /// <para>The type of the backend server. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ecs</b> (default): Elastic Compute Service (ECS) instance</description></item>
                /// <item><description><b>eni</b>: elastic network interface (ENI)</description></item>
                /// <item><description><b>eci</b>: elastic container instance</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>eni</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The weight of the backend server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the primary/secondary server group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rsp-cige6******</para>
        /// </summary>
        [NameInMap("MasterSlaveServerGroupId")]
        [Validation(Required=false)]
        public string MasterSlaveServerGroupId { get; set; }

        /// <summary>
        /// <para>The name of the primary/secondary server group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Group1</para>
        /// </summary>
        [NameInMap("MasterSlaveServerGroupName")]
        [Validation(Required=false)]
        public string MasterSlaveServerGroupName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9DEC9C28-AB05-4DDF-9A78-6B0******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The tag list.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeMasterSlaveServerGroupAttributeResponseBodyTags Tags { get; set; }
        public class DescribeMasterSlaveServerGroupAttributeResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeMasterSlaveServerGroupAttributeResponseBodyTagsTag> Tag { get; set; }
            public class DescribeMasterSlaveServerGroupAttributeResponseBodyTagsTag : TeaModel {
                /// <summary>
                /// <para>The tag key. Valid values of N: <b>1</b> to <b>20</b>. The tag key cannot be an empty string.</para>
                /// <para>The tag key can be up to 64 characters in length, and cannot contain <c>http://</c> or <c>https://</c>. The tag key cannot start with <c>aliyun</c> or <c>acs:</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value. Valid values of N: <b>1</b> to <b>20</b>. The tag value can be an empty string.</para>
                /// <para>The tag value can be up to 128 characters in length, and cannot contain <c>http://</c> or <c>https://</c>. The tag value cannot start with <c>acs:</c> or <c>aliyun</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestValue</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

    }

}
