// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAIDBClusterDatasetsRequest : TeaModel {
        /// <summary>
        /// <para>The token used to retrieve the next page of results. This value is obtained from the response of a previous request. For the first request, leave this parameter empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EFSDF-DF-***</para>
        /// </summary>
        [NameInMap("ContinuationToken")]
        [Validation(Required=false)]
        public string ContinuationToken { get; set; }

        /// <summary>
        /// <para>The ID of the PolarDB cluster for AI model services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-2ze88***</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The dataset ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pds-2ze88***</para>
        /// </summary>
        [NameInMap("DatasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

        /// <summary>
        /// <para>The type of the dataset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>train</b>: The training set.</para>
        /// </description></item>
        /// <item><description><para><b>eval</b>: The evaluation set.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>train</para>
        /// </summary>
        [NameInMap("DatasetType")]
        [Validation(Required=false)]
        public string DatasetType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number to return. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: <b>30</b>, <b>50</b>, and <b>100</b>.</para>
        /// <para>Default value: <b>30</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
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
        /// <para>The training mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>sft</b>: supervised fine-tuning.</para>
        /// </description></item>
        /// <item><description><para><b>grpo</b>: reinforcement learning.</para>
        /// </description></item>
        /// <item><description><para><b>text</b>: text generation.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>grpo</para>
        /// </summary>
        [NameInMap("TrainMode")]
        [Validation(Required=false)]
        public string TrainMode { get; set; }

    }

}
