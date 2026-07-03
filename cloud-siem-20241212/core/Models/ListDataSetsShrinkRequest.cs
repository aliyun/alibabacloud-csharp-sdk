// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListDataSetsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dataset-qt0n8246gs9nackg****</para>
        /// </summary>
        [NameInMap("DataSetId")]
        [Validation(Required=false)]
        public string DataSetId { get; set; }

        /// <summary>
        /// <para>The list of dataset IDs.</para>
        /// </summary>
        [NameInMap("DataSetIds")]
        [Validation(Required=false)]
        public string DataSetIdsShrink { get; set; }

        /// <summary>
        /// <para>The name of the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lmftest</para>
        /// </summary>
        [NameInMap("DataSetName")]
        [Validation(Required=false)]
        public string DataSetName { get; set; }

        /// <summary>
        /// <para>The status of the dataset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: deleted.</para>
        /// </description></item>
        /// <item><description><para>1: enabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DataSetStatus")]
        [Validation(Required=false)]
        public int? DataSetStatus { get; set; }

        /// <summary>
        /// <para>The type of the dataset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>custom: custom.</para>
        /// </description></item>
        /// <item><description><para>preset: predefined.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("DataSetType")]
        [Validation(Required=false)]
        public string DataSetType { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return for the request. This parameter is used for queries that use NextToken. Valid values: 1 to 100. Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to start the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAUqcj6VO4E3ECWIrFczs****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>asc</b> (default): ascending.</para>
        /// </description></item>
        /// <item><description><para><b>desc</b>: descending.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("OrderDirection")]
        [Validation(Required=false)]
        public string OrderDirection { get; set; }

        /// <summary>
        /// <para>The field to use for sorting. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>GmtCreate: creation time.</para>
        /// </description></item>
        /// <item><description><para>GmtModified: update time.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreate</para>
        /// </summary>
        [NameInMap("OrderFieldName")]
        [Validation(Required=false)]
        public string OrderFieldName { get; set; }

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
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region where the Data Management Center for threat analysis is deployed. Select a region based on the location of your assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: Your assets are in the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: Your assets are in a region outside China.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The user ID that an administrator uses to switch to the perspective of a member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

    }

}
