// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class DescribeClientsRequest : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud account ID.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("CallerAliUid")]
        [Validation(Required=false)]
        public string CallerAliUid { get; set; }

        /// <summary>
        /// <para>The client type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public int? ClientType { get; set; }

        /// <summary>
        /// <para>The custom task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cr-***</para>
        /// </summary>
        [NameInMap("CustomResourceId")]
        [Validation(Required=false)]
        public string CustomResourceId { get; set; }

        /// <summary>
        /// <para>The effective status of the custom task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: effective.</description></item>
        /// <item><description>false: ineffective.</description></item>
        /// <item><description>null: all.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("CustomResourceStatus")]
        [Validation(Required=false)]
        public bool? CustomResourceStatus { get; set; }

        /// <summary>
        /// <para>Specifies whether the client is managed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("InManage")]
        [Validation(Required=false)]
        public bool? InManage { get; set; }

        /// <summary>
        /// <para>Specifies whether to include subgroups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeSubGroups")]
        [Validation(Required=false)]
        public bool? IncludeSubGroups { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The device model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>US02-2BFXG</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The token for the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdEdsXbwG2ZlbWCzN4wTTg6wQvfp7u1BJl4bxCAby41POSaYAlCvfULQpkAnb0ff****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The soft client status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("OnlineStatus")]
        [Validation(Required=false)]
        public bool? OnlineStatus { get; set; }

        /// <summary>
        /// <para>The soft client platform.</para>
        /// 
        /// <b>Example:</b>
        /// <para>linux</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <para>The fuzzy search parameter. Supports fuzzy search by SN, alias, or IP address. This parameter is incompatible with exact search parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>061</para>
        /// </summary>
        [NameInMap("SearchKeyword")]
        [Validation(Required=false)]
        public string SearchKeyword { get; set; }

        /// <summary>
        /// <para>The group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tg-bp103v8x70nasykdjrd1</para>
        /// </summary>
        [NameInMap("TerminalGroupId")]
        [Validation(Required=false)]
        public string TerminalGroupId { get; set; }

        /// <summary>
        /// <para>The UUIDs of the servers to query. Separate multiple UUIDs with commas (,).</para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public List<string> Uuids { get; set; }

        /// <summary>
        /// <para>Specifies whether to return bound users.</para>
        /// </summary>
        [NameInMap("WithBindUser")]
        [Validation(Required=false)]
        public bool? WithBindUser { get; set; }

    }

}
