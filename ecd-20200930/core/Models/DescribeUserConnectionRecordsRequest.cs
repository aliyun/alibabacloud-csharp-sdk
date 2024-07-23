// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeUserConnectionRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The duration when the cloud desktop is connected, which is the minimum value for condition filtering.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ConnectDurationFrom")]
        [Validation(Required=false)]
        public long? ConnectDurationFrom { get; set; }

        /// <summary>
        /// <para>The duration when the cloud desktop is connected, which is the maximum value for condition filtering.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ConnectDurationTo")]
        [Validation(Required=false)]
        public long? ConnectDurationTo { get; set; }

        /// <summary>
        /// <para>The time when the cloud desktop stops to be connected, which is the minimum value for condition filtering. The value is a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1631266200000</para>
        /// </summary>
        [NameInMap("ConnectEndTimeFrom")]
        [Validation(Required=false)]
        public long? ConnectEndTimeFrom { get; set; }

        /// <summary>
        /// <para>The time when the cloud desktop stops to be connected, which is the maximum value for condition filtering. The value is a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1631268000000</para>
        /// </summary>
        [NameInMap("ConnectEndTimeTo")]
        [Validation(Required=false)]
        public long? ConnectEndTimeTo { get; set; }

        /// <summary>
        /// <para>The time when the cloud desktop starts to be connected, which is the minimum value for condition filtering. The value is a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1631239200000</para>
        /// </summary>
        [NameInMap("ConnectStartTimeFrom")]
        [Validation(Required=false)]
        public long? ConnectStartTimeFrom { get; set; }

        /// <summary>
        /// <para>The time when the cloud desktop starts to be connected, which is the maximum value for condition filtering. The value is a UNIX timestamp. Unit: milliseconds.</para>
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
        /// <para>The type of the user account.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>SIMPLE: convenience account</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>AD_CONNECTOR: enterprise AD account</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SIMPLE</para>
        /// </summary>
        [NameInMap("EndUserType")]
        [Validation(Required=false)]
        public string EndUserType { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Maximum value: 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that determines the start point of the next query. If this parameter is empty, all results are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
