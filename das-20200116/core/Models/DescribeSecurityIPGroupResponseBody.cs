// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSecurityIPGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>ListResult<InstanceSSL></para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSecurityIPGroupResponseBodyData Data { get; set; }
        public class DescribeSecurityIPGroupResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of all cross-engine whitelist templates for the user in the specified region.</para>
            /// </summary>
            [NameInMap("SecurityIpGroups")]
            [Validation(Required=false)]
            public List<DescribeSecurityIPGroupResponseBodyDataSecurityIpGroups> SecurityIpGroups { get; set; }
            public class DescribeSecurityIPGroupResponseBodyDataSecurityIpGroups : TeaModel {
                /// <summary>
                /// <para>The list of database instances bound to the cross-engine whitelist template.</para>
                /// </summary>
                [NameInMap("DbInstances")]
                [Validation(Required=false)]
                public List<string> DbInstances { get; set; }

                /// <summary>
                /// <para>The instance information for each product bound to the template.</para>
                /// </summary>
                [NameInMap("EngineInfoList")]
                [Validation(Required=false)]
                public List<DescribeSecurityIPGroupResponseBodyDataSecurityIpGroupsEngineInfoList> EngineInfoList { get; set; }
                public class DescribeSecurityIPGroupResponseBodyDataSecurityIpGroupsEngineInfoList : TeaModel {
                    /// <summary>
                    /// <para>The database engine type of the target instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PolarDBMySQL</para>
                    /// </summary>
                    [NameInMap("EngineName")]
                    [Validation(Required=false)]
                    public string EngineName { get; set; }

                    /// <summary>
                    /// <para>The list of database instance IDs.</para>
                    /// </summary>
                    [NameInMap("InstanceIds")]
                    [Validation(Required=false)]
                    public List<string> InstanceIds { get; set; }

                    /// <summary>
                    /// <para>The number of instances under the current logon account.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("InstanceNum")]
                    [Validation(Required=false)]
                    public int? InstanceNum { get; set; }

                }

                /// <summary>
                /// <para>The ECS security group ID. This field is invalid and contains redundant data that will be deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("GEcsSgIdList")]
                [Validation(Required=false)]
                public string GEcsSgIdList { get; set; }

                /// <summary>
                /// <para>The IP addresses in the whitelist template.</para>
                /// <remarks>
                /// <para>Separate multiple IP addresses with commas (,).</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.1.28/32</para>
                /// </summary>
                [NameInMap("GIpList")]
                [Validation(Required=false)]
                public string GIpList { get; set; }

                /// <summary>
                /// <para>The IP whitelist template name. The name must meet the following requirements:</para>
                /// <list type="bullet">
                /// <item><description><para>Contains only lowercase letters, digits, and underscores (_).</para>
                /// </description></item>
                /// <item><description><para>Starts with a letter and ends with a letter or digit.</para>
                /// </description></item>
                /// <item><description><para>Contains 2 to 120 characters in length.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>test_123</para>
                /// </summary>
                [NameInMap("GlobalIgName")]
                [Validation(Required=false)]
                public string GlobalIgName { get; set; }

                /// <summary>
                /// <para>The IP whitelist template ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>g-1no2rzybnqcv****</para>
                /// </summary>
                [NameInMap("GlobalSecurityGroupId")]
                [Validation(Required=false)]
                public string GlobalSecurityGroupId { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The IP type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ipv4</para>
                /// </summary>
                [NameInMap("SecurityIpType")]
                [Validation(Required=false)]
                public string SecurityIpType { get; set; }

                /// <summary>
                /// <para>The account ID. You can obtain the ID of the <b>logon account</b> on the <b>Security Settings</b> page in <b>Account Management</b> of the Alibaba Cloud console.</para>
                /// 
                /// <b>Example:</b>
                /// <para>160-79abe3f4****</para>
                /// </summary>
                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>641***</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The network type of the whitelist.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mix</para>
                /// </summary>
                [NameInMap("WhitelistNetType")]
                [Validation(Required=false)]
                public string WhitelistNetType { get; set; }

            }

        }

        /// <summary>
        /// <para>The message returned for the request.</para>
        /// <remarks>
        /// <para>If the request is successful, <b>Successful</b> is returned. If the request fails, an exception message such as an error code is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CAC553F1-C669-53F1-A295-2CF050E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request is successful.</description></item>
        /// <item><description><b>false</b>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
