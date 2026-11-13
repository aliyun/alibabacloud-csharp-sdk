// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListModelApisRequest : TeaModel {
        /// <summary>
        /// <para>The gateway instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-d00000000000000000000</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>Specifies whether to return legacy model APIs created by scenario. If this parameter is omitted or set to false, only APIs created by selecting a model are returned. If this parameter is set to true, APIs created by both methods are returned on the same page, excluding common HTTP, MCP, or Agent APIs.</para>
        /// </summary>
        [NameInMap("includeLegacy")]
        [Validation(Required=false)]
        public bool? IncludeLegacy { get; set; }

        /// <summary>
        /// <para>The search keyword. Supports fuzzy search by API name or exact search by API ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>beta</para>
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The name for exact search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>beta-model-api</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the resource group used to filter results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acf0000000000000000</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
