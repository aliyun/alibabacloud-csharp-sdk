// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>A list of anomalous activities.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeEventsResponseBodyItems> Items { get; set; }
        public class DescribeEventsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The time when an alert was generated for the anomalous activity. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>154529000</para>
            /// </summary>
            [NameInMap("AlertTime")]
            [Validation(Required=false)]
            public long? AlertTime { get; set; }

            /// <summary>
            /// <para>Indicates whether enhanced detection is enabled for the anomalous activity. Enhanced detection improves detection accuracy and the alert reporting rate.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enhanced detection is enabled.</para>
            /// </description></item>
            /// <item><description><para>false: Enhanced detection is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Backed")]
            [Validation(Required=false)]
            public bool? Backed { get; set; }

            /// <summary>
            /// <para>The display name of the account that handled the anomalous activity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yundunsr</para>
            /// </summary>
            [NameInMap("DealDisplayName")]
            [Validation(Required=false)]
            public string DealDisplayName { get; set; }

            /// <summary>
            /// <para>The logon name of the account that handled the anomalous activity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>det1111</para>
            /// </summary>
            [NameInMap("DealLoginName")]
            [Validation(Required=false)]
            public string DealLoginName { get; set; }

            /// <summary>
            /// <para>The time when the anomalous activity was handled. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12223300</para>
            /// </summary>
            [NameInMap("DealTime")]
            [Validation(Required=false)]
            public long? DealTime { get; set; }

            /// <summary>
            /// <para>The ID of the account that handled the anomalous activity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>229157443385014***</para>
            /// </summary>
            [NameInMap("DealUserId")]
            [Validation(Required=false)]
            public long? DealUserId { get; set; }

            /// <summary>
            /// <para>The display name of the account that performed the operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yundunsr</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The time when the anomalous activity occurred. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1545829129000</para>
            /// </summary>
            [NameInMap("EventTime")]
            [Validation(Required=false)]
            public long? EventTime { get; set; }

            /// <summary>
            /// <para>The unique ID of the anomalous activity that is recorded in Data Security Center (DSC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>42233335555</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The logon name of the account that performed the operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>det1111</para>
            /// </summary>
            [NameInMap("LoginName")]
            [Validation(Required=false)]
            public string LoginName { get; set; }

            /// <summary>
            /// <para>The service to which the anomalous activity belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The processing status of the anomalous activity.</para>
            /// <list type="bullet">
            /// <item><description><para>0: Unhandled.</para>
            /// </description></item>
            /// <item><description><para>1: Confirmed.</para>
            /// </description></item>
            /// <item><description><para>2: Dismissed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The name of the processing status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Pending</para>
            /// </summary>
            [NameInMap("StatusName")]
            [Validation(Required=false)]
            public string StatusName { get; set; }

            /// <summary>
            /// <para>The code of the child type of the anomalous activity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>020008</para>
            /// </summary>
            [NameInMap("SubTypeCode")]
            [Validation(Required=false)]
            public string SubTypeCode { get; set; }

            /// <summary>
            /// <para>The name of the child type of the anomalous activity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Abnormal data download volume</para>
            /// </summary>
            [NameInMap("SubTypeName")]
            [Validation(Required=false)]
            public string SubTypeName { get; set; }

            /// <summary>
            /// <para>The destination service for the anomalous data flow event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("TargetProductCode")]
            [Validation(Required=false)]
            public string TargetProductCode { get; set; }

            /// <summary>
            /// <para>The code of the parent type of the anomalous activity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>02</para>
            /// </summary>
            [NameInMap("TypeCode")]
            [Validation(Required=false)]
            public string TypeCode { get; set; }

            /// <summary>
            /// <para>The name of the parent type of the anomalous activity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Abnormal data flow</para>
            /// </summary>
            [NameInMap("TypeName")]
            [Validation(Required=false)]
            public string TypeName { get; set; }

            /// <summary>
            /// <para>The ID of the account that performed the operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1978132506596***</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

            /// <summary>
            /// <para>The risk level of the anomalous activity.</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: Low.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Medium.</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: High.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("WarnLevel")]
            [Validation(Required=false)]
            public int? WarnLevel { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>769FB3C1-F4C9-42DF-9B72-7077A8989C13</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
