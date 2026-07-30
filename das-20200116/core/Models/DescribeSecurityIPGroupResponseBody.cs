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
        /// <para>ListResult</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSecurityIPGroupResponseBodyData Data { get; set; }
        public class DescribeSecurityIPGroupResponseBodyData : TeaModel {
            /// <summary>
            /// <para>A list of all cross-product whitelist templates in the specified region.</para>
            /// </summary>
            [NameInMap("SecurityIpGroups")]
            [Validation(Required=false)]
            public List<DescribeSecurityIPGroupResponseBodyDataSecurityIpGroups> SecurityIpGroups { get; set; }
            public class DescribeSecurityIPGroupResponseBodyDataSecurityIpGroups : TeaModel {
                /// <summary>
                /// <para>The database instances that are attached to the whitelist template.</para>
                /// </summary>
                [NameInMap("DbInstances")]
                [Validation(Required=false)]
                public List<string> DbInstances { get; set; }

                /// <summary>
                /// <para>The information about the instances of each product that are attached to the template.</para>
                /// </summary>
                [NameInMap("EngineInfoList")]
                [Validation(Required=false)]
                public List<DescribeSecurityIPGroupResponseBodyDataSecurityIpGroupsEngineInfoList> EngineInfoList { get; set; }
                public class DescribeSecurityIPGroupResponseBodyDataSecurityIpGroupsEngineInfoList : TeaModel {
                    /// <summary>
                    /// <para>The database type of the destination instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PolarDBMySQL</para>
                    /// </summary>
                    [NameInMap("EngineName")]
                    [Validation(Required=false)]
                    public string EngineName { get; set; }

                    /// <summary>
                    /// <para>A list of database instance IDs.</para>
                    /// </summary>
                    [NameInMap("InstanceIds")]
                    [Validation(Required=false)]
                    public List<string> InstanceIds { get; set; }

                    /// <summary>
                    /// <para>The number of instances that belong to the current logon account.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("InstanceNum")]
                    [Validation(Required=false)]
                    public int? InstanceNum { get; set; }

                }

                /// <summary>
                /// <para>The ID of the ECS security group. This parameter is deprecated and is retained for compatibility. It will be removed in a future version.</para>
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
                /// <para>The name of the IP address whitelist template. The name must meet the following requirements:</para>
                /// <list type="bullet">
                /// <item><description><para>It must consist of lowercase letters, digits, and underscores (_).</para>
                /// </description></item>
                /// <item><description><para>It must start with a letter and end with a letter or a digit.</para>
                /// </description></item>
                /// <item><description><para>It must be 2 to 120 characters in length.</para>
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
                /// <para>The ID of the IP address whitelist template.</para>
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
                /// <para>The IP address type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ipv4</para>
                /// </summary>
                [NameInMap("SecurityIpType")]
                [Validation(Required=false)]
                public string SecurityIpType { get; set; }

                /// <summary>
                /// <para>The account ID. You can obtain the ID of your logon account on the <b>Security Settings</b> page of <b>Account Management</b>.</para>
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
        /// <para>If the request is successful, <b>Successful</b> is returned. If the request fails, an error message is returned, such as an error code.</para>
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
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
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
