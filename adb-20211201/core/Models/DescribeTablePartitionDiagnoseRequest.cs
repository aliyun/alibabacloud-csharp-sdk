// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeTablePartitionDiagnoseRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp171g24yvbxxxxx</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Specifies the language of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// <item><description><b>ja</b>: Japanese</description></item>
        /// <item><description><b>zh-tw</b>: Traditional Chinese</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Sorts the query results by a specified field. The value must be a JSON string. Example: <c>[{&quot;Field&quot;:&quot;TotalSize&quot;,&quot;Type&quot;:&quot;Desc&quot;}]</c>. The JSON string contains the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><c>Field</c>: the field by which to sort the results. Valid values:<list type="bullet">
        /// <item><description><c>SchemaName</c>: the name of the database to which the table belongs.</description></item>
        /// <item><description><c>TableName</c>: the table name.</description></item>
        /// <item><description><c>TotalSize</c>: the total data volume.</description></item>
        /// <item><description><c>SpaceRatio</c>: the storage space proportion.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><c>Type</c>: the sort order. Valid values:<list type="bullet">
        /// <item><description><c>Asc</c>: ascending order.</description></item>
        /// <item><description><c>Desc</c>: descending order.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is not specified, the results are sorted in descending order of the total data volume of the target table by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Field&quot;:&quot;TotalSize&quot;,&quot;Type&quot;:&quot;Desc&quot;}]</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

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
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
