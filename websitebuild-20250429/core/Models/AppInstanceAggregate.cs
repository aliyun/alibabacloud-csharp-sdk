// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class AppInstanceAggregate : TeaModel {
        [NameInMap("AiStaffList")]
        [Validation(Required=false)]
        public List<AppAiStaff> AiStaffList { get; set; }

        [NameInMap("AppOperationAddress")]
        [Validation(Required=false)]
        public AppOperationAddress AppOperationAddress { get; set; }

        [NameInMap("AppServiceList")]
        [Validation(Required=false)]
        public List<AppServiceAggregate> AppServiceList { get; set; }

        [NameInMap("AppSubType")]
        [Validation(Required=false)]
        public string AppSubType { get; set; }

        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("BuildType")]
        [Validation(Required=false)]
        public string BuildType { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("Deleted")]
        [Validation(Required=false)]
        public int? Deleted { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DesignSpecBizId")]
        [Validation(Required=false)]
        public string DesignSpecBizId { get; set; }

        [NameInMap("DesignSpecId")]
        [Validation(Required=false)]
        public string DesignSpecId { get; set; }

        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("EspBizId")]
        [Validation(Required=false)]
        public string EspBizId { get; set; }

        [NameInMap("GmtDelete")]
        [Validation(Required=false)]
        public string GmtDelete { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("GmtPublish")]
        [Validation(Required=false)]
        public string GmtPublish { get; set; }

        [NameInMap("IconUrl")]
        [Validation(Required=false)]
        public string IconUrl { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PartnerDetail")]
        [Validation(Required=false)]
        public AppInstanceAggregatePartnerDetail PartnerDetail { get; set; }
        public class AppInstanceAggregatePartnerDetail : TeaModel {
            [NameInMap("BindData")]
            [Validation(Required=false)]
            public AppInstanceAggregatePartnerDetailBindData BindData { get; set; }
            public class AppInstanceAggregatePartnerDetailBindData : TeaModel {
                [NameInMap("BizId")]
                [Validation(Required=false)]
                public string BizId { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Mobile")]
                [Validation(Required=false)]
                public string Mobile { get; set; }

                [NameInMap("ParentPk")]
                [Validation(Required=false)]
                public string ParentPk { get; set; }

                [NameInMap("PartnerId")]
                [Validation(Required=false)]
                public string PartnerId { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("PartnerId")]
            [Validation(Required=false)]
            public string PartnerId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("Profile")]
        [Validation(Required=false)]
        public AppInstanceProfile Profile { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("SiteHost")]
        [Validation(Required=false)]
        public string SiteHost { get; set; }

        [NameInMap("Slug")]
        [Validation(Required=false)]
        public string Slug { get; set; }

        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>trial,draft,live,refunded,expired,released</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("StatusText")]
        [Validation(Required=false)]
        public string StatusText { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<AppInstanceAggregateTags> Tags { get; set; }
        public class AppInstanceAggregateTags : TeaModel {
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

        [NameInMap("ThumbnailUrl")]
        [Validation(Required=false)]
        public string ThumbnailUrl { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
