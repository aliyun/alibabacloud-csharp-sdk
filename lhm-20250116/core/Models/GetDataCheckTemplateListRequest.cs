// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class GetDataCheckTemplateListRequest : TeaModel {
        /// <summary>
        /// <para>The validation rule type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: data volume comparison.</description></item>
        /// <item><description>1: metric comparison.</description></item>
        /// <item><description>2: weak content comparison.</description></item>
        /// <item><description>3: custom comparison.</description></item>
        /// <item><description>4: full-text comparison.</description></item>
        /// <item><description>5: null rate comparison.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("checkType")]
        [Validation(Required=false)]
        public int? CheckType { get; set; }

        /// <summary>
        /// <para>The field used for grouping (GROUP BY condition). Configure this parameter as needed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order_date</para>
        /// </summary>
        [NameInMap("groupBy")]
        [Validation(Required=false)]
        public string GroupBy { get; set; }

        /// <summary>
        /// <para>The list of validation template UUIDs. The source code of CheckTemplatePagedQry indicates that this parameter has no actual effect and does not need to be exposed externally. It is retained only for backward compatibility with legacy calls. Passing this parameter does not affect query results.</para>
        /// </summary>
        [NameInMap("idList")]
        [Validation(Required=false)]
        public List<string> IdList { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> This parameter is deprecated and does not need to be passed. The source code of CheckTemplatePagedQry marks this parameter with @Deprecated.</para>
        /// </summary>
        [NameInMap("isAdmin")]
        [Validation(Required=false)]
        public bool? IsAdmin { get; set; }

        /// <summary>
        /// <para>Specifies whether the template is built-in. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: No. The template is a custom template.</description></item>
        /// <item><description>1: Yes. The template is a built-in template.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("isBuiltin")]
        [Validation(Required=false)]
        public int? IsBuiltin { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the total record count in the paginated results.</para>
        /// </summary>
        [NameInMap("needTotalCount")]
        [Validation(Required=false)]
        public bool? NeedTotalCount { get; set; }

        /// <summary>
        /// <para>The field used for sorting. Configure this parameter as needed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gmtCreate</para>
        /// </summary>
        [NameInMap("orderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The sort direction. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ASC: ascending order.</description></item>
        /// <item><description>DESC: descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("orderDirection")]
        [Validation(Required=false)]
        public string OrderDirection { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>The page size, which specifies the number of records returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1EBD0C05-6C1F-4B7A-9C3D-2A8F7E6B5C4D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The name of the validation template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataVolumeValidationTemplate</para>
        /// </summary>
        [NameInMap("templateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
