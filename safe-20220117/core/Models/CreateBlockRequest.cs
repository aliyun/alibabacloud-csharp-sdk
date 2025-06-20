// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safe20220117.Models
{
    public class CreateBlockRequest : TeaModel {
        [NameInMap("ApproveStrategyNodes")]
        [Validation(Required=false)]
        public List<CreateBlockRequestApproveStrategyNodes> ApproveStrategyNodes { get; set; }
        public class CreateBlockRequestApproveStrategyNodes : TeaModel {
            [NameInMap("ApproveRuleType")]
            [Validation(Required=false)]
            public int? ApproveRuleType { get; set; }

            [NameInMap("ApproveType")]
            [Validation(Required=false)]
            public int? ApproveType { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NodeCode")]
            [Validation(Required=false)]
            public string NodeCode { get; set; }

            [NameInMap("PriorityOrder")]
            [Validation(Required=false)]
            public int? PriorityOrder { get; set; }

            [NameInMap("RoleCode")]
            [Validation(Required=false)]
            public int? RoleCode { get; set; }

            [NameInMap("RoleValue")]
            [Validation(Required=false)]
            public List<string> RoleValue { get; set; }

            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

        }

        [NameInMap("BlockId")]
        [Validation(Required=false)]
        public long? BlockId { get; set; }

        [NameInMap("Director")]
        [Validation(Required=false)]
        public string Director { get; set; }

        [NameInMap("IsNeedApprove")]
        [Validation(Required=false)]
        public int? IsNeedApprove { get; set; }

        [NameInMap("IsRecall")]
        [Validation(Required=false)]
        public int? IsRecall { get; set; }

        [NameInMap("IsTemplate")]
        [Validation(Required=false)]
        public int? IsTemplate { get; set; }

        [NameInMap("LabelName")]
        [Validation(Required=false)]
        public string LabelName { get; set; }

        [NameInMap("NoticeDesc")]
        [Validation(Required=false)]
        public string NoticeDesc { get; set; }

        [NameInMap("NoticeEnclosureInfos")]
        [Validation(Required=false)]
        public List<CreateBlockRequestNoticeEnclosureInfos> NoticeEnclosureInfos { get; set; }
        public class CreateBlockRequestNoticeEnclosureInfos : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("NoticeRequestLink")]
        [Validation(Required=false)]
        public string NoticeRequestLink { get; set; }

        [NameInMap("NoticeType")]
        [Validation(Required=false)]
        public int? NoticeType { get; set; }

        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        [NameInMap("Scene")]
        [Validation(Required=false)]
        public int? Scene { get; set; }

        [NameInMap("Scopes")]
        [Validation(Required=false)]
        public List<CreateBlockRequestScopes> Scopes { get; set; }
        public class CreateBlockRequestScopes : TeaModel {
            [NameInMap("BlockHarm")]
            [Validation(Required=false)]
            public List<int?> BlockHarm { get; set; }

            [NameInMap("BlockScope")]
            [Validation(Required=false)]
            public CreateBlockRequestScopesBlockScope BlockScope { get; set; }
            public class CreateBlockRequestScopesBlockScope : TeaModel {
                [NameInMap("App")]
                [Validation(Required=false)]
                public CreateBlockRequestScopesBlockScopeApp App { get; set; }
                public class CreateBlockRequestScopesBlockScopeApp : TeaModel {
                    [NameInMap("AppName")]
                    [Validation(Required=false)]
                    public List<string> AppName { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                }

                [NameInMap("BgSystem")]
                [Validation(Required=false)]
                public List<CreateBlockRequestScopesBlockScopeBgSystem> BgSystem { get; set; }
                public class CreateBlockRequestScopesBlockScopeBgSystem : TeaModel {
                    [NameInMap("RelateCodes")]
                    [Validation(Required=false)]
                    public List<string> RelateCodes { get; set; }

                    [NameInMap("SelfCodeName")]
                    [Validation(Required=false)]
                    public string SelfCodeName { get; set; }

                }

                [NameInMap("Cluster")]
                [Validation(Required=false)]
                public CreateBlockRequestScopesBlockScopeCluster Cluster { get; set; }
                public class CreateBlockRequestScopesBlockScopeCluster : TeaModel {
                    [NameInMap("CodeNames")]
                    [Validation(Required=false)]
                    public List<string> CodeNames { get; set; }

                    [NameInMap("Relations")]
                    [Validation(Required=false)]
                    public List<CreateBlockRequestScopesBlockScopeClusterRelations> Relations { get; set; }
                    public class CreateBlockRequestScopesBlockScopeClusterRelations : TeaModel {
                        [NameInMap("AppCodes")]
                        [Validation(Required=false)]
                        public List<string> AppCodes { get; set; }

                        [NameInMap("LabelCodes")]
                        [Validation(Required=false)]
                        public List<string> LabelCodes { get; set; }

                        [NameInMap("RelateCodes")]
                        [Validation(Required=false)]
                        public List<string> RelateCodes { get; set; }

                        [NameInMap("SelfCode")]
                        [Validation(Required=false)]
                        public string SelfCode { get; set; }

                    }

                }

                [NameInMap("Customer")]
                [Validation(Required=false)]
                public List<CreateBlockRequestScopesBlockScopeCustomer> Customer { get; set; }
                public class CreateBlockRequestScopesBlockScopeCustomer : TeaModel {
                    [NameInMap("CodeNames")]
                    [Validation(Required=false)]
                    public List<string> CodeNames { get; set; }

                    [NameInMap("Relations")]
                    [Validation(Required=false)]
                    public List<CreateBlockRequestScopesBlockScopeCustomerRelations> Relations { get; set; }
                    public class CreateBlockRequestScopesBlockScopeCustomerRelations : TeaModel {
                        [NameInMap("AppCodes")]
                        [Validation(Required=false)]
                        public List<string> AppCodes { get; set; }

                        [NameInMap("LabelCodes")]
                        [Validation(Required=false)]
                        public List<string> LabelCodes { get; set; }

                        [NameInMap("RelateCodes")]
                        [Validation(Required=false)]
                        public List<string> RelateCodes { get; set; }

                        [NameInMap("SelfCode")]
                        [Validation(Required=false)]
                        public string SelfCode { get; set; }

                    }

                    [NameInMap("Uid")]
                    [Validation(Required=false)]
                    public string Uid { get; set; }

                    [NameInMap("ViewCodes")]
                    [Validation(Required=false)]
                    public List<int?> ViewCodes { get; set; }

                }

                [NameInMap("Dept")]
                [Validation(Required=false)]
                public List<string> Dept { get; set; }

                [NameInMap("Express")]
                [Validation(Required=false)]
                public string Express { get; set; }

                [NameInMap("Infrastructure")]
                [Validation(Required=false)]
                public List<string> Infrastructure { get; set; }

                [NameInMap("Product")]
                [Validation(Required=false)]
                public List<CreateBlockRequestScopesBlockScopeProduct> Product { get; set; }
                public class CreateBlockRequestScopesBlockScopeProduct : TeaModel {
                    [NameInMap("CodeNames")]
                    [Validation(Required=false)]
                    public List<string> CodeNames { get; set; }

                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Relations")]
                    [Validation(Required=false)]
                    public List<CreateBlockRequestScopesBlockScopeProductRelations> Relations { get; set; }
                    public class CreateBlockRequestScopesBlockScopeProductRelations : TeaModel {
                        [NameInMap("AppCodes")]
                        [Validation(Required=false)]
                        public List<string> AppCodes { get; set; }

                        [NameInMap("LabelCodes")]
                        [Validation(Required=false)]
                        public List<string> LabelCodes { get; set; }

                        [NameInMap("RelateCodes")]
                        [Validation(Required=false)]
                        public List<string> RelateCodes { get; set; }

                        [NameInMap("SelfCode")]
                        [Validation(Required=false)]
                        public string SelfCode { get; set; }

                    }

                    [NameInMap("ViewCode")]
                    [Validation(Required=false)]
                    public List<string> ViewCode { get; set; }

                }

            }

            [NameInMap("EffectTime")]
            [Validation(Required=false)]
            public List<long?> EffectTime { get; set; }

            [NameInMap("ScopeRule")]
            [Validation(Required=false)]
            public string ScopeRule { get; set; }

            [NameInMap("changeObjectRegex")]
            [Validation(Required=false)]
            public string ChangeObjectRegex { get; set; }

            [NameInMap("riskLevels")]
            [Validation(Required=false)]
            public List<int?> RiskLevels { get; set; }

        }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public long? VersionId { get; set; }

        [NameInMap("creatorEmpId")]
        [Validation(Required=false)]
        public string CreatorEmpId { get; set; }

    }

}
