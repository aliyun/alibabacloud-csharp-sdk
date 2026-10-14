// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListScheduleTemplatesRequest : TeaModel {
        /// <summary>
        /// <para>The query conditions for the scheduling template list. This is a JSON object that supports keyword search and pagination.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListScheduleTemplatesCommand")]
        [Validation(Required=false)]
        public ListScheduleTemplatesRequestListScheduleTemplatesCommand ListScheduleTemplatesCommand { get; set; }
        public class ListScheduleTemplatesRequestListScheduleTemplatesCommand : TeaModel {
            /// <summary>
            /// <para>The keyword for fuzzy matching by template name. If this parameter is empty or not specified, no filtering is applied.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hour</para>
            /// </summary>
            [NameInMap("Keyword")]
            [Validation(Required=false)]
            public string Keyword { get; set; }

            /// <summary>
            /// <para>The page number. Pages start from 1. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Default value: 50. Maximum value: 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The scheduling templatetype. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>BASE_SCHEDULE_TEMPLATE: basic scheduling template</description></item>
            /// <item><description>CONDITION_SCHEDULE_TEMPLATE: conditional scheduling template
            /// If this parameter is not specified, all types are returned.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BASE_SCHEDULE_TEMPLATE</para>
            /// </summary>
            [NameInMap("ScheduleTemplateType")]
            [Validation(Required=false)]
            public string ScheduleTemplateType { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID, which indicates the tenant for the current operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The ID of the user who performs the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
