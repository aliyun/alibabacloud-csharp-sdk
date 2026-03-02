// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class Pbc : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>基础商品</para>
        /// </summary>
        [NameInMap("alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        [NameInMap("assetType")]
        [Validation(Required=false)]
        public string AssetType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>企业服务</para>
        /// </summary>
        [NameInMap("company")]
        [Validation(Required=false)]
        public string Company { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("companyId")]
        [Validation(Required=false)]
        public long? CompanyId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>基础商品PBC</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("developerId")]
        [Validation(Required=false)]
        public string DeveloperId { get; set; }

        [NameInMap("developerName")]
        [Validation(Required=false)]
        public string DeveloperName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("forkCount")]
        [Validation(Required=false)]
        public int? ForkCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>common</para>
        /// </summary>
        [NameInMap("industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

        [NameInMap("invorkCount")]
        [Validation(Required=false)]
        public long? InvorkCount { get; set; }

        [NameInMap("isWatched")]
        [Validation(Required=false)]
        public bool? IsWatched { get; set; }

        [NameInMap("latestVersionId")]
        [Validation(Required=false)]
        public long? LatestVersionId { get; set; }

        [NameInMap("marketId")]
        [Validation(Required=false)]
        public long? MarketId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>product</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>foundation</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("watchCount")]
        [Validation(Required=false)]
        public long? WatchCount { get; set; }

    }

}
