// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeNetworkInsightsAnalysisResultResponseBody : TeaModel {
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        [NameInMap("Destination")]
        [Validation(Required=false)]
        public string Destination { get; set; }

        [NameInMap("DestinationIp")]
        [Validation(Required=false)]
        public string DestinationIp { get; set; }

        [NameInMap("DestinationPort")]
        [Validation(Required=false)]
        public string DestinationPort { get; set; }

        [NameInMap("DestinationType")]
        [Validation(Required=false)]
        public string DestinationType { get; set; }

        [NameInMap("NetworkInsightsAnalysisComponents")]
        [Validation(Required=false)]
        public DescribeNetworkInsightsAnalysisResultResponseBodyNetworkInsightsAnalysisComponents NetworkInsightsAnalysisComponents { get; set; }
        public class DescribeNetworkInsightsAnalysisResultResponseBodyNetworkInsightsAnalysisComponents : TeaModel {
            [NameInMap("NetworkInsightsAnalysisComponent")]
            [Validation(Required=false)]
            public List<DescribeNetworkInsightsAnalysisResultResponseBodyNetworkInsightsAnalysisComponentsNetworkInsightsAnalysisComponent> NetworkInsightsAnalysisComponent { get; set; }
            public class DescribeNetworkInsightsAnalysisResultResponseBodyNetworkInsightsAnalysisComponentsNetworkInsightsAnalysisComponent : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("DiagnoseCategories")]
                [Validation(Required=false)]
                public DescribeNetworkInsightsAnalysisResultResponseBodyNetworkInsightsAnalysisComponentsNetworkInsightsAnalysisComponentDiagnoseCategories DiagnoseCategories { get; set; }
                public class DescribeNetworkInsightsAnalysisResultResponseBodyNetworkInsightsAnalysisComponentsNetworkInsightsAnalysisComponentDiagnoseCategories : TeaModel {
                    [NameInMap("DiagnoseCategory")]
                    [Validation(Required=false)]
                    public List<DescribeNetworkInsightsAnalysisResultResponseBodyNetworkInsightsAnalysisComponentsNetworkInsightsAnalysisComponentDiagnoseCategoriesDiagnoseCategory> DiagnoseCategory { get; set; }
                    public class DescribeNetworkInsightsAnalysisResultResponseBodyNetworkInsightsAnalysisComponentsNetworkInsightsAnalysisComponentDiagnoseCategoriesDiagnoseCategory : TeaModel {
                        [NameInMap("CategoryItems")]
                        [Validation(Required=false)]
                        public DescribeNetworkInsightsAnalysisResultResponseBodyNetworkInsightsAnalysisComponentsNetworkInsightsAnalysisComponentDiagnoseCategoriesDiagnoseCategoryCategoryItems CategoryItems { get; set; }
                        public class DescribeNetworkInsightsAnalysisResultResponseBodyNetworkInsightsAnalysisComponentsNetworkInsightsAnalysisComponentDiagnoseCategoriesDiagnoseCategoryCategoryItems : TeaModel {
                            [NameInMap("CategoryItem")]
                            [Validation(Required=false)]
                            public List<DescribeNetworkInsightsAnalysisResultResponseBodyNetworkInsightsAnalysisComponentsNetworkInsightsAnalysisComponentDiagnoseCategoriesDiagnoseCategoryCategoryItemsCategoryItem> CategoryItem { get; set; }
                            public class DescribeNetworkInsightsAnalysisResultResponseBodyNetworkInsightsAnalysisComponentsNetworkInsightsAnalysisComponentDiagnoseCategoriesDiagnoseCategoryCategoryItemsCategoryItem : TeaModel {
                                [NameInMap("Code")]
                                [Validation(Required=false)]
                                public string Code { get; set; }

                                [NameInMap("Explanations")]
                                [Validation(Required=false)]
                                public DescribeNetworkInsightsAnalysisResultResponseBodyNetworkInsightsAnalysisComponentsNetworkInsightsAnalysisComponentDiagnoseCategoriesDiagnoseCategoryCategoryItemsCategoryItemExplanations Explanations { get; set; }
                                public class DescribeNetworkInsightsAnalysisResultResponseBodyNetworkInsightsAnalysisComponentsNetworkInsightsAnalysisComponentDiagnoseCategoriesDiagnoseCategoryCategoryItemsCategoryItemExplanations : TeaModel {
                                    [NameInMap("ActualIP")]
                                    [Validation(Required=false)]
                                    public string ActualIP { get; set; }

                                    [NameInMap("ActualPort")]
                                    [Validation(Required=false)]
                                    public long? ActualPort { get; set; }

                                    [NameInMap("ExpectIP")]
                                    [Validation(Required=false)]
                                    public string ExpectIP { get; set; }

                                    [NameInMap("ExpectPort")]
                                    [Validation(Required=false)]
                                    public long? ExpectPort { get; set; }

                                    [NameInMap("ExpireDate")]
                                    [Validation(Required=false)]
                                    public string ExpireDate { get; set; }

                                    [NameInMap("GroupId")]
                                    [Validation(Required=false)]
                                    public string GroupId { get; set; }

                                    [NameInMap("Header")]
                                    [Validation(Required=false)]
                                    public string Header { get; set; }

                                    [NameInMap("Ip")]
                                    [Validation(Required=false)]
                                    public string Ip { get; set; }

                                    [NameInMap("MissingFiles")]
                                    [Validation(Required=false)]
                                    public string MissingFiles { get; set; }

                                    [NameInMap("Netmask")]
                                    [Validation(Required=false)]
                                    public string Netmask { get; set; }

                                    [NameInMap("NetworkAclEntry")]
                                    [Validation(Required=false)]
                                    public DescribeNetworkInsightsAnalysisResultResponseBodyNetworkInsightsAnalysisComponentsNetworkInsightsAnalysisComponentDiagnoseCategoriesDiagnoseCategoryCategoryItemsCategoryItemExplanationsNetworkAclEntry NetworkAclEntry { get; set; }
                                    public class DescribeNetworkInsightsAnalysisResultResponseBodyNetworkInsightsAnalysisComponentsNetworkInsightsAnalysisComponentDiagnoseCategoriesDiagnoseCategoryCategoryItemsCategoryItemExplanationsNetworkAclEntry : TeaModel {
                                        [NameInMap("Direction")]
                                        [Validation(Required=false)]
                                        public string Direction { get; set; }

                                        [NameInMap("NetworkAclEntryId")]
                                        [Validation(Required=false)]
                                        public string NetworkAclEntryId { get; set; }

                                        [NameInMap("NetworkAclId")]
                                        [Validation(Required=false)]
                                        public string NetworkAclId { get; set; }

                                        [NameInMap("NetworkAclName")]
                                        [Validation(Required=false)]
                                        public string NetworkAclName { get; set; }

                                        [NameInMap("Policy")]
                                        [Validation(Required=false)]
                                        public string Policy { get; set; }

                                        [NameInMap("Port")]
                                        [Validation(Required=false)]
                                        public string Port { get; set; }

                                        [NameInMap("Protocol")]
                                        [Validation(Required=false)]
                                        public string Protocol { get; set; }

                                        [NameInMap("SourceCidrIp")]
                                        [Validation(Required=false)]
                                        public string SourceCidrIp { get; set; }

                                        [NameInMap("VpcId")]
                                        [Validation(Required=false)]
                                        public string VpcId { get; set; }

                                    }

                                    [NameInMap("NetworkInterfaceName")]
                                    [Validation(Required=false)]
                                    public string NetworkInterfaceName { get; set; }

                                    [NameInMap("Port")]
                                    [Validation(Required=false)]
                                    public long? Port { get; set; }

                                    [NameInMap("ProcessName")]
                                    [Validation(Required=false)]
                                    public string ProcessName { get; set; }

                                    [NameInMap("RelativeGroupIds")]
                                    [Validation(Required=false)]
                                    public DescribeNetworkInsightsAnalysisResultResponseBodyNetworkInsightsAnalysisComponentsNetworkInsightsAnalysisComponentDiagnoseCategoriesDiagnoseCategoryCategoryItemsCategoryItemExplanationsRelativeGroupIds RelativeGroupIds { get; set; }
                                    public class DescribeNetworkInsightsAnalysisResultResponseBodyNetworkInsightsAnalysisComponentsNetworkInsightsAnalysisComponentDiagnoseCategoriesDiagnoseCategoryCategoryItemsCategoryItemExplanationsRelativeGroupIds : TeaModel {
                                        [NameInMap("RelativeGroupId")]
                                        [Validation(Required=false)]
                                        public List<string> RelativeGroupId { get; set; }

                                    }

                                    [NameInMap("Rule")]
                                    [Validation(Required=false)]
                                    public string Rule { get; set; }

                                    [NameInMap("SecurityGroupAcl")]
                                    [Validation(Required=false)]
                                    public DescribeNetworkInsightsAnalysisResultResponseBodyNetworkInsightsAnalysisComponentsNetworkInsightsAnalysisComponentDiagnoseCategoriesDiagnoseCategoryCategoryItemsCategoryItemExplanationsSecurityGroupAcl SecurityGroupAcl { get; set; }
                                    public class DescribeNetworkInsightsAnalysisResultResponseBodyNetworkInsightsAnalysisComponentsNetworkInsightsAnalysisComponentDiagnoseCategoriesDiagnoseCategoryCategoryItemsCategoryItemExplanationsSecurityGroupAcl : TeaModel {
                                        [NameInMap("CreateTime")]
                                        [Validation(Required=false)]
                                        public string CreateTime { get; set; }

                                        [NameInMap("Description")]
                                        [Validation(Required=false)]
                                        public string Description { get; set; }

                                        [NameInMap("DestCidrIp")]
                                        [Validation(Required=false)]
                                        public string DestCidrIp { get; set; }

                                        [NameInMap("DestGroupId")]
                                        [Validation(Required=false)]
                                        public string DestGroupId { get; set; }

                                        [NameInMap("DestPortRange")]
                                        [Validation(Required=false)]
                                        public string DestPortRange { get; set; }

                                        [NameInMap("InnerAccessPolicy")]
                                        [Validation(Required=false)]
                                        public string InnerAccessPolicy { get; set; }

                                        [NameInMap("NicType")]
                                        [Validation(Required=false)]
                                        public string NicType { get; set; }

                                        [NameInMap("Policy")]
                                        [Validation(Required=false)]
                                        public string Policy { get; set; }

                                        [NameInMap("SourceCidrIp")]
                                        [Validation(Required=false)]
                                        public string SourceCidrIp { get; set; }

                                        [NameInMap("SourcePortRange")]
                                        [Validation(Required=false)]
                                        public string SourcePortRange { get; set; }

                                    }

                                    [NameInMap("TopProcesses")]
                                    [Validation(Required=false)]
                                    public DescribeNetworkInsightsAnalysisResultResponseBodyNetworkInsightsAnalysisComponentsNetworkInsightsAnalysisComponentDiagnoseCategoriesDiagnoseCategoryCategoryItemsCategoryItemExplanationsTopProcesses TopProcesses { get; set; }
                                    public class DescribeNetworkInsightsAnalysisResultResponseBodyNetworkInsightsAnalysisComponentsNetworkInsightsAnalysisComponentDiagnoseCategoriesDiagnoseCategoryCategoryItemsCategoryItemExplanationsTopProcesses : TeaModel {
                                        [NameInMap("TopProcess")]
                                        [Validation(Required=false)]
                                        public List<string> TopProcess { get; set; }

                                    }

                                    [NameInMap("UsePercent")]
                                    [Validation(Required=false)]
                                    public string UsePercent { get; set; }

                                }

                                [NameInMap("ItemName")]
                                [Validation(Required=false)]
                                public string ItemName { get; set; }

                                [NameInMap("Reachable")]
                                [Validation(Required=false)]
                                public string Reachable { get; set; }

                            }

                        }

                        [NameInMap("CategoryName")]
                        [Validation(Required=false)]
                        public string CategoryName { get; set; }

                        [NameInMap("Reachable")]
                        [Validation(Required=false)]
                        public string Reachable { get; set; }

                    }

                }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("NetworkAclEntry")]
                [Validation(Required=false)]
                public DescribeNetworkInsightsAnalysisResultResponseBodyNetworkInsightsAnalysisComponentsNetworkInsightsAnalysisComponentNetworkAclEntry NetworkAclEntry { get; set; }
                public class DescribeNetworkInsightsAnalysisResultResponseBodyNetworkInsightsAnalysisComponentsNetworkInsightsAnalysisComponentNetworkAclEntry : TeaModel {
                    [NameInMap("CreationTime")]
                    [Validation(Required=false)]
                    public string CreationTime { get; set; }

                    [NameInMap("DestinationCidrIp")]
                    [Validation(Required=false)]
                    public string DestinationCidrIp { get; set; }

                    [NameInMap("Direction")]
                    [Validation(Required=false)]
                    public string Direction { get; set; }

                    [NameInMap("NetworkAclEntryId")]
                    [Validation(Required=false)]
                    public string NetworkAclEntryId { get; set; }

                    [NameInMap("NetworkAclEntryName")]
                    [Validation(Required=false)]
                    public string NetworkAclEntryName { get; set; }

                    [NameInMap("NetworkAclId")]
                    [Validation(Required=false)]
                    public string NetworkAclId { get; set; }

                    [NameInMap("NetworkAclName")]
                    [Validation(Required=false)]
                    public string NetworkAclName { get; set; }

                    [NameInMap("Policy")]
                    [Validation(Required=false)]
                    public string Policy { get; set; }

                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public string Port { get; set; }

                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    [NameInMap("SourceCidrIp")]
                    [Validation(Required=false)]
                    public string SourceCidrIp { get; set; }

                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

                [NameInMap("Reachable")]
                [Validation(Required=false)]
                public string Reachable { get; set; }

                [NameInMap("RelativeGroupIds")]
                [Validation(Required=false)]
                public DescribeNetworkInsightsAnalysisResultResponseBodyNetworkInsightsAnalysisComponentsNetworkInsightsAnalysisComponentRelativeGroupIds RelativeGroupIds { get; set; }
                public class DescribeNetworkInsightsAnalysisResultResponseBodyNetworkInsightsAnalysisComponentsNetworkInsightsAnalysisComponentRelativeGroupIds : TeaModel {
                    [NameInMap("RelativeGroupId")]
                    [Validation(Required=false)]
                    public List<string> RelativeGroupId { get; set; }

                }

                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                [NameInMap("SecurityGroupAcl")]
                [Validation(Required=false)]
                public DescribeNetworkInsightsAnalysisResultResponseBodyNetworkInsightsAnalysisComponentsNetworkInsightsAnalysisComponentSecurityGroupAcl SecurityGroupAcl { get; set; }
                public class DescribeNetworkInsightsAnalysisResultResponseBodyNetworkInsightsAnalysisComponentsNetworkInsightsAnalysisComponentSecurityGroupAcl : TeaModel {
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("DestCidrIp")]
                    [Validation(Required=false)]
                    public string DestCidrIp { get; set; }

                    [NameInMap("DestGroupId")]
                    [Validation(Required=false)]
                    public string DestGroupId { get; set; }

                    [NameInMap("DestGroupName")]
                    [Validation(Required=false)]
                    public string DestGroupName { get; set; }

                    [NameInMap("DestPortRange")]
                    [Validation(Required=false)]
                    public string DestPortRange { get; set; }

                    [NameInMap("Direction")]
                    [Validation(Required=false)]
                    public string Direction { get; set; }

                    [NameInMap("InnerAccessPolicy")]
                    [Validation(Required=false)]
                    public string InnerAccessPolicy { get; set; }

                    [NameInMap("IpProtocol")]
                    [Validation(Required=false)]
                    public string IpProtocol { get; set; }

                    [NameInMap("Ipv6DestCidrIp")]
                    [Validation(Required=false)]
                    public string Ipv6DestCidrIp { get; set; }

                    [NameInMap("Ipv6SourceCidrIp")]
                    [Validation(Required=false)]
                    public string Ipv6SourceCidrIp { get; set; }

                    [NameInMap("NicType")]
                    [Validation(Required=false)]
                    public string NicType { get; set; }

                    [NameInMap("PermissionDescription")]
                    [Validation(Required=false)]
                    public string PermissionDescription { get; set; }

                    [NameInMap("Policy")]
                    [Validation(Required=false)]
                    public string Policy { get; set; }

                    [NameInMap("Priority")]
                    [Validation(Required=false)]
                    public string Priority { get; set; }

                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

                    [NameInMap("SourceCidrIp")]
                    [Validation(Required=false)]
                    public string SourceCidrIp { get; set; }

                    [NameInMap("SourceGroupId")]
                    [Validation(Required=false)]
                    public string SourceGroupId { get; set; }

                    [NameInMap("SourceGroupName")]
                    [Validation(Required=false)]
                    public string SourceGroupName { get; set; }

                    [NameInMap("SourcePortRange")]
                    [Validation(Required=false)]
                    public string SourcePortRange { get; set; }

                }

                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public int? Sequence { get; set; }

            }

        }

        [NameInMap("NetworkInsightsAnalysisId")]
        [Validation(Required=false)]
        public string NetworkInsightsAnalysisId { get; set; }

        [NameInMap("NetworkInsightsPathId")]
        [Validation(Required=false)]
        public string NetworkInsightsPathId { get; set; }

        [NameInMap("NetworkPathFound")]
        [Validation(Required=false)]
        public string NetworkPathFound { get; set; }

        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
