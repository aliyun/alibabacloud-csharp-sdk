// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class SubscribeBillToOSSRequest : TeaModel {
        /// <summary>
        /// <para>The start billing cycle for pushing. After a successful subscription, the system automatically pushes data from the start billing cycle to the current time. This parameter is invalid for monthly bill PDF subscriptions, and historical data is not re-pushed. Data within the last year can be pushed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-03</para>
        /// </summary>
        [NameInMap("BeginBillingCycle")]
        [Validation(Required=false)]
        public string BeginBillingCycle { get; set; }

        /// <summary>
        /// <para>The UID of the OSS owner that stores the files. Specify this parameter if you are a Bid/Reseller subscriber and need to push files to a sub-account\&quot;s OSS. The specified account must be a sub-account of the calling account, and the AliyunConsumeDump2OSSRole permission must be granted to this account. Regular users do not need to specify this parameter. The default value is the calling account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12341324</para>
        /// </summary>
        [NameInMap("BucketOwnerId")]
        [Validation(Required=false)]
        public long? BucketOwnerId { get; set; }

        /// <summary>
        /// <para>The specified directory under the bucket to which the subscription is delivered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testpath</para>
        /// </summary>
        [NameInMap("BucketPath")]
        [Validation(Required=false)]
        public string BucketPath { get; set; }

        /// <summary>
        /// <para>For multi-level accounts, specifies the type of bills to push. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MA: Pushes bills for the primary account and non-trusteeship linked accounts in the financial cloud.</description></item>
        /// <item><description>ACP1: Pushes bills for Partner Platform V2.0 sub-accounts.</description></item>
        /// </list>
        /// <para>Default value: MA.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MA</para>
        /// </summary>
        [NameInMap("MultAccountRelSubscribe")]
        [Validation(Required=false)]
        public string MultAccountRelSubscribe { get; set; }

        /// <summary>
        /// <para>The maximum number of rows per file. If a bill file exceeds this limit, it is split into multiple files and compressed into a single archive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300000</para>
        /// </summary>
        [NameInMap("RowLimitPerFile")]
        [Validation(Required=false)]
        public int? RowLimitPerFile { get; set; }

        /// <summary>
        /// <para>The name of the OSS bucket that stores the subscribed bill files.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxx-bucket</para>
        /// </summary>
        [NameInMap("SubscribeBucket")]
        [Validation(Required=false)]
        public string SubscribeBucket { get; set; }

        /// <summary>
        /// <para>The type of the subscribed bill. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BillingItemDetailForBillingPeriod: billing item details.</description></item>
        /// <item><description>InstanceDetailForBillingPeriod: instance bill details.</description></item>
        /// <item><description>BillingItemDetailMonthly: billing item summary by billing cycle.</description></item>
        /// <item><description>InstanceDetailMonthly: instance bill summary by billing cycle.</description></item>
        /// <item><description>SplitItemDetailDaily: split bill daily summary.</description></item>
        /// <item><description>MonthBill: monthly bill PDF. Only MA subscription is supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BillingItemDetailForBillingPeriod</para>
        /// </summary>
        [NameInMap("SubscribeType")]
        [Validation(Required=false)]
        public string SubscribeType { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the Secure Sockets Layer (SSL) encryption protocol to protect network communication. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enables SSL encryption to ensure the security and integrity of data transmission.</para>
        /// </description></item>
        /// <item><description><para>false (default): Does not enable SSL encryption.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UsingSsl")]
        [Validation(Required=false)]
        public string UsingSsl { get; set; }

    }

}
