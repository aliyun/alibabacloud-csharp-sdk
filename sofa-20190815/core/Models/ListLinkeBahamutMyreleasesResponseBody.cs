// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListLinkeBahamutMyreleasesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListLinkeBahamutMyreleasesResponseBodyResult> Result { get; set; }
        public class ListLinkeBahamutMyreleasesResponseBodyResult : TeaModel {
            [NameInMap("AfterFastDevDate")]
            [Validation(Required=false)]
            public bool? AfterFastDevDate { get; set; }

            [NameInMap("AoneReleaseId")]
            [Validation(Required=false)]
            public string AoneReleaseId { get; set; }

            [NameInMap("Attachable")]
            [Validation(Required=false)]
            public bool? Attachable { get; set; }

            [NameInMap("BetaRelease")]
            [Validation(Required=false)]
            public bool? BetaRelease { get; set; }

            [NameInMap("ContainPreInMultiEnv")]
            [Validation(Required=false)]
            public bool? ContainPreInMultiEnv { get; set; }

            [NameInMap("Created")]
            [Validation(Required=false)]
            public long? Created { get; set; }

            [NameInMap("DailyRelease")]
            [Validation(Required=false)]
            public bool? DailyRelease { get; set; }

            [NameInMap("Deadlines")]
            [Validation(Required=false)]
            public string Deadlines { get; set; }

            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }

            [NameInMap("Dependencies")]
            [Validation(Required=false)]
            public string Dependencies { get; set; }

            [NameInMap("ExternalId")]
            [Validation(Required=false)]
            public string ExternalId { get; set; }

            [NameInMap("GreenChannelId")]
            [Validation(Required=false)]
            public string GreenChannelId { get; set; }

            [NameInMap("GreenChannelName")]
            [Validation(Required=false)]
            public string GreenChannelName { get; set; }

            [NameInMap("GreenChannelPortalUrl")]
            [Validation(Required=false)]
            public string GreenChannelPortalUrl { get; set; }

            [NameInMap("HasCreatedAppReleaseDetail")]
            [Validation(Required=false)]
            public bool? HasCreatedAppReleaseDetail { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("IterationType")]
            [Validation(Required=false)]
            public string IterationType { get; set; }

            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public long? LastModified { get; set; }

            [NameInMap("MergeStartTime")]
            [Validation(Required=false)]
            public long? MergeStartTime { get; set; }

            [NameInMap("MultiEnvRelease")]
            [Validation(Required=false)]
            public bool? MultiEnvRelease { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ReleaseDate")]
            [Validation(Required=false)]
            public long? ReleaseDate { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TagAndMergeMasterWhenEmergency")]
            [Validation(Required=false)]
            public bool? TagAndMergeMasterWhenEmergency { get; set; }

            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            [NameInMap("Ticket")]
            [Validation(Required=false)]
            public string Ticket { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("WindowRelease")]
            [Validation(Required=false)]
            public bool? WindowRelease { get; set; }

            [NameInMap("DelAppMetaIds")]
            [Validation(Required=false)]
            public List<string> DelAppMetaIds { get; set; }

            [NameInMap("Managers")]
            [Validation(Required=false)]
            public List<ListLinkeBahamutMyreleasesResponseBodyResultManagers> Managers { get; set; }
            public class ListLinkeBahamutMyreleasesResponseBodyResultManagers : TeaModel {
                [NameInMap("Account")]
                [Validation(Required=false)]
                public string Account { get; set; }

                [NameInMap("Created")]
                [Validation(Required=false)]
                public long? Created { get; set; }

                [NameInMap("Customer")]
                [Validation(Required=false)]
                public string Customer { get; set; }

                [NameInMap("Deleted")]
                [Validation(Required=false)]
                public bool? Deleted { get; set; }

                [NameInMap("Department")]
                [Validation(Required=false)]
                public string Department { get; set; }

                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("EmpId")]
                [Validation(Required=false)]
                public string EmpId { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("LastLogin")]
                [Validation(Required=false)]
                public long? LastLogin { get; set; }

                [NameInMap("LastModified")]
                [Validation(Required=false)]
                public long? LastModified { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Nick")]
                [Validation(Required=false)]
                public string Nick { get; set; }

                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

                [NameInMap("UniqueId")]
                [Validation(Required=false)]
                public string UniqueId { get; set; }

                [NameInMap("Ww")]
                [Validation(Required=false)]
                public string Ww { get; set; }

                [NameInMap("Tenants")]
                [Validation(Required=false)]
                public List<string> Tenants { get; set; }

            }

            [NameInMap("Stages")]
            [Validation(Required=false)]
            public List<ListLinkeBahamutMyreleasesResponseBodyResultStages> Stages { get; set; }
            public class ListLinkeBahamutMyreleasesResponseBodyResultStages : TeaModel {
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ReleaseStatus")]
                [Validation(Required=false)]
                public string ReleaseStatus { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("TenantReleaseInfos")]
            [Validation(Required=false)]
            public List<ListLinkeBahamutMyreleasesResponseBodyResultTenantReleaseInfos> TenantReleaseInfos { get; set; }
            public class ListLinkeBahamutMyreleasesResponseBodyResultTenantReleaseInfos : TeaModel {
                [NameInMap("CloudTenantId")]
                [Validation(Required=false)]
                public string CloudTenantId { get; set; }

                [NameInMap("CloudTenantName")]
                [Validation(Required=false)]
                public string CloudTenantName { get; set; }

                [NameInMap("PreEnvReleaseInfo")]
                [Validation(Required=false)]
                public ListLinkeBahamutMyreleasesResponseBodyResultTenantReleaseInfosPreEnvReleaseInfo PreEnvReleaseInfo { get; set; }
                public class ListLinkeBahamutMyreleasesResponseBodyResultTenantReleaseInfosPreEnvReleaseInfo : TeaModel {
                    [NameInMap("EnvId")]
                    [Validation(Required=false)]
                    public string EnvId { get; set; }
                    [NameInMap("Info")]
                    [Validation(Required=false)]
                    public string Info { get; set; }
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }
                    [NameInMap("Ticket")]
                    [Validation(Required=false)]
                    public string Ticket { get; set; }
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }
                    [NameInMap("WorkspaceId")]
                    [Validation(Required=false)]
                    public string WorkspaceId { get; set; }
                    [NameInMap("WorkspaceName")]
                    [Validation(Required=false)]
                    public string WorkspaceName { get; set; }
                };

                [NameInMap("ProdEnvReleaseInfo")]
                [Validation(Required=false)]
                public ListLinkeBahamutMyreleasesResponseBodyResultTenantReleaseInfosProdEnvReleaseInfo ProdEnvReleaseInfo { get; set; }
                public class ListLinkeBahamutMyreleasesResponseBodyResultTenantReleaseInfosProdEnvReleaseInfo : TeaModel {
                    [NameInMap("EnvId")]
                    [Validation(Required=false)]
                    public string EnvId { get; set; }
                    [NameInMap("Info")]
                    [Validation(Required=false)]
                    public string Info { get; set; }
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }
                    [NameInMap("Ticket")]
                    [Validation(Required=false)]
                    public string Ticket { get; set; }
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }
                    [NameInMap("WorkspaceId")]
                    [Validation(Required=false)]
                    public string WorkspaceId { get; set; }
                    [NameInMap("WorkspaceName")]
                    [Validation(Required=false)]
                    public string WorkspaceName { get; set; }
                };

            }

            [NameInMap("AppGroup")]
            [Validation(Required=false)]
            public ListLinkeBahamutMyreleasesResponseBodyResultAppGroup AppGroup { get; set; }
            public class ListLinkeBahamutMyreleasesResponseBodyResultAppGroup : TeaModel {
                [NameInMap("Created")]
                [Validation(Required=false)]
                public long? Created { get; set; }
                [NameInMap("Deleted")]
                [Validation(Required=false)]
                public bool? Deleted { get; set; }
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }
                [NameInMap("LastModified")]
                [Validation(Required=false)]
                public long? LastModified { get; set; }
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }
                [NameInMap("AppList")]
                [Validation(Required=false)]
                public List<string> AppList { get; set; }
                [NameInMap("Admins")]
                [Validation(Required=false)]
                public List<ListLinkeBahamutMyreleasesResponseBodyResultAppGroupAdmins> Admins { get; set; }
                public class ListLinkeBahamutMyreleasesResponseBodyResultAppGroupAdmins : TeaModel {
                    public string Account { get; set; }
                    public long? Created { get; set; }
                    public string Customer { get; set; }
                    public bool? Deleted { get; set; }
                    public string Department { get; set; }
                    public string Email { get; set; }
                    public string EmpId { get; set; }
                    public string Id { get; set; }
                    public long? LastLogin { get; set; }
                    public long? LastModified { get; set; }
                    public string Name { get; set; }
                    public string Nick { get; set; }
                    public string Uid { get; set; }
                    public string UniqueId { get; set; }
                    public string Ww { get; set; }
                    public List<string> Tenants { get; set; }
                }
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public ListLinkeBahamutMyreleasesResponseBodyResultAppGroupCreator Creator { get; set; }
                public class ListLinkeBahamutMyreleasesResponseBodyResultAppGroupCreator : TeaModel {
                    [NameInMap("Account")]
                    [Validation(Required=false)]
                    public string Account { get; set; }

                    [NameInMap("Created")]
                    [Validation(Required=false)]
                    public long? Created { get; set; }

                    [NameInMap("Customer")]
                    [Validation(Required=false)]
                    public string Customer { get; set; }

                    [NameInMap("Deleted")]
                    [Validation(Required=false)]
                    public bool? Deleted { get; set; }

                    [NameInMap("Department")]
                    [Validation(Required=false)]
                    public string Department { get; set; }

                    [NameInMap("Email")]
                    [Validation(Required=false)]
                    public string Email { get; set; }

                    [NameInMap("EmpId")]
                    [Validation(Required=false)]
                    public string EmpId { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("LastLogin")]
                    [Validation(Required=false)]
                    public long? LastLogin { get; set; }

                    [NameInMap("LastModified")]
                    [Validation(Required=false)]
                    public long? LastModified { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Nick")]
                    [Validation(Required=false)]
                    public string Nick { get; set; }

                    [NameInMap("Uid")]
                    [Validation(Required=false)]
                    public string Uid { get; set; }

                    [NameInMap("UniqueId")]
                    [Validation(Required=false)]
                    public string UniqueId { get; set; }

                    [NameInMap("Ww")]
                    [Validation(Required=false)]
                    public string Ww { get; set; }

                    [NameInMap("Tenants")]
                    [Validation(Required=false)]
                    public List<string> Tenants { get; set; }

                }
                [NameInMap("ModifiyUser")]
                [Validation(Required=false)]
                public ListLinkeBahamutMyreleasesResponseBodyResultAppGroupModifiyUser ModifiyUser { get; set; }
                public class ListLinkeBahamutMyreleasesResponseBodyResultAppGroupModifiyUser : TeaModel {
                    [NameInMap("Account")]
                    [Validation(Required=false)]
                    public string Account { get; set; }

                    [NameInMap("Created")]
                    [Validation(Required=false)]
                    public long? Created { get; set; }

                    [NameInMap("Customer")]
                    [Validation(Required=false)]
                    public string Customer { get; set; }

                    [NameInMap("Deleted")]
                    [Validation(Required=false)]
                    public bool? Deleted { get; set; }

                    [NameInMap("Department")]
                    [Validation(Required=false)]
                    public string Department { get; set; }

                    [NameInMap("Email")]
                    [Validation(Required=false)]
                    public string Email { get; set; }

                    [NameInMap("EmpId")]
                    [Validation(Required=false)]
                    public string EmpId { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("LastLogin")]
                    [Validation(Required=false)]
                    public long? LastLogin { get; set; }

                    [NameInMap("LastModified")]
                    [Validation(Required=false)]
                    public long? LastModified { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Nick")]
                    [Validation(Required=false)]
                    public string Nick { get; set; }

                    [NameInMap("Uid")]
                    [Validation(Required=false)]
                    public string Uid { get; set; }

                    [NameInMap("UniqueId")]
                    [Validation(Required=false)]
                    public string UniqueId { get; set; }

                    [NameInMap("Ww")]
                    [Validation(Required=false)]
                    public string Ww { get; set; }

                    [NameInMap("Tenants")]
                    [Validation(Required=false)]
                    public List<string> Tenants { get; set; }

                }
                [NameInMap("Tenant")]
                [Validation(Required=false)]
                public ListLinkeBahamutMyreleasesResponseBodyResultAppGroupTenant Tenant { get; set; }
                public class ListLinkeBahamutMyreleasesResponseBodyResultAppGroupTenant : TeaModel {
                    [NameInMap("AccessKey")]
                    [Validation(Required=false)]
                    public string AccessKey { get; set; }

                    [NameInMap("AccessSecret")]
                    [Validation(Required=false)]
                    public string AccessSecret { get; set; }

                    [NameInMap("AccessToken")]
                    [Validation(Required=false)]
                    public string AccessToken { get; set; }

                    [NameInMap("Created")]
                    [Validation(Required=false)]
                    public long? Created { get; set; }

                    [NameInMap("Customer")]
                    [Validation(Required=false)]
                    public string Customer { get; set; }

                    [NameInMap("Deleted")]
                    [Validation(Required=false)]
                    public bool? Deleted { get; set; }

                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    [NameInMap("DropQualityApprovslDate")]
                    [Validation(Required=false)]
                    public long? DropQualityApprovslDate { get; set; }

                    [NameInMap("EndPoint")]
                    [Validation(Required=false)]
                    public string EndPoint { get; set; }

                    [NameInMap("ExternalId")]
                    [Validation(Required=false)]
                    public string ExternalId { get; set; }

                    [NameInMap("FromAliyun")]
                    [Validation(Required=false)]
                    public bool? FromAliyun { get; set; }

                    [NameInMap("HaveNotInited")]
                    [Validation(Required=false)]
                    public bool? HaveNotInited { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("InitStep")]
                    [Validation(Required=false)]
                    public string InitStep { get; set; }

                    [NameInMap("LastModified")]
                    [Validation(Required=false)]
                    public long? LastModified { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("OpenMyBankControl")]
                    [Validation(Required=false)]
                    public bool? OpenMyBankControl { get; set; }

                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    [NameInMap("UseConfigTypes")]
                    [Validation(Required=false)]
                    public bool? UseConfigTypes { get; set; }

                    [NameInMap("YunYou")]
                    [Validation(Required=false)]
                    public bool? YunYou { get; set; }

                    [NameInMap("AuthorizedUsers")]
                    [Validation(Required=false)]
                    public List<string> AuthorizedUsers { get; set; }

                    [NameInMap("ConfigTypes")]
                    [Validation(Required=false)]
                    public List<string> ConfigTypes { get; set; }

                    [NameInMap("SitMergeTrialList")]
                    [Validation(Required=false)]
                    public List<string> SitMergeTrialList { get; set; }

                    [NameInMap("TrialList")]
                    [Validation(Required=false)]
                    public List<string> TrialList { get; set; }

                    [NameInMap("ZoneModeList")]
                    [Validation(Required=false)]
                    public List<string> ZoneModeList { get; set; }

                }
            };

            [NameInMap("Creator")]
            [Validation(Required=false)]
            public ListLinkeBahamutMyreleasesResponseBodyResultCreator Creator { get; set; }
            public class ListLinkeBahamutMyreleasesResponseBodyResultCreator : TeaModel {
                [NameInMap("Account")]
                [Validation(Required=false)]
                public string Account { get; set; }
                [NameInMap("Created")]
                [Validation(Required=false)]
                public long? Created { get; set; }
                [NameInMap("Customer")]
                [Validation(Required=false)]
                public string Customer { get; set; }
                [NameInMap("Deleted")]
                [Validation(Required=false)]
                public bool? Deleted { get; set; }
                [NameInMap("Department")]
                [Validation(Required=false)]
                public string Department { get; set; }
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }
                [NameInMap("EmpId")]
                [Validation(Required=false)]
                public string EmpId { get; set; }
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }
                [NameInMap("LastLogin")]
                [Validation(Required=false)]
                public long? LastLogin { get; set; }
                [NameInMap("LastModified")]
                [Validation(Required=false)]
                public long? LastModified { get; set; }
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }
                [NameInMap("Nick")]
                [Validation(Required=false)]
                public string Nick { get; set; }
                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }
                [NameInMap("UniqueId")]
                [Validation(Required=false)]
                public string UniqueId { get; set; }
                [NameInMap("Ww")]
                [Validation(Required=false)]
                public string Ww { get; set; }
                [NameInMap("Tenants")]
                [Validation(Required=false)]
                public List<string> Tenants { get; set; }
            };

        }

    }

}
