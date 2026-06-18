// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateCustomScenePolicyRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the policy.</para>
        /// <para>The time must be in UTC and in the ISO 8601 format: yyyy-MM-ddTHH:mm:ssZ.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-03T19:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The name of the policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The site IDs to associate with the policy. Use a comma (,) to separate multiple IDs.</para>
        /// <remarks>
        /// <para>This parameter is deprecated. We recommend using the <c>SiteIds</c> parameter instead. If the <c>SiteIds</c> parameter is specified, the <c>Objects</c> parameter is ignored. You must specify a value for either the <c>Objects</c> or <c>SiteIds</c> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123456****,123457****</para>
        /// </summary>
        [NameInMap("Objects")]
        [Validation(Required=false)]
        public string Objects { get; set; }

        /// <summary>
        /// <para>To obtain the policy ID, call the <a href="https://help.aliyun.com/document_detail/2850508.html">DescribeCustomScenePolicies</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public long? PolicyId { get; set; }

        /// <summary>
        /// <para>The site IDs to associate with the policy. Use a comma (,) to separate multiple IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****,123457****</para>
        /// </summary>
        [NameInMap("SiteIds")]
        [Validation(Required=false)]
        public string SiteIds { get; set; }

        /// <summary>
        /// <para>The start time of the policy.</para>
        /// <para>The time must be in UTC and in the ISO 8601 format: yyyy-MM-ddTHH:mm:ssZ.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-03T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The name of the template. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><b>promotion</b>: major promotion</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>promotion</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public string Template { get; set; }

    }

}
