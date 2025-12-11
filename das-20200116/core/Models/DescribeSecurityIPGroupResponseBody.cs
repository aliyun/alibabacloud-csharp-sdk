// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSecurityIPGroupResponseBody : TeaModel {
        /// <summary>
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
            [NameInMap("SecurityIpGroups")]
            [Validation(Required=false)]
            public List<DescribeSecurityIPGroupResponseBodyDataSecurityIpGroups> SecurityIpGroups { get; set; }
            public class DescribeSecurityIPGroupResponseBodyDataSecurityIpGroups : TeaModel {
                [NameInMap("DbInstances")]
                [Validation(Required=false)]
                public List<string> DbInstances { get; set; }

                [NameInMap("EngineInfoList")]
                [Validation(Required=false)]
                public List<DescribeSecurityIPGroupResponseBodyDataSecurityIpGroupsEngineInfoList> EngineInfoList { get; set; }
                public class DescribeSecurityIPGroupResponseBodyDataSecurityIpGroupsEngineInfoList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>PolarDBMySQL</para>
                    /// </summary>
                    [NameInMap("EngineName")]
                    [Validation(Required=false)]
                    public string EngineName { get; set; }

                    [NameInMap("InstanceIds")]
                    [Validation(Required=false)]
                    public List<string> InstanceIds { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("InstanceNum")]
                    [Validation(Required=false)]
                    public int? InstanceNum { get; set; }

                }

                [NameInMap("GEcsSgIdList")]
                [Validation(Required=false)]
                public string GEcsSgIdList { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>192.168.1.28/32</para>
                /// </summary>
                [NameInMap("GIpList")]
                [Validation(Required=false)]
                public string GIpList { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test_123</para>
                /// </summary>
                [NameInMap("GlobalIgName")]
                [Validation(Required=false)]
                public string GlobalIgName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>g-1no2rzybnqcv****</para>
                /// </summary>
                [NameInMap("GlobalSecurityGroupId")]
                [Validation(Required=false)]
                public string GlobalSecurityGroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ipv4</para>
                /// </summary>
                [NameInMap("SecurityIpType")]
                [Validation(Required=false)]
                public string SecurityIpType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>160-79abe3f4****</para>
                /// </summary>
                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>641***</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>mix</para>
                /// </summary>
                [NameInMap("WhitelistNetType")]
                [Validation(Required=false)]
                public string WhitelistNetType { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CAC553F1-C669-53F1-A295-2CF050E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
