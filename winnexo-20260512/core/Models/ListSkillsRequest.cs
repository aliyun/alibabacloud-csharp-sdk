// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListSkillsRequest : TeaModel {
        /// <summary>
        /// <para>The binding status. Valid values: BOUND (bound) and UNBOUND (unbound global skills). Must be specified together with operatingObjectName.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BOUND</para>
        /// </summary>
        [NameInMap("bindStatus")]
        [Validation(Required=false)]
        public string BindStatus { get; set; }

        /// <summary>
        /// <para>The filter expression type.</para>
        /// <list type="bullet">
        /// <item><description>SQL: SQL-based filtering.</description></item>
        /// <item><description>TAG: Tag-based filtering.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("filterType")]
        [Validation(Required=false)]
        public string FilterType { get; set; }

        /// <summary>
        /// <para>The search keyword. Supports fuzzy search by API name or exact search by API ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SampleKeyword</para>
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The digital employee name. Used to calculate the CodeAgent allowedSkills whitelist based on binding relationships.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11111</para>
        /// </summary>
        [NameInMap("operatingObjectName")]
        [Validation(Required=false)]
        public string OperatingObjectName { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The tag filtering parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. If not specified, the default tenant of the caller is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
