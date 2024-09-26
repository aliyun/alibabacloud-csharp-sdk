// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMetaTableChangeLogRequest : TeaModel {
        /// <summary>
        /// <para>The type of the change. Valid values: CREATE_TABLE, ALTER_TABLE, DROP_TABLE, ADD_PARTITION, and DROP_PARTITION.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALTER_TABLE</para>
        /// </summary>
        [NameInMap("ChangeType")]
        [Validation(Required=false)]
        public string ChangeType { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the yyyy-MM-dd HH:mm:ss format.</para>
        /// <list type="bullet">
        /// <item><description>By default, the system uses the current time as the value of this parameter if the time that you specify is invalid.</description></item>
        /// <item><description>If both the values of the StartDate and EndDate parameters are invalid, the system automatically queries the change logs that are generated within the last 30 days.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2020-06-02 00:00:00</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The entity on which the change is made. Valid values: TABLE and PARTITION.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TABLE</para>
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the yyyy-MM-dd HH:mm:ss format.</para>
        /// <list type="bullet">
        /// <item><description>By default, the system uses the current time as the value of this parameter if the time that you specify is invalid.</description></item>
        /// <item><description>If both the values of the StartDate and EndDate parameters are invalid, the system automatically queries the change logs that are generated within the last 30 days.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2020-06-01 00:00:00</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The GUID of the table. Specify the GUID in the odps.projectName.tableName format. You can call the <a href="https://help.aliyun.com/document_detail/2780086.html">GetMetaDBTableList</a> operation to query the GUID.</para>
        /// <remarks>
        /// <para>To query the change logs of a MaxCompute table, you must call the <a href="https://help.aliyun.com/document_detail/2780094.html">GetMetaTableChangeLog</a> operation.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>odps.engine_name.table_name</para>
        /// </summary>
        [NameInMap("TableGuid")]
        [Validation(Required=false)]
        public string TableGuid { get; set; }

    }

}
