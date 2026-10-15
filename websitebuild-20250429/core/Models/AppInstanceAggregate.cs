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

        /// <summary>
        /// <para>The application operation address.</para>
        /// </summary>
        [NameInMap("AppOperationAddress")]
        [Validation(Required=false)]
        public AppOperationAddress AppOperationAddress { get; set; }

        [NameInMap("AppServiceList")]
        [Validation(Required=false)]
        public List<AppServiceAggregate> AppServiceList { get; set; }

        /// <summary>
        /// <para>The application subtype.</para>
        /// </summary>
        [NameInMap("AppSubType")]
        [Validation(Required=false)]
        public string AppSubType { get; set; }

        /// <summary>
        /// <para>The application type.</para>
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// <para>The business ID of the application instance.</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The build type.</para>
        /// </summary>
        [NameInMap("BuildType")]
        [Validation(Required=false)]
        public string BuildType { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance is deleted.</para>
        /// </summary>
        [NameInMap("Deleted")]
        [Validation(Required=false)]
        public int? Deleted { get; set; }

        /// <summary>
        /// <para>The application description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The business ID of the design specification.</para>
        /// </summary>
        [NameInMap("DesignSpecBizId")]
        [Validation(Required=false)]
        public string DesignSpecBizId { get; set; }

        /// <summary>
        /// <para>The design specification ID.</para>
        /// </summary>
        [NameInMap("DesignSpecId")]
        [Validation(Required=false)]
        public string DesignSpecId { get; set; }

        /// <summary>
        /// <para>The primary domain name.</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The end time.</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the associated delivery order.</para>
        /// </summary>
        [NameInMap("EspBizId")]
        [Validation(Required=false)]
        public string EspBizId { get; set; }

        /// <summary>
        /// <para>The deletion time.</para>
        /// </summary>
        [NameInMap("GmtDelete")]
        [Validation(Required=false)]
        public string GmtDelete { get; set; }

        /// <summary>
        /// <para>The modification time.</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The publish time.</para>
        /// </summary>
        [NameInMap("GmtPublish")]
        [Validation(Required=false)]
        public string GmtPublish { get; set; }

        /// <summary>
        /// <para>The application icon.</para>
        /// </summary>
        [NameInMap("IconUrl")]
        [Validation(Required=false)]
        public string IconUrl { get; set; }

        /// <summary>
        /// <para>The application name.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The details.</para>
        /// </summary>
        [NameInMap("PartnerDetail")]
        [Validation(Required=false)]
        public AppInstanceAggregatePartnerDetail PartnerDetail { get; set; }
        public class AppInstanceAggregatePartnerDetail : TeaModel {
            /// <summary>
            /// <para>data</para>
            /// </summary>
            [NameInMap("BindData")]
            [Validation(Required=false)]
            public AppInstanceAggregatePartnerDetailBindData BindData { get; set; }
            public class AppInstanceAggregatePartnerDetailBindData : TeaModel {
                [NameInMap("BizId")]
                [Validation(Required=false)]
                public string BizId { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The modification time.</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The record ID.</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The mobile phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("Mobile")]
                [Validation(Required=false)]
                public string Mobile { get; set; }

                /// <summary>
                /// <para>The primary key of the parent record.</para>
                /// </summary>
                [NameInMap("ParentPk")]
                [Validation(Required=false)]
                public string ParentPk { get; set; }

                /// <summary>
                /// <para>The partner ID.</para>
                /// </summary>
                [NameInMap("PartnerId")]
                [Validation(Required=false)]
                public string PartnerId { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The partner ID.</para>
            /// </summary>
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

        /// <summary>
        /// <para>The website domain name.</para>
        /// </summary>
        [NameInMap("SiteHost")]
        [Validation(Required=false)]
        public string SiteHost { get; set; }

        /// <summary>
        /// <para>The application identifier.</para>
        /// </summary>
        [NameInMap("Slug")]
        [Validation(Required=false)]
        public string Slug { get; set; }

        /// <summary>
        /// <para>The source type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MARKET_CLOUD_DREAM</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The start time.</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>trial,draft,live,refunded,expired,released</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The status text.</para>
        /// </summary>
        [NameInMap("StatusText")]
        [Validation(Required=false)]
        public string StatusText { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<AppInstanceAggregateTags> Tags { get; set; }
        public class AppInstanceAggregateTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the instance. Valid values of N: <b>1</b> to <b>20</b>. If this parameter is specified, it cannot be an empty string.</para>
            /// <para>The tag key can be up to 64 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Group</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The tag value of the instance. Valid values of N: <b>1</b> to <b>20</b>. If this parameter is specified, it can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

        [NameInMap("TemplateRecord")]
        [Validation(Required=false)]
        public TemplateRecord TemplateRecord { get; set; }

        /// <summary>
        /// <para>The application thumbnail.</para>
        /// </summary>
        [NameInMap("ThumbnailUrl")]
        [Validation(Required=false)]
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The version.</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
