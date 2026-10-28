// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class SubscriptionBillRequest : TeaModel {
        /// <summary>
        /// <para>The billing month from which to start pushing bills. Format: yyyy-MM.</para>
        /// <para>After a successful subscription, the system automatically pushes data from the start billing cycle to the current time. Data for up to the last six months (including the current month) can be pushed. If the specified month exceeds this range, the subscription is invalid.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-10</para>
        /// </summary>
        [NameInMap("BeginBillingCycle")]
        [Validation(Required=false)]
        public string BeginBillingCycle { get; set; }

        /// <summary>
        /// <para>The bill file format. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>csv</description></item>
        /// <item><description>parquet</description></item>
        /// </list>
        /// <para>If you subscribe to multiple file types, use separate buckets to avoid file overwriting.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>csv</para>
        /// </summary>
        [NameInMap("BillFormat")]
        [Validation(Required=false)]
        public string BillFormat { get; set; }

        /// <summary>
        /// <para>The UID of the account that owns the OSS bucket for storing files.</para>
        /// <para>If a partner subscribes and needs to push files to the OSS bucket of a subordinate partner account, this account must be a subordinate partner account of the partner account. Grant the <a href="https://ram.console.aliyun.com/?spm=api-workbench.API%20Document.0.0.68c71e0fhmTSJp#/role/authorize?request=%7B%22Requests%22:%20%7B%22request1%22:%20%7B%22RoleName%22:%20%22AliyunConsumeDump2OSSRole%22,%20%22TemplateId%22:%20%22Dump2OSSRole%22%7D%7D,%20%22ReturnUrl%22:%20%22https:%2F%2Fusercenter2.aliyun.com%22,%20%22Service%22:%20%22Consume%22%7D">AliyunConsumeDump2OSSRole</a> permission to the subordinate partner account. </para>
        /// <para>If a partner subscribes and pushes files to the partner account\&quot;s own OSS bucket, grant the <a href="https://ram.console.aliyun.com/?spm=api-workbench.API%20Document.0.0.68c71e0fhmTSJp#/role/authorize?request=%7B%22Requests%22:%20%7B%22request1%22:%20%7B%22RoleName%22:%20%22AliyunConsumeDump2OSSRole%22,%20%22TemplateId%22:%20%22Dump2OSSRole%22%7D%7D,%20%22ReturnUrl%22:%20%22https:%2F%2Fusercenter2.aliyun.com%22,%20%22Service%22:%20%22Consume%22%7D">AliyunConsumeDump2OSSRole</a> permission to the partner account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5569414254138836</para>
        /// </summary>
        [NameInMap("BucketOwnerId")]
        [Validation(Required=false)]
        public long? BucketOwnerId { get; set; }

        /// <summary>
        /// <para>The name of the OSS bucket for storing bill files.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bill-bucket</para>
        /// </summary>
        [NameInMap("SubscribeBucket")]
        [Validation(Required=false)]
        public string SubscribeBucket { get; set; }

        /// <summary>
        /// <para>The row count threshold for a single bill file. If the number of rows exceeds this threshold, the file is automatically split into multiple files. The naming convention for split files is <c>uid_billType_billCycle_SquenceNo_fileNo</c>.</para>
        /// <para>All information in the file names is identical except for fileNo. These files belong to the same billing cycle and the same file type but are split into multiple files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100000</para>
        /// </summary>
        [NameInMap("SubscribeSegmentSize")]
        [Validation(Required=false)]
        public int? SubscribeSegmentSize { get; set; }

        /// <summary>
        /// <para>The subscription type. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>PartnerBillingItemDetailForBillingPeriod: billing item detail.</description></item>
        /// <item><description>PartnerBillingItemDetailMonthly: billing item monthly bill.</description></item>
        /// <item><description>PartnerInstanceDetailForBillingPeriod: instance bill detail.</description></item>
        /// <item><description>PartnerInstanceDetailMonthly: instance monthly bill.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PartnerBillingItemDetailForBillingPeriod</para>
        /// </summary>
        [NameInMap("SubscribeType")]
        [Validation(Required=false)]
        public string SubscribeType { get; set; }

    }

}
