// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class SimpleTemplate : TeaModel {
        /// <summary>
        /// <para>Reasons for template deprecation</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;无效&quot;]</para>
        /// </summary>
        [NameInMap("AbandonReasons")]
        [Validation(Required=false)]
        public string AbandonReasons { get; set; }

        /// <summary>
        /// <para>Template description</para>
        /// 
        /// <b>Example:</b>
        /// <para>图片分割的模板</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Creation Time</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-12 14:21:08</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>Update Time</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-12 14:21:08</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>Is shared</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("SharedMode")]
        [Validation(Required=false)]
        public string SharedMode { get; set; }

        /// <summary>
        /// <para>Status</para>
        /// 
        /// <b>Example:</b>
        /// <para>DRAFT</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>List of tags</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// <para>Template ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>154***1431673270272</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>Template Name</para>
        /// 
        /// <b>Example:</b>
        /// <para>图片分割组合77aa</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>Tenant ID of the template</para>
        /// 
        /// <b>Example:</b>
        /// <para>GA***W134</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>Type</para>
        /// 
        /// <b>Example:</b>
        /// <para>CUSTOM</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
