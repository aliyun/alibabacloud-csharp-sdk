// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListDataCenterTableRequest : TeaModel {
        /// <summary>
        /// <para>For frontend use only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>仅前端使用</para>
        /// </summary>
        [NameInMap("CallFrom")]
        [Validation(Required=false)]
        public string CallFrom { get; set; }

        /// <summary>
        /// <para>The name of the database.</para>
        /// <list type="bullet">
        /// <item><description>If <c>ImportType</c> is <c>FILE</c>, this parameter represents the file name.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>diamonds.csv</para>
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>The current DMS unit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DmsUnit")]
        [Validation(Required=false)]
        public string DmsUnit { get; set; }

        /// <summary>
        /// <para>The import type.</para>
        /// <list type="bullet">
        /// <item><description>FILE</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FILE</para>
        /// </summary>
        [NameInMap("ImportType")]
        [Validation(Required=false)]
        public string ImportType { get; set; }

        /// <summary>
        /// <para>The name of the instance.</para>
        /// <list type="bullet">
        /// <item><description>If <c>ImportType</c> is <c>FILE</c>, this parameter represents the file ID of the data center.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>f-ean8u5881qk4*********xh5y</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The page number, starting from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records to return per page. Default: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The keyword for a fuzzy search of database tables.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdb</para>
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        /// <summary>
        /// <para>The name of the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>diamonds</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
