// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpnSslServerLogsRequest : TeaModel {
        /// <summary>
        /// <para>The beginning of the time range to query. The value must be a unix timestamp. For example, 1600738962 specifies 09:42:42 (UTC+8) on September 22, 2020.</para>
        /// <remarks>
        /// <para> If you specify <b>From</b>, you must also specify <b>To</b> or <b>MinutePeriod</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1600738962</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public int? From { get; set; }

        /// <summary>
        /// <para>The interval at which log data is queried. Unit: minutes.</para>
        /// <remarks>
        /// <para> If both <b>From</b> and <b>To</b> are not specified, you must specify <b>MinutePeriod</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MinutePeriod")]
        [Validation(Required=false)]
        public int? MinutePeriod { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Maximum value: <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region where the SSL server is created. You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
        /// <para>The ID of the SSL client certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsc-m5euof6s5jy8vs5kd****</para>
        /// </summary>
        [NameInMap("SslVpnClientCertId")]
        [Validation(Required=false)]
        public string SslVpnClientCertId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The value must be a unix timestamp. For example, 1600738962 specifies 09:42:42 (UTC+8) on September 22, 2020.</para>
        /// <remarks>
        /// <para> If you specify <b>To</b>, you must also specify <b>From</b> or <b>MinutePeriod</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1600738962</para>
        /// </summary>
        [NameInMap("To")]
        [Validation(Required=false)]
        public int? To { get; set; }

        /// <summary>
        /// <para>The ID of the SSL server.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vss-bp155e9yclsg1xgq4****</para>
        /// </summary>
        [NameInMap("VpnSslServerId")]
        [Validation(Required=false)]
        public string VpnSslServerId { get; set; }

    }

}
