// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListIpsecServerLogsRequest : TeaModel {
        /// <summary>
        /// <para>The beginning of the time range to query. The value must be a UNIX timestamp. For example, 1671003744 specifies 15:42:24 (UTC+8) on December 14, 2022.</para>
        /// <remarks>
        /// <para> If you specify <b>From</b>, you must also specify <b>To</b> or <b>MinutePeriod</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1671003744</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public int? From { get; set; }

        /// <summary>
        /// <para>The ID of the IPsec server.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iss-2zei2n5q5zhirfh73****</para>
        /// </summary>
        [NameInMap("IpsecServerId")]
        [Validation(Required=false)]
        public string IpsecServerId { get; set; }

        /// <summary>
        /// <para>The interval at which log data is queried. Valid values: <b>1</b> to <b>10</b>. Unit: minutes.</para>
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
        /// <para>The number of entries to return on each page. Valid values: <b>1</b> to <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region where the IPsec server is created.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to obtain the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The value must be a unix timestamp. For example, 1671004344 specifies 15:52:24 (UTC+8) on December 14, 2022.</para>
        /// <remarks>
        /// <para> If you specify <b>To</b>, you must also specify <b>From</b> or <b>MinutePeriod</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1671004344</para>
        /// </summary>
        [NameInMap("To")]
        [Validation(Required=false)]
        public int? To { get; set; }

    }

}
