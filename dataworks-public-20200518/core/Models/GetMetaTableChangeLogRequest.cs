// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMetaTableChangeLogRequest : TeaModel {
        /// <summary>
        /// The type of the change. Valid values: CREATE_TABLE, ALTER_TABLE, DROP_TABLE, ADD_PARTITION, and DROP_PARTITION.
        /// </summary>
        [NameInMap("ChangeType")]
        [Validation(Required=false)]
        public string ChangeType { get; set; }

        /// <summary>
        /// The end of the time range to query. Specify the time in the yyyy-MM-dd HH:mm:ss format.
        /// 
        /// *   By default, the system uses the current time as the value of this parameter if the time that you specify is invalid.
        /// *   If both the values of the StartDate and EndDate parameters are invalid, the system automatically queries the change logs that are generated within the last 30 days.
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// The entity on which the change is made. Valid values: TABLE and PARTITION.
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 10. Maximum value: 100.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the yyyy-MM-dd HH:mm:ss format.
        /// 
        /// *   By default, the system uses the current time as the value of this parameter if the time that you specify is invalid.
        /// *   If both the values of the StartDate and EndDate parameters are invalid, the system automatically queries the change logs that are generated within the last 30 days.
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// The GUID of the table. Specify the GUID in the odps.projectName.tableName format. You can call the [GetMetaDBTableList](https://help.aliyun.com/document_detail/2780086.html) operation to query the GUID.
        /// 
        /// > To query the change logs of a MaxCompute table, you must call the [GetMetaTableChangeLog](https://help.aliyun.com/document_detail/2780094.html) operation.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TableGuid")]
        [Validation(Required=false)]
        public string TableGuid { get; set; }

    }

}
