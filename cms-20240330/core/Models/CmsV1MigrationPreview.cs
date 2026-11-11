// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CmsV1MigrationPreview : TeaModel {
        /// <summary>
        /// <para>The itemized check results for name and resource support.</para>
        /// </summary>
        [NameInMap("checks")]
        [Validation(Required=false)]
        public List<CmsV1MigrationCheck> Checks { get; set; }

        /// <summary>
        /// <para>The name of the source application group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order-service</para>
        /// </summary>
        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>Indicates whether the dry run is passed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("migratable")]
        [Validation(Required=false)]
        public bool? Migratable { get; set; }

        /// <summary>
        /// <para>The ID of the target observation group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>og-0123456789abcdef</para>
        /// </summary>
        [NameInMap("observeGroupId")]
        [Validation(Required=false)]
        public string ObserveGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the source CloudMonitor 1.0 application group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>247675311</para>
        /// </summary>
        [NameInMap("originGroupId")]
        [Validation(Required=false)]
        public string OriginGroupId { get; set; }

        /// <summary>
        /// <para>The reason for the dry run failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NAME_INVALID</para>
        /// </summary>
        [NameInMap("reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>Indicates whether the source 1.0 group is persistently read-only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("sourceReadOnly")]
        [Validation(Required=false)]
        public bool? SourceReadOnly { get; set; }

        /// <summary>
        /// <para>The type of the source application group. custom indicates a custom group, tag indicates a tag-based group, and regMgr indicates a resource group-based group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The name of the target observation group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order-service</para>
        /// </summary>
        [NameInMap("targetGroupName")]
        [Validation(Required=false)]
        public string TargetGroupName { get; set; }

    }

}
