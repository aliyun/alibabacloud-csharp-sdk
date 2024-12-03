// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QuerySkuPriceListRequest : TeaModel {
        /// <summary>
        /// <para>The code of the service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page. You do not need to set this parameter if you query coverage details for the first time. The response returns a token that you can use to query coverage details of the next page. If a null value is returned for the NextPageToken parameter, no more coverage details can be queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>080112060a0422020800180022490a470342000000315333303332363436363336333433393636333136333338333733373333333133373336363336323634363336363337333836333636333636313336363433363332</para>
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// <para>The number of entries to be returned on each page. Maximum value: 50.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The code of the pricing object.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance_type</para>
        /// </summary>
        [NameInMap("PriceEntityCode")]
        [Validation(Required=false)]
        public string PriceEntityCode { get; set; }

        /// <summary>
        /// <para>The conditions of the pricing factors.</para>
        /// </summary>
        [NameInMap("PriceFactorConditionMap")]
        [Validation(Required=false)]
        public Dictionary<string, List<string>> PriceFactorConditionMap { get; set; }

    }

}
