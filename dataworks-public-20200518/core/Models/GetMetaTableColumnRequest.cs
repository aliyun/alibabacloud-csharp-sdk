// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMetaTableColumnRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the E-MapReduce (EMR) cluster. You can log on to the EMR console to obtain the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C-010A704DA760****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The type of the data source. Set the value to emr.</para>
        /// 
        /// <b>Example:</b>
        /// <para>emr</para>
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <para>The name of the metadatabase of the EMR cluster. You can call the <a href="https://help.aliyun.com/document_detail/2780105.html">ListMetaDB</a> operation to query the name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

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
        /// <para>The GUID of the metatable. You can call the <a href="https://help.aliyun.com/document_detail/2780086.html">GetMetaDBTableList</a> operation to query the GUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>odps.engine_name.table_name</para>
        /// </summary>
        [NameInMap("TableGuid")]
        [Validation(Required=false)]
        public string TableGuid { get; set; }

        /// <summary>
        /// <para>The name of the metatable in the EMR cluster. You can call the <a href="https://help.aliyun.com/document_detail/2780086.html">GetMetaDBTableList</a> operation to query the name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
