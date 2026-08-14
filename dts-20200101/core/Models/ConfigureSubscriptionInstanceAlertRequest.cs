// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ConfigureSubscriptionInstanceAlertRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Alibaba Cloud account. You do not need to specify this parameter because it will be deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12323344****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The mobile phone numbers of contacts for latency alerts. Separate multiple mobile phone numbers with commas (,).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is supported only on the China site (aliyun.com). Only Chinese mainland mobile phone numbers are supported, and you can specify up to 10 mobile phone numbers.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>China site (Chinese mainland) does not support Chinese mainland mobile phone alerts. You can only <a href="https://help.aliyun.com/document_detail/175876.html">configure alert rules for DTS tasks in CloudMonitor</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1361234****,1371234****</para>
        /// </summary>
        [NameInMap("DelayAlertPhone")]
        [Validation(Required=false)]
        public string DelayAlertPhone { get; set; }

        /// <summary>
        /// <para>Specifies whether to monitor the latency status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>enable</b>: yes.</description></item>
        /// <item><description><b>disable</b>: no.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Default value: <b>enable</b>.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You must specify at least one of this parameter and the <b>ErrorAlertStatus</b> parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("DelayAlertStatus")]
        [Validation(Required=false)]
        public string DelayAlertStatus { get; set; }

        /// <summary>
        /// <para>The threshold for triggering a latency alert. Unit: seconds. The value must be an integer. Set the threshold based on your business requirements. To avoid alert fluctuations caused by network issues or database loads, set the threshold to 10 seconds or more.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>DelayAlertStatus</b> is set to <b>enable</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("DelayOverSeconds")]
        [Validation(Required=false)]
        public string DelayOverSeconds { get; set; }

        /// <summary>
        /// <para>The mobile phone numbers of contacts for exception alerts. Separate multiple mobile phone numbers with commas (,).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is supported only on the China site (aliyun.com). Only Chinese mainland mobile phone numbers are supported, and you can specify up to 10 mobile phone numbers.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>China site (Chinese mainland) does not support Chinese mainland mobile phone alerts. You can only <a href="https://help.aliyun.com/document_detail/175876.html">configure alert rules for DTS tasks in CloudMonitor</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1361234****,1371234****</para>
        /// </summary>
        [NameInMap("ErrorAlertPhone")]
        [Validation(Required=false)]
        public string ErrorAlertPhone { get; set; }

        /// <summary>
        /// <para>Specifies whether to monitor the exception status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>enable</b>: yes.</description></item>
        /// <item><description><b>disable</b>: no.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Default value: <b>enable</b>.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You must specify at least one of this parameter and the <b>DelayAlertStatus</b> parameter.</description></item>
        /// <item><description>After you enable exception status monitoring, an alert is triggered when an exception is detected.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("ErrorAlertStatus")]
        [Validation(Required=false)]
        public string ErrorAlertStatus { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the change tracking instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the change tracking instance. You can call the DescribeSubscriptionInstances operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtsl8zl9ek6292****</para>
        /// </summary>
        [NameInMap("SubscriptionInstanceId")]
        [Validation(Required=false)]
        public string SubscriptionInstanceId { get; set; }

    }

}
