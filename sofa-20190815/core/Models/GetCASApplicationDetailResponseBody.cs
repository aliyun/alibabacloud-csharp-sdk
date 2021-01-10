// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetCASApplicationDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCASApplicationDetailResponseBodyData Data { get; set; }
        public class GetCASApplicationDetailResponseBodyData : TeaModel {
            [NameInMap("AppDomainId")]
            [Validation(Required=false)]
            public string AppDomainId { get; set; }
            [NameInMap("AppDomainName")]
            [Validation(Required=false)]
            public string AppDomainName { get; set; }
            [NameInMap("AppLevelName")]
            [Validation(Required=false)]
            public string AppLevelName { get; set; }
            [NameInMap("BuildpackVersion")]
            [Validation(Required=false)]
            public string BuildpackVersion { get; set; }
            [NameInMap("ChineseName")]
            [Validation(Required=false)]
            public string ChineseName { get; set; }
            [NameInMap("ContainerCount")]
            [Validation(Required=false)]
            public long? ContainerCount { get; set; }
            [NameInMap("DatabaseCount")]
            [Validation(Required=false)]
            public long? DatabaseCount { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("ExtraParams")]
            [Validation(Required=false)]
            public string ExtraParams { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("IsService")]
            [Validation(Required=false)]
            public bool? IsService { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("OcsCount")]
            [Validation(Required=false)]
            public long? OcsCount { get; set; }
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }
            [NameInMap("OwnerName")]
            [Validation(Required=false)]
            public string OwnerName { get; set; }
            [NameInMap("PackageCount")]
            [Validation(Required=false)]
            public long? PackageCount { get; set; }
            [NameInMap("RealOwnerName")]
            [Validation(Required=false)]
            public string RealOwnerName { get; set; }
            [NameInMap("SlbCount")]
            [Validation(Required=false)]
            public long? SlbCount { get; set; }
            [NameInMap("StackId")]
            [Validation(Required=false)]
            public string StackId { get; set; }
            [NameInMap("StackName")]
            [Validation(Required=false)]
            public string StackName { get; set; }
            [NameInMap("StackVersion")]
            [Validation(Required=false)]
            public string StackVersion { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }
            [NameInMap("UtcCreate")]
            [Validation(Required=false)]
            public string UtcCreate { get; set; }
            [NameInMap("UtcModified")]
            [Validation(Required=false)]
            public string UtcModified { get; set; }
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }
            [NameInMap("DomainNames")]
            [Validation(Required=false)]
            public List<string> DomainNames { get; set; }
            [NameInMap("AppExtraInfos")]
            [Validation(Required=false)]
            public List<GetCASApplicationDetailResponseBodyDataAppExtraInfos> AppExtraInfos { get; set; }
            public class GetCASApplicationDetailResponseBodyDataAppExtraInfos : TeaModel {
                public string AppExtrainfoId { get; set; }
                public string AppId { get; set; }
                public string Description { get; set; }
                public string Id { get; set; }
                public string Name { get; set; }
                public string TemplateDataId { get; set; }
                public string TemplateId { get; set; }
                public string Type { get; set; }
                public string UtcCreate { get; set; }
                public string UtcModified { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("AppLevel")]
            [Validation(Required=false)]
            public GetCASApplicationDetailResponseBodyDataAppLevel AppLevel { get; set; }
            public class GetCASApplicationDetailResponseBodyDataAppLevel : TeaModel {
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                [NameInMap("UtcCreate")]
                [Validation(Required=false)]
                public string UtcCreate { get; set; }

                [NameInMap("UtcModified")]
                [Validation(Required=false)]
                public string UtcModified { get; set; }

            }
            [NameInMap("AppOwner")]
            [Validation(Required=false)]
            public GetCASApplicationDetailResponseBodyDataAppOwner AppOwner { get; set; }
            public class GetCASApplicationDetailResponseBodyDataAppOwner : TeaModel {
                [NameInMap("BackupDevArchitects")]
                [Validation(Required=false)]
                public List<GetCASApplicationDetailResponseBodyDataAppOwnerBackupDevArchitects> BackupDevArchitects { get; set; }
                public class GetCASApplicationDetailResponseBodyDataAppOwnerBackupDevArchitects : TeaModel {
                    [NameInMap("CustomerId")]
                    [Validation(Required=false)]
                    public string CustomerId { get; set; }

                    [NameInMap("Email")]
                    [Validation(Required=false)]
                    public string Email { get; set; }

                    [NameInMap("EnName")]
                    [Validation(Required=false)]
                    public string EnName { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("ImAccount")]
                    [Validation(Required=false)]
                    public string ImAccount { get; set; }

                    [NameInMap("LastLogonTime")]
                    [Validation(Required=false)]
                    public string LastLogonTime { get; set; }

                    [NameInMap("LoginName")]
                    [Validation(Required=false)]
                    public string LoginName { get; set; }

                    [NameInMap("Mobile")]
                    [Validation(Required=false)]
                    public string Mobile { get; set; }

                    [NameInMap("Nation")]
                    [Validation(Required=false)]
                    public string Nation { get; set; }

                    [NameInMap("NationCountry")]
                    [Validation(Required=false)]
                    public string NationCountry { get; set; }

                    [NameInMap("NickName")]
                    [Validation(Required=false)]
                    public string NickName { get; set; }

                    [NameInMap("PersonalPhoto")]
                    [Validation(Required=false)]
                    public string PersonalPhoto { get; set; }

                    [NameInMap("Phone")]
                    [Validation(Required=false)]
                    public string Phone { get; set; }

                    [NameInMap("RealName")]
                    [Validation(Required=false)]
                    public string RealName { get; set; }

                    [NameInMap("Sex")]
                    [Validation(Required=false)]
                    public string Sex { get; set; }

                    [NameInMap("SourceSystem")]
                    [Validation(Required=false)]
                    public string SourceSystem { get; set; }

                    [NameInMap("SourceUserId")]
                    [Validation(Required=false)]
                    public string SourceUserId { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("WorkNo")]
                    [Validation(Required=false)]
                    public string WorkNo { get; set; }

                }

                [NameInMap("BackupDevOwners")]
                [Validation(Required=false)]
                public List<GetCASApplicationDetailResponseBodyDataAppOwnerBackupDevOwners> BackupDevOwners { get; set; }
                public class GetCASApplicationDetailResponseBodyDataAppOwnerBackupDevOwners : TeaModel {
                    [NameInMap("CustomerId")]
                    [Validation(Required=false)]
                    public string CustomerId { get; set; }

                    [NameInMap("Email")]
                    [Validation(Required=false)]
                    public string Email { get; set; }

                    [NameInMap("EnName")]
                    [Validation(Required=false)]
                    public string EnName { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("ImAccount")]
                    [Validation(Required=false)]
                    public string ImAccount { get; set; }

                    [NameInMap("LastLogonTime")]
                    [Validation(Required=false)]
                    public string LastLogonTime { get; set; }

                    [NameInMap("LoginName")]
                    [Validation(Required=false)]
                    public string LoginName { get; set; }

                    [NameInMap("Mobile")]
                    [Validation(Required=false)]
                    public string Mobile { get; set; }

                    [NameInMap("Nation")]
                    [Validation(Required=false)]
                    public string Nation { get; set; }

                    [NameInMap("NationCountry")]
                    [Validation(Required=false)]
                    public string NationCountry { get; set; }

                    [NameInMap("NickName")]
                    [Validation(Required=false)]
                    public string NickName { get; set; }

                    [NameInMap("PersonalPhoto")]
                    [Validation(Required=false)]
                    public string PersonalPhoto { get; set; }

                    [NameInMap("Phone")]
                    [Validation(Required=false)]
                    public string Phone { get; set; }

                    [NameInMap("RealName")]
                    [Validation(Required=false)]
                    public string RealName { get; set; }

                    [NameInMap("Sex")]
                    [Validation(Required=false)]
                    public string Sex { get; set; }

                    [NameInMap("SourceSystem")]
                    [Validation(Required=false)]
                    public string SourceSystem { get; set; }

                    [NameInMap("SourceUserId")]
                    [Validation(Required=false)]
                    public string SourceUserId { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("WorkNo")]
                    [Validation(Required=false)]
                    public string WorkNo { get; set; }

                }

                [NameInMap("BackupOpses")]
                [Validation(Required=false)]
                public List<GetCASApplicationDetailResponseBodyDataAppOwnerBackupOpses> BackupOpses { get; set; }
                public class GetCASApplicationDetailResponseBodyDataAppOwnerBackupOpses : TeaModel {
                    [NameInMap("CustomerId")]
                    [Validation(Required=false)]
                    public string CustomerId { get; set; }

                    [NameInMap("Email")]
                    [Validation(Required=false)]
                    public string Email { get; set; }

                    [NameInMap("EnName")]
                    [Validation(Required=false)]
                    public string EnName { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("ImAccount")]
                    [Validation(Required=false)]
                    public string ImAccount { get; set; }

                    [NameInMap("LastLogonTime")]
                    [Validation(Required=false)]
                    public string LastLogonTime { get; set; }

                    [NameInMap("LoginName")]
                    [Validation(Required=false)]
                    public string LoginName { get; set; }

                    [NameInMap("Mobile")]
                    [Validation(Required=false)]
                    public string Mobile { get; set; }

                    [NameInMap("Nation")]
                    [Validation(Required=false)]
                    public string Nation { get; set; }

                    [NameInMap("NationCountry")]
                    [Validation(Required=false)]
                    public string NationCountry { get; set; }

                    [NameInMap("NickName")]
                    [Validation(Required=false)]
                    public string NickName { get; set; }

                    [NameInMap("PersonalPhoto")]
                    [Validation(Required=false)]
                    public string PersonalPhoto { get; set; }

                    [NameInMap("Phone")]
                    [Validation(Required=false)]
                    public string Phone { get; set; }

                    [NameInMap("RealName")]
                    [Validation(Required=false)]
                    public string RealName { get; set; }

                    [NameInMap("Sex")]
                    [Validation(Required=false)]
                    public string Sex { get; set; }

                    [NameInMap("SourceSystem")]
                    [Validation(Required=false)]
                    public string SourceSystem { get; set; }

                    [NameInMap("SourceUserId")]
                    [Validation(Required=false)]
                    public string SourceUserId { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("WorkNo")]
                    [Validation(Required=false)]
                    public string WorkNo { get; set; }

                }

                [NameInMap("BackupTestArchitects")]
                [Validation(Required=false)]
                public List<GetCASApplicationDetailResponseBodyDataAppOwnerBackupTestArchitects> BackupTestArchitects { get; set; }
                public class GetCASApplicationDetailResponseBodyDataAppOwnerBackupTestArchitects : TeaModel {
                    [NameInMap("CustomerId")]
                    [Validation(Required=false)]
                    public string CustomerId { get; set; }

                    [NameInMap("Email")]
                    [Validation(Required=false)]
                    public string Email { get; set; }

                    [NameInMap("EnName")]
                    [Validation(Required=false)]
                    public string EnName { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("ImAccount")]
                    [Validation(Required=false)]
                    public string ImAccount { get; set; }

                    [NameInMap("LastLogonTime")]
                    [Validation(Required=false)]
                    public string LastLogonTime { get; set; }

                    [NameInMap("LoginName")]
                    [Validation(Required=false)]
                    public string LoginName { get; set; }

                    [NameInMap("Mobile")]
                    [Validation(Required=false)]
                    public string Mobile { get; set; }

                    [NameInMap("Nation")]
                    [Validation(Required=false)]
                    public string Nation { get; set; }

                    [NameInMap("NationCountry")]
                    [Validation(Required=false)]
                    public string NationCountry { get; set; }

                    [NameInMap("NickName")]
                    [Validation(Required=false)]
                    public string NickName { get; set; }

                    [NameInMap("PersonalPhoto")]
                    [Validation(Required=false)]
                    public string PersonalPhoto { get; set; }

                    [NameInMap("Phone")]
                    [Validation(Required=false)]
                    public string Phone { get; set; }

                    [NameInMap("RealName")]
                    [Validation(Required=false)]
                    public string RealName { get; set; }

                    [NameInMap("Sex")]
                    [Validation(Required=false)]
                    public string Sex { get; set; }

                    [NameInMap("SourceSystem")]
                    [Validation(Required=false)]
                    public string SourceSystem { get; set; }

                    [NameInMap("SourceUserId")]
                    [Validation(Required=false)]
                    public string SourceUserId { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("WorkNo")]
                    [Validation(Required=false)]
                    public string WorkNo { get; set; }

                }

                [NameInMap("BackupTestOwners")]
                [Validation(Required=false)]
                public List<GetCASApplicationDetailResponseBodyDataAppOwnerBackupTestOwners> BackupTestOwners { get; set; }
                public class GetCASApplicationDetailResponseBodyDataAppOwnerBackupTestOwners : TeaModel {
                    [NameInMap("CustomerId")]
                    [Validation(Required=false)]
                    public string CustomerId { get; set; }

                    [NameInMap("Email")]
                    [Validation(Required=false)]
                    public string Email { get; set; }

                    [NameInMap("EnName")]
                    [Validation(Required=false)]
                    public string EnName { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("ImAccount")]
                    [Validation(Required=false)]
                    public string ImAccount { get; set; }

                    [NameInMap("LastLogonTime")]
                    [Validation(Required=false)]
                    public string LastLogonTime { get; set; }

                    [NameInMap("LoginName")]
                    [Validation(Required=false)]
                    public string LoginName { get; set; }

                    [NameInMap("Mobile")]
                    [Validation(Required=false)]
                    public string Mobile { get; set; }

                    [NameInMap("Nation")]
                    [Validation(Required=false)]
                    public string Nation { get; set; }

                    [NameInMap("NationCountry")]
                    [Validation(Required=false)]
                    public string NationCountry { get; set; }

                    [NameInMap("NickName")]
                    [Validation(Required=false)]
                    public string NickName { get; set; }

                    [NameInMap("PersonalPhoto")]
                    [Validation(Required=false)]
                    public string PersonalPhoto { get; set; }

                    [NameInMap("Phone")]
                    [Validation(Required=false)]
                    public string Phone { get; set; }

                    [NameInMap("RealName")]
                    [Validation(Required=false)]
                    public string RealName { get; set; }

                    [NameInMap("Sex")]
                    [Validation(Required=false)]
                    public string Sex { get; set; }

                    [NameInMap("SourceSystem")]
                    [Validation(Required=false)]
                    public string SourceSystem { get; set; }

                    [NameInMap("SourceUserId")]
                    [Validation(Required=false)]
                    public string SourceUserId { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("WorkNo")]
                    [Validation(Required=false)]
                    public string WorkNo { get; set; }

                }

                [NameInMap("DevArchitect")]
                [Validation(Required=false)]
                public GetCASApplicationDetailResponseBodyDataAppOwnerDevArchitect DevArchitect { get; set; }
                public class GetCASApplicationDetailResponseBodyDataAppOwnerDevArchitect : TeaModel {
                    [NameInMap("CustomerId")]
                    [Validation(Required=false)]
                    public string CustomerId { get; set; }
                    [NameInMap("Email")]
                    [Validation(Required=false)]
                    public string Email { get; set; }
                    [NameInMap("EnName")]
                    [Validation(Required=false)]
                    public string EnName { get; set; }
                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }
                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }
                    [NameInMap("ImAccount")]
                    [Validation(Required=false)]
                    public string ImAccount { get; set; }
                    [NameInMap("LastLogonTime")]
                    [Validation(Required=false)]
                    public string LastLogonTime { get; set; }
                    [NameInMap("LoginName")]
                    [Validation(Required=false)]
                    public string LoginName { get; set; }
                    [NameInMap("Mobile")]
                    [Validation(Required=false)]
                    public string Mobile { get; set; }
                    [NameInMap("Nation")]
                    [Validation(Required=false)]
                    public string Nation { get; set; }
                    [NameInMap("NationCountry")]
                    [Validation(Required=false)]
                    public string NationCountry { get; set; }
                    [NameInMap("NickName")]
                    [Validation(Required=false)]
                    public string NickName { get; set; }
                    [NameInMap("PersonalPhoto")]
                    [Validation(Required=false)]
                    public string PersonalPhoto { get; set; }
                    [NameInMap("Phone")]
                    [Validation(Required=false)]
                    public string Phone { get; set; }
                    [NameInMap("RealName")]
                    [Validation(Required=false)]
                    public string RealName { get; set; }
                    [NameInMap("Sex")]
                    [Validation(Required=false)]
                    public string Sex { get; set; }
                    [NameInMap("SourceSystem")]
                    [Validation(Required=false)]
                    public string SourceSystem { get; set; }
                    [NameInMap("SourceUserId")]
                    [Validation(Required=false)]
                    public string SourceUserId { get; set; }
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }
                    [NameInMap("WorkNo")]
                    [Validation(Required=false)]
                    public string WorkNo { get; set; }
                };

                [NameInMap("DevOwner")]
                [Validation(Required=false)]
                public GetCASApplicationDetailResponseBodyDataAppOwnerDevOwner DevOwner { get; set; }
                public class GetCASApplicationDetailResponseBodyDataAppOwnerDevOwner : TeaModel {
                    [NameInMap("CustomerId")]
                    [Validation(Required=false)]
                    public string CustomerId { get; set; }
                    [NameInMap("Email")]
                    [Validation(Required=false)]
                    public string Email { get; set; }
                    [NameInMap("EnName")]
                    [Validation(Required=false)]
                    public string EnName { get; set; }
                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }
                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }
                    [NameInMap("ImAccount")]
                    [Validation(Required=false)]
                    public string ImAccount { get; set; }
                    [NameInMap("LastLogonTime")]
                    [Validation(Required=false)]
                    public string LastLogonTime { get; set; }
                    [NameInMap("LoginName")]
                    [Validation(Required=false)]
                    public string LoginName { get; set; }
                    [NameInMap("Mobile")]
                    [Validation(Required=false)]
                    public string Mobile { get; set; }
                    [NameInMap("Nation")]
                    [Validation(Required=false)]
                    public string Nation { get; set; }
                    [NameInMap("NationCountry")]
                    [Validation(Required=false)]
                    public string NationCountry { get; set; }
                    [NameInMap("NickName")]
                    [Validation(Required=false)]
                    public string NickName { get; set; }
                    [NameInMap("PersonalPhoto")]
                    [Validation(Required=false)]
                    public string PersonalPhoto { get; set; }
                    [NameInMap("Phone")]
                    [Validation(Required=false)]
                    public string Phone { get; set; }
                    [NameInMap("RealName")]
                    [Validation(Required=false)]
                    public string RealName { get; set; }
                    [NameInMap("Sex")]
                    [Validation(Required=false)]
                    public string Sex { get; set; }
                    [NameInMap("SourceSystem")]
                    [Validation(Required=false)]
                    public string SourceSystem { get; set; }
                    [NameInMap("SourceUserId")]
                    [Validation(Required=false)]
                    public string SourceUserId { get; set; }
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }
                    [NameInMap("WorkNo")]
                    [Validation(Required=false)]
                    public string WorkNo { get; set; }
                };

                [NameInMap("Ops")]
                [Validation(Required=false)]
                public GetCASApplicationDetailResponseBodyDataAppOwnerOps Ops { get; set; }
                public class GetCASApplicationDetailResponseBodyDataAppOwnerOps : TeaModel {
                    [NameInMap("CustomerId")]
                    [Validation(Required=false)]
                    public string CustomerId { get; set; }
                    [NameInMap("Email")]
                    [Validation(Required=false)]
                    public string Email { get; set; }
                    [NameInMap("EnName")]
                    [Validation(Required=false)]
                    public string EnName { get; set; }
                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }
                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }
                    [NameInMap("ImAccount")]
                    [Validation(Required=false)]
                    public string ImAccount { get; set; }
                    [NameInMap("LastLogonTime")]
                    [Validation(Required=false)]
                    public string LastLogonTime { get; set; }
                    [NameInMap("LoginName")]
                    [Validation(Required=false)]
                    public string LoginName { get; set; }
                    [NameInMap("Mobile")]
                    [Validation(Required=false)]
                    public string Mobile { get; set; }
                    [NameInMap("Nation")]
                    [Validation(Required=false)]
                    public string Nation { get; set; }
                    [NameInMap("NationCountry")]
                    [Validation(Required=false)]
                    public string NationCountry { get; set; }
                    [NameInMap("NickName")]
                    [Validation(Required=false)]
                    public string NickName { get; set; }
                    [NameInMap("PersonalPhoto")]
                    [Validation(Required=false)]
                    public string PersonalPhoto { get; set; }
                    [NameInMap("Phone")]
                    [Validation(Required=false)]
                    public string Phone { get; set; }
                    [NameInMap("RealName")]
                    [Validation(Required=false)]
                    public string RealName { get; set; }
                    [NameInMap("Sex")]
                    [Validation(Required=false)]
                    public string Sex { get; set; }
                    [NameInMap("SourceSystem")]
                    [Validation(Required=false)]
                    public string SourceSystem { get; set; }
                    [NameInMap("SourceUserId")]
                    [Validation(Required=false)]
                    public string SourceUserId { get; set; }
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }
                    [NameInMap("WorkNo")]
                    [Validation(Required=false)]
                    public string WorkNo { get; set; }
                };

                [NameInMap("TestArchitect")]
                [Validation(Required=false)]
                public GetCASApplicationDetailResponseBodyDataAppOwnerTestArchitect TestArchitect { get; set; }
                public class GetCASApplicationDetailResponseBodyDataAppOwnerTestArchitect : TeaModel {
                    [NameInMap("CustomerId")]
                    [Validation(Required=false)]
                    public string CustomerId { get; set; }
                    [NameInMap("Email")]
                    [Validation(Required=false)]
                    public string Email { get; set; }
                    [NameInMap("EnName")]
                    [Validation(Required=false)]
                    public string EnName { get; set; }
                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }
                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }
                    [NameInMap("ImAccount")]
                    [Validation(Required=false)]
                    public string ImAccount { get; set; }
                    [NameInMap("LastLogonTime")]
                    [Validation(Required=false)]
                    public string LastLogonTime { get; set; }
                    [NameInMap("LoginName")]
                    [Validation(Required=false)]
                    public string LoginName { get; set; }
                    [NameInMap("Mobile")]
                    [Validation(Required=false)]
                    public string Mobile { get; set; }
                    [NameInMap("Nation")]
                    [Validation(Required=false)]
                    public string Nation { get; set; }
                    [NameInMap("NationCountry")]
                    [Validation(Required=false)]
                    public string NationCountry { get; set; }
                    [NameInMap("NickName")]
                    [Validation(Required=false)]
                    public string NickName { get; set; }
                    [NameInMap("PersonalPhoto")]
                    [Validation(Required=false)]
                    public string PersonalPhoto { get; set; }
                    [NameInMap("Phone")]
                    [Validation(Required=false)]
                    public string Phone { get; set; }
                    [NameInMap("RealName")]
                    [Validation(Required=false)]
                    public string RealName { get; set; }
                    [NameInMap("Sex")]
                    [Validation(Required=false)]
                    public string Sex { get; set; }
                    [NameInMap("SourceSystem")]
                    [Validation(Required=false)]
                    public string SourceSystem { get; set; }
                    [NameInMap("SourceUserId")]
                    [Validation(Required=false)]
                    public string SourceUserId { get; set; }
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }
                    [NameInMap("WorkNo")]
                    [Validation(Required=false)]
                    public string WorkNo { get; set; }
                };

                [NameInMap("TestOwner")]
                [Validation(Required=false)]
                public GetCASApplicationDetailResponseBodyDataAppOwnerTestOwner TestOwner { get; set; }
                public class GetCASApplicationDetailResponseBodyDataAppOwnerTestOwner : TeaModel {
                    [NameInMap("CustomerId")]
                    [Validation(Required=false)]
                    public string CustomerId { get; set; }
                    [NameInMap("Email")]
                    [Validation(Required=false)]
                    public string Email { get; set; }
                    [NameInMap("EnName")]
                    [Validation(Required=false)]
                    public string EnName { get; set; }
                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }
                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }
                    [NameInMap("ImAccount")]
                    [Validation(Required=false)]
                    public string ImAccount { get; set; }
                    [NameInMap("LastLogonTime")]
                    [Validation(Required=false)]
                    public string LastLogonTime { get; set; }
                    [NameInMap("LoginName")]
                    [Validation(Required=false)]
                    public string LoginName { get; set; }
                    [NameInMap("Mobile")]
                    [Validation(Required=false)]
                    public string Mobile { get; set; }
                    [NameInMap("Nation")]
                    [Validation(Required=false)]
                    public string Nation { get; set; }
                    [NameInMap("NationCountry")]
                    [Validation(Required=false)]
                    public string NationCountry { get; set; }
                    [NameInMap("NickName")]
                    [Validation(Required=false)]
                    public string NickName { get; set; }
                    [NameInMap("PersonalPhoto")]
                    [Validation(Required=false)]
                    public string PersonalPhoto { get; set; }
                    [NameInMap("Phone")]
                    [Validation(Required=false)]
                    public string Phone { get; set; }
                    [NameInMap("RealName")]
                    [Validation(Required=false)]
                    public string RealName { get; set; }
                    [NameInMap("Sex")]
                    [Validation(Required=false)]
                    public string Sex { get; set; }
                    [NameInMap("SourceSystem")]
                    [Validation(Required=false)]
                    public string SourceSystem { get; set; }
                    [NameInMap("SourceUserId")]
                    [Validation(Required=false)]
                    public string SourceUserId { get; set; }
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }
                    [NameInMap("WorkNo")]
                    [Validation(Required=false)]
                    public string WorkNo { get; set; }
                };

            }
            [NameInMap("Archetype")]
            [Validation(Required=false)]
            public GetCASApplicationDetailResponseBodyDataArchetype Archetype { get; set; }
            public class GetCASApplicationDetailResponseBodyDataArchetype : TeaModel {
                [NameInMap("ArtifactId")]
                [Validation(Required=false)]
                public string ArtifactId { get; set; }

                [NameInMap("CodePackage")]
                [Validation(Required=false)]
                public string CodePackage { get; set; }

                [NameInMap("Encoding")]
                [Validation(Required=false)]
                public string Encoding { get; set; }

                [NameInMap("GenerateCode")]
                [Validation(Required=false)]
                public bool? GenerateCode { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("MetaData")]
                [Validation(Required=false)]
                public string MetaData { get; set; }

                [NameInMap("ProjectType")]
                [Validation(Required=false)]
                public string ProjectType { get; set; }

                [NameInMap("UsePrivateRepo")]
                [Validation(Required=false)]
                public bool? UsePrivateRepo { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }
            [NameInMap("CodeRepository")]
            [Validation(Required=false)]
            public GetCASApplicationDetailResponseBodyDataCodeRepository CodeRepository { get; set; }
            public class GetCASApplicationDetailResponseBodyDataCodeRepository : TeaModel {
                [NameInMap("ExtraParams")]
                [Validation(Required=false)]
                public string ExtraParams { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("IsInitStandardPath")]
                [Validation(Required=false)]
                public bool? IsInitStandardPath { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("ParentReposName")]
                [Validation(Required=false)]
                public string ParentReposName { get; set; }

                [NameInMap("RemoteRepoId")]
                [Validation(Required=false)]
                public string RemoteRepoId { get; set; }

                [NameInMap("RepoReuse")]
                [Validation(Required=false)]
                public string RepoReuse { get; set; }

                [NameInMap("SourceLocation")]
                [Validation(Required=false)]
                public string SourceLocation { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("UseExist")]
                [Validation(Required=false)]
                public bool? UseExist { get; set; }

            }
            [NameInMap("LifeCycle")]
            [Validation(Required=false)]
            public GetCASApplicationDetailResponseBodyDataLifeCycle LifeCycle { get; set; }
            public class GetCASApplicationDetailResponseBodyDataLifeCycle : TeaModel {
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("LastDeployTime")]
                [Validation(Required=false)]
                public string LastDeployTime { get; set; }

                [NameInMap("LastDeployVersion")]
                [Validation(Required=false)]
                public string LastDeployVersion { get; set; }

                [NameInMap("LastOpsorderId")]
                [Validation(Required=false)]
                public string LastOpsorderId { get; set; }

                [NameInMap("OnlineTime")]
                [Validation(Required=false)]
                public string OnlineTime { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

            }
        };

    }

}
