// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeUserConnectionRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The minimum connection duration used as a filter condition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ConnectDurationFrom")]
        [Validation(Required=false)]
        public long? ConnectDurationFrom { get; set; }

        /// <summary>
        /// <para>The maximum connection duration used as a filter condition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ConnectDurationTo")]
        [Validation(Required=false)]
        public long? ConnectDurationTo { get; set; }

        /// <summary>
        /// <para>The minimum end time of the connection used as a filter condition. The time is formatted as a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1631266200000</para>
        /// </summary>
        [NameInMap("ConnectEndTimeFrom")]
        [Validation(Required=false)]
        public long? ConnectEndTimeFrom { get; set; }

        /// <summary>
        /// <para>The maximum end time of the connection used as a filter condition. The time is formatted as a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1631268000000</para>
        /// </summary>
        [NameInMap("ConnectEndTimeTo")]
        [Validation(Required=false)]
        public long? ConnectEndTimeTo { get; set; }

        /// <summary>
        /// <para>The minimum start time of the connection used as a filter condition. The time is formatted as a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1631239200000</para>
        /// </summary>
        [NameInMap("ConnectStartTimeFrom")]
        [Validation(Required=false)]
        public long? ConnectStartTimeFrom { get; set; }

        /// <summary>
        /// <para>The maximum start time of the connection used as a filter condition. The time is formatted as a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1631241000000</para>
        /// </summary>
        [NameInMap("ConnectStartTimeTo")]
        [Validation(Required=false)]
        public long? ConnectStartTimeTo { get; set; }

        /// <summary>
        /// <para>The ID of the cloud computer pool.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dg-2i8qxpv6t1a03****</para>
        /// </summary>
        [NameInMap("DesktopGroupId")]
        [Validation(Required=false)]
        public string DesktopGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the cloud computer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-138dsptkrt00u****</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        /// <summary>
        /// <para>The ID of the authorized user.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>The type of the user account system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SIMPLE</para>
        /// </summary>
        [NameInMap("EndUserType")]
        [Validation(Required=false)]
        public string EndUserType { get; set; }

        /// <summary>
        /// <para>The number of entries to return per page in a paging query.
        /// Maximum value: 100.
        /// Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token used to start the next query. An empty NextToken indicates that no more results are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> to query the list of regions supported by Elastic Desktop Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
