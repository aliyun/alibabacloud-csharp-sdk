// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListDataIngestionsRequest : TeaModel {
        /// <summary>
        /// <para>An array of data ingestion policy IDs.</para>
        /// </summary>
        [NameInMap("DataIngestionIds")]
        [Validation(Required=false)]
        public List<string> DataIngestionIds { get; set; }

        /// <summary>
        /// <para>The data ingestion status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>enabled</c>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><c>disabled</c>: Disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("DataIngestionStatus")]
        [Validation(Required=false)]
        public string DataIngestionStatus { get; set; }

        /// <summary>
        /// <para>An array of data ingestion template IDs.</para>
        /// </summary>
        [NameInMap("DataIngestionTemplateIds")]
        [Validation(Required=false)]
        public List<string> DataIngestionTemplateIds { get; set; }

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
        /// <para>An array of normalization schema IDs.</para>
        /// </summary>
        [NameInMap("NormalizationSchemaIds")]
        [Validation(Required=false)]
        public List<string> NormalizationSchemaIds { get; set; }

        /// <summary>
        /// <para>The product ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alibaba_cloud_sas</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>The region where the threat analysis feature is deployed. Select the region that corresponds to the location of your asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>cn-hangzhou</c>: Your asset is in the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para><c>ap-southeast-1</c>: Your asset is in a region outside the Chinese mainland.</para>
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
        /// <para>The user ID of a member. An administrator can use this parameter to query data as the specified member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>173326*******</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

    }

}
