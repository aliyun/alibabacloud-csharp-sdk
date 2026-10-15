// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QuerySkuPriceListShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The commodity code. You can call the <b>QueryCommodityList</b> operation to query the commodity code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// <para>The language. Default value: zh (Chinese).</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The pagination token. Leave this parameter empty for the first page query. The query result returns a token for the next page. An empty token in the result indicates that all data has been retrieved. You can obtain the next page token from the <b>NextPageToken</b> field in the query result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>080112060a0422020800180022490a470342000000315333303332363436363336333433393636333136333338333733373333333133373336363336323634363336363337333836333636333636313336363433363332</para>
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: 50.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The pricing entity code. You can call the <b>QueryPriceEntityList</b> operation to query the pricing entity code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance_type</para>
        /// </summary>
        [NameInMap("PriceEntityCode")]
        [Validation(Required=false)]
        public string PriceEntityCode { get; set; }

        /// <summary>
        /// <para>The collection of pricing factor conditions. You can call the <b>QueryPriceEntityList</b> operation to query pricing factor codes and pricing factor values.</para>
        /// </summary>
        [NameInMap("PriceFactorConditionMap")]
        [Validation(Required=false)]
        public string PriceFactorConditionMapShrink { get; set; }

    }

}
