// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeOversizeNonPartitionTableInfosRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-8vb46cpn2aaxxxxxx</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-ddTHH:mm:ssZ</em> format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-03T15:01:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The language of file titles and error messages. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: simplified Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// <item><description><b>ja</b>: Japanese.</description></item>
        /// <item><description><b>zh-tw</b>: traditional Chinese.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The order by which to sort query results. Specify the parameter value in the JSON format. Example: <c>[{&quot;Field&quot;:&quot;SchemaName&quot;,&quot;Type&quot;:&quot;Desc&quot;}]</c>.</para>
        /// <list type="bullet">
        /// <item><description><para><c>Field</c> specifies the field by which to sort the query results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>SchemaName</c>: the name of the database to which the table belongs.</description></item>
        /// <item><description><c>TableName</c>: the name of the table.</description></item>
        /// <item><description><c>IndexSize</c>: the data size of regular indexes.</description></item>
        /// <item><description><c>PrimaryKeySize</c>: the data size of the primary key index.</description></item>
        /// <item><description><c>DataSize</c>: the data size of table records.</description></item>
        /// <item><description><c>LocalDataSize</c>: the size of hot data.</description></item>
        /// <item><description><c>RemoteDataSize</c>: the size of cold data.</description></item>
        /// <item><description><c>SpaceRatio</c>: the storage percentage of the table.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>Type</c> specifies the sorting order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>Asc</c>: ascending order.</description></item>
        /// <item><description><c>Desc</c>: descending order.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para> If you do not specify this parameter, the query results are sorted by the total data size of each table in descending order.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;Field\&quot;:\&quot;SchemaName\&quot;,\&quot;Type\&quot;:\&quot;Asc\&quot;}]</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-09-06T03:06:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
