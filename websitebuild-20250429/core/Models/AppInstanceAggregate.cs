// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class AppInstanceAggregate : TeaModel {
        /// <summary>
        /// <para>The list of AI agents associated with the application.</para>
        /// </summary>
        [NameInMap("AiStaffList")]
        [Validation(Required=false)]
        public List<AppAiStaff> AiStaffList { get; set; }

        /// <summary>
        /// <para>The operation address of the application.</para>
        /// </summary>
        [NameInMap("AppOperationAddress")]
        [Validation(Required=false)]
        public AppOperationAddress AppOperationAddress { get; set; }

        /// <summary>
        /// <para>The list of service instances associated with the application.</para>
        /// </summary>
        [NameInMap("AppServiceList")]
        [Validation(Required=false)]
        public List<AppServiceAggregate> AppServiceList { get; set; }

        /// <summary>
        /// <para>The application subtype.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SEO_CONTENT</para>
        /// </summary>
        [NameInMap("AppSubType")]
        [Validation(Required=false)]
        public string AppSubType { get; set; }

        /// <summary>
        /// <para>The application type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WEBSITE</para>
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// <para>The business ID of the application instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WS20250915163734000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The build type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CLOUD_DREAM_SAAS</para>
        /// </summary>
        [NameInMap("BuildType")]
        [Validation(Required=false)]
        public string BuildType { get; set; }

        /// <summary>
        /// <para>没有关联会话时为 null。</para>
        /// </summary>
        [NameInMap("ConversationInfo")]
        [Validation(Required=false)]
        public AppInstanceAggregateConversationInfo ConversationInfo { get; set; }
        public class AppInstanceAggregateConversationInfo : TeaModel {
            /// <summary>
            /// <para>0 表示存在空会话。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ChatNum")]
            [Validation(Required=false)]
            public long? ChatNum { get; set; }

        }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance is deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Deleted")]
        [Validation(Required=false)]
        public int? Deleted { get; set; }

        /// <summary>
        /// <para>The application description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>base</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The business ID of the design specification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WS20250801151731000007</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>stxycw.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-05T15:59:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the associated delivery order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>p20202933455</para>
        /// </summary>
        [NameInMap("EspBizId")]
        [Validation(Required=false)]
        public string EspBizId { get; set; }

        /// <summary>
        /// <para>The deletion time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("GmtDelete")]
        [Validation(Required=false)]
        public string GmtDelete { get; set; }

        /// <summary>
        /// <para>The update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-08-28T02:25:41Z</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The publication time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("GmtPublish")]
        [Validation(Required=false)]
        public string GmtPublish { get; set; }

        /// <summary>
        /// <para>The URL of the application icon.</para>
        /// 
        /// <b>Example:</b>
        /// <para>icon/WS20250626112715000001/thumbnail.jpg</para>
        /// </summary>
        [NameInMap("IconUrl")]
        [Validation(Required=false)]
        public string IconUrl { get; set; }

        /// <summary>
        /// <para>The application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>docs</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The partner details.</para>
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
                /// <summary>
                /// <para>The external business ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>WS20250801153127000002</para>
                /// </summary>
                [NameInMap("BizId")]
                [Validation(Required=false)]
                public string BizId { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1672123722000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Wed Nov 26 10:15:28 CST 2025</para>
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
                /// 
                /// <b>Example:</b>
                /// <para>1123213</para>
                /// </summary>
                [NameInMap("ParentPk")]
                [Validation(Required=false)]
                public string ParentPk { get; set; }

                /// <summary>
                /// <para>The partner ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10001</para>
                /// </summary>
                [NameInMap("PartnerId")]
                [Validation(Required=false)]
                public string PartnerId { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud account ID of the bound user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456789</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The partner ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("PartnerId")]
            [Validation(Required=false)]
            public string PartnerId { get; set; }

            /// <summary>
            /// <para>The partner binding status. Valid values: BOUND (bound) and UNBOUND (unbound).</para>
            /// 
            /// <b>Example:</b>
            /// <para>BOUND</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The configuration and runtime information of the application instance.</para>
        /// </summary>
        [NameInMap("Profile")]
        [Validation(Required=false)]
        public AppInstanceProfile Profile { get; set; }

        /// <summary>
        /// <para>The ID of the enterprise resource group to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2smovqqpvuly</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The website domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abcd.scd.wanwang.xin</para>
        /// </summary>
        [NameInMap("SiteHost")]
        [Validation(Required=false)]
        public string SiteHost { get; set; }

        /// <summary>
        /// <para>The application identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31104757</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>2023-03-24T10:10Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>trial,draft,live,refunded,expired,released</para>
        /// 
        /// <b>Example:</b>
        /// <para>live</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The status text.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Published</para>
        /// </summary>
        [NameInMap("StatusText")]
        [Validation(Required=false)]
        public string StatusText { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<AppInstanceAggregateTags> Tags { get; set; }
        public class AppInstanceAggregateTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the instance. Valid values of N: <b>1</b> to <b>20</b>. If you specify this parameter, it cannot be an empty string.</para>
            /// <para>The tag key can be up to 64 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Group</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The tag value of the instance. Valid values of N: <b>1</b> to <b>20</b>. If you specify this parameter, it can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ufo</para>
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

        /// <summary>
        /// <para>The application template record information.</para>
        /// </summary>
        [NameInMap("TemplateRecord")]
        [Validation(Required=false)]
        public TemplateRecord TemplateRecord { get; set; }

        /// <summary>
        /// <para>The URL of the application thumbnail.</para>
        /// 
        /// <b>Example:</b>
        /// <para>thumbnails/WS20250626112715000001/thumbnail.jpg</para>
        /// </summary>
        [NameInMap("ThumbnailUrl")]
        [Validation(Required=false)]
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123241414</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-04-02</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
