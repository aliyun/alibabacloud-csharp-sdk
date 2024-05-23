// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeSlowSQLListShrinkRequest : TeaModel {
        /// <summary>
        /// The name of the database.
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// The end time of the time range for querying slow SQL statements.   
        /// The value must be UTC time in the format of YYYY-MM-DDThh:mm:ssZ.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The filter condition.
        /// </summary>
        [NameInMap("FilterCondition")]
        [Validation(Required=false)]
        public string FilterConditionShrink { get; set; }

        /// <summary>
        /// The IP address of the database node.
        /// </summary>
        [NameInMap("NodeIp")]
        [Validation(Required=false)]
        public string NodeIp { get; set; }

        /// <summary>
        /// The number of rows to return on each page.  
        /// - Maximum value: 100  
        /// - Default value: 10
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of the page to return.    
        /// - Start value: 1   
        /// - Default value: 1
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The SQL ID, which uniquely identifies an SQL statement.
        /// </summary>
        [NameInMap("SQLId")]
        [Validation(Required=false)]
        public string SQLId { get; set; }

        /// <summary>
        /// The search keyword.
        /// </summary>
        [NameInMap("SearchKeyWord")]
        [Validation(Required=false)]
        public string SearchKeyWord { get; set; }

        /// <summary>
        /// The search parameter.
        /// </summary>
        [NameInMap("SearchParameter")]
        [Validation(Required=false)]
        public string SearchParameter { get; set; }

        /// <summary>
        /// The search rule.
        /// </summary>
        [NameInMap("SearchRule")]
        [Validation(Required=false)]
        public string SearchRule { get; set; }

        /// <summary>
        /// The search value.
        /// </summary>
        [NameInMap("SearchValue")]
        [Validation(Required=false)]
        public string SearchValue { get; set; }

        /// <summary>
        /// The sorted column.
        /// </summary>
        [NameInMap("SortColumn")]
        [Validation(Required=false)]
        public string SortColumn { get; set; }

        /// <summary>
        /// The sorting rule.
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// The start time of the time range for querying slow SQL statements.   
        /// The value must be UTC time in the format of YYYY-MM-DDThh:mm:ssZ.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
