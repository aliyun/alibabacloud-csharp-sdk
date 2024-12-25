// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeVServerGroupAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend servers.</para>
        /// </summary>
        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public DescribeVServerGroupAttributeResponseBodyBackendServers BackendServers { get; set; }
        public class DescribeVServerGroupAttributeResponseBodyBackendServers : TeaModel {
            [NameInMap("BackendServer")]
            [Validation(Required=false)]
            public List<DescribeVServerGroupAttributeResponseBodyBackendServersBackendServer> BackendServer { get; set; }
            public class DescribeVServerGroupAttributeResponseBodyBackendServersBackendServer : TeaModel {
                /// <summary>
                /// <para>The description of the server group.</para>
                /// <remarks>
                /// <para> This parameter is not returned if the Description parameter is not specified in the request.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Server Group Description</para>
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
                /// <para>vm-233</para>
                /// </summary>
                [NameInMap("ServerId")]
                [Validation(Required=false)]
                public string ServerId { get; set; }

                /// <summary>
                /// <para>The IP address of the backend server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.XX.XX.11</para>
                /// </summary>
                [NameInMap("ServerIp")]
                [Validation(Required=false)]
                public string ServerIp { get; set; }

                /// <summary>
                /// <para>The type of backend server. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ecs</b>: ECS instance</description></item>
                /// <item><description><b>eni</b>: ENI</description></item>
                /// <item><description><b>eci</b>: elastic container instance</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ecs</para>
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
        /// <para>The time when the CLB instance was created. The time follows the <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08-31T02:49:05Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The ID of the CLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-jfakd****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9DEC9C28-AB05-4DDF-9A78-6B08EC9CE18C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The tags of the backend server.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeVServerGroupAttributeResponseBodyTags Tags { get; set; }
        public class DescribeVServerGroupAttributeResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeVServerGroupAttributeResponseBodyTagsTag> Tag { get; set; }
            public class DescribeVServerGroupAttributeResponseBodyTagsTag : TeaModel {
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

        /// <summary>
        /// <para>The ID of the vServer group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rsp-cige6****</para>
        /// </summary>
        [NameInMap("VServerGroupId")]
        [Validation(Required=false)]
        public string VServerGroupId { get; set; }

        /// <summary>
        /// <para>The name of the vServer group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Group1</para>
        /// </summary>
        [NameInMap("VServerGroupName")]
        [Validation(Required=false)]
        public string VServerGroupName { get; set; }

    }

}
