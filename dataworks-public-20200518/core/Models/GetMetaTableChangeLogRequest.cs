// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMetaTableChangeLogRequest : TeaModel {
        /// <summary>
        /// <para>The type of change. Valid values: CREATE_TABLE, ALTER_TABLE, DROP_TABLE, ADD_PARTITION, and DROP_PARTITION.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALTER_TABLE</para>
        /// </summary>
        [NameInMap("ChangeType")]
        [Validation(Required=false)]
        public string ChangeType { get; set; }

        /// <summary>
        /// <para>The end date of the table change. Format: yyyy-MM-dd HH:mm:ss.</para>
        /// <list type="bullet">
        /// <item><description>If the date validation fails, the system uses the current time as the end date by default.</description></item>
        /// <item><description>If both the start date and end date fail validation, the system automatically retrieves the table change records from the last 30 days.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2020-06-02 00:00:00</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The type of the changed object. Valid values: TABLE and PARTITION.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TABLE</para>
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// <para>The page number. Used for pagination.</para>
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
        /// <para>The start date of the table change. Format: yyyy-MM-dd HH:mm:ss.</para>
        /// <list type="bullet">
        /// <item><description>If the date validation fails, the system uses the current time as the start date by default.</description></item>
        /// <item><description>If both the start date and end date fail validation, the system automatically retrieves the table change records from the last 30 days.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2020-06-01 00:00:00</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The globally unique identifier (GUID) of the table. Format: odps.projectName.tableName. You can call <a href="https://help.aliyun.com/document_detail/2780086.html">GetMetaDBTableList</a> to obtain the GUID of the table.</para>
        /// <remarks>
        /// <para>Currently, you can call <a href="https://help.aliyun.com/document_detail/2780094.html">GetMetaTableChangeLog</a> to retrieve the change log of only MaxCompute tables.</para>
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
