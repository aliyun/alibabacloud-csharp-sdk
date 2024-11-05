// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeInstanceAutoRenewalAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about returned entries.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeInstanceAutoRenewalAttributeResponseBodyItems Items { get; set; }
        public class DescribeInstanceAutoRenewalAttributeResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<DescribeInstanceAutoRenewalAttributeResponseBodyItemsItem> Item { get; set; }
            public class DescribeInstanceAutoRenewalAttributeResponseBodyItemsItem : TeaModel {
                /// <summary>
                /// <para>Indicates whether auto-renewal is enabled for the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Auto-renewal is enabled for the instance.</description></item>
                /// <item><description><b>false</b>: Auto-renewal is disabled for the instance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AutoRenew")]
                [Validation(Required=false)]
                public string AutoRenew { get; set; }

                /// <summary>
                /// <para>The category of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>replicate</b>: the standalone or replica set instance</description></item>
                /// <item><description><b>sharding</b>: the sharded cluster instance</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>replicate</para>
                /// </summary>
                [NameInMap("DBInstanceType")]
                [Validation(Required=false)]
                public string DBInstanceType { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dds-bp2568*****</para>
                /// </summary>
                [NameInMap("DbInstanceId")]
                [Validation(Required=false)]
                public string DbInstanceId { get; set; }

                /// <summary>
                /// <para>The auto-renewal period. Unit: months.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>This parameter is ruturned only when the returned value of the <b>AutoRenew</b> parameter is <b>true</b>.</description></item>
                /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/145979.html">ModifyInstanceAutoRenewalAttribute</a> operation to modify the auto-renewal period.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                /// <summary>
                /// <para>The region ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ItemsNumbers")]
        [Validation(Required=false)]
        public int? ItemsNumbers { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries that were returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FAB5CB3B-DB9D-473A-9DF1-F57B6B9CB949</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
