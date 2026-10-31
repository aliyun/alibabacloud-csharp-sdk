// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetTableColumnsRequest : TeaModel {
        /// <summary>
        /// <para>The catalog of the asset table, which is the name of the business unit or project workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LD_test01_dev</para>
        /// </summary>
        [NameInMap("Catalog")]
        [Validation(Required=false)]
        public string Catalog { get; set; }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>The GUID of the table. If this parameter is specified, it takes precedence in the query, and the Catalog and TableName parameters are ignored even if they are provided.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dp_ds_table_xxx</para>
        /// </summary>
        [NameInMap("TableGuid")]
        [Validation(Required=false)]
        public string TableGuid { get; set; }

        /// <summary>
        /// <para>The name of the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t_test01</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
