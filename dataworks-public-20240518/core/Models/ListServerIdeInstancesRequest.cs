// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListServerIdeInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The keyword used to match the instance ID or instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>notebook_dev</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return for a single request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token used to continue the query. You do not need to specify this parameter for the first call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CAESG****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The account ID of the user that owns the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20933221576142****</para>
        /// </summary>
        [NameInMap("RelatedUserId")]
        [Validation(Required=false)]
        public string RelatedUserId { get; set; }

        /// <summary>
        /// <para>The DataWorks resource group identifier. You can use the numeric ID of the resource group or the full identifier in the Serverless_res_group_{tenantId}_{resgId} format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Serverless_res_group_123456789012345_9876543210****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The instance subtype. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PERSONAL_DEV: personal development environment</description></item>
        /// <item><description>DATA_AGENT: Data Agent</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PERSONAL_DEV</para>
        /// </summary>
        [NameInMap("SubType")]
        [Validation(Required=false)]
        public string SubType { get; set; }

    }

}
