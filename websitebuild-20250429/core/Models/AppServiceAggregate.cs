// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class AppServiceAggregate : TeaModel {
        /// <summary>
        /// <para>The business ID of the application instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WS20251211153330000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The deletion flag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Deleted")]
        [Validation(Required=false)]
        public int? Deleted { get; set; }

        /// <summary>
        /// <para>The end time. It is in ISO 8601 format and uses the UTC time zone (Z).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-07-18T02:23:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>esp bizId</para>
        /// 
        /// <b>Example:</b>
        /// <para>p20202933455</para>
        /// </summary>
        [NameInMap("EspBizId")]
        [Validation(Required=false)]
        public string EspBizId { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-07-30T02:08:40Z</para>
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>The modification time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tue Sep 09 10:27:49 CST 2025</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The operation address of the application.</para>
        /// </summary>
        [NameInMap("Group")]
        [Validation(Required=false)]
        public AppServiceGroup Group { get; set; }

        /// <summary>
        /// <para>The associated business ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WS20250915163734000001</para>
        /// </summary>
        [NameInMap("InstanceBizId")]
        [Validation(Required=false)]
        public string InstanceBizId { get; set; }

        /// <summary>
        /// <para>The service name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Website design service</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The list of flow nodes.</para>
        /// </summary>
        [NameInMap("NodeList")]
        [Validation(Required=false)]
        public List<TreeNode> NodeList { get; set; }

        /// <summary>
        /// <para>Uniquely identifies an operation.</para>
        /// </summary>
        [NameInMap("OperationAddress")]
        [Validation(Required=false)]
        public AppOperationAddress OperationAddress { get; set; }

        /// <summary>
        /// <para>The configuration information of the application service.</para>
        /// </summary>
        [NameInMap("Profile")]
        [Validation(Required=false)]
        public AppServiceProfile Profile { get; set; }

        /// <summary>
        /// <para>The service type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WEBSITE_DESIGN</para>
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// <para>The description of the service type.</para>
        /// </summary>
        [NameInMap("ServiceTypeText")]
        [Validation(Required=false)]
        public string ServiceTypeText { get; set; }

        /// <summary>
        /// <para>The application identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>inst-001</para>
        /// </summary>
        [NameInMap("Slug")]
        [Validation(Required=false)]
        public string Slug { get; set; }

        /// <summary>
        /// <para>The start time. It is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1754447102000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123241414</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
