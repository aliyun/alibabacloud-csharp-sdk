// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ConfigureMigrationJobAlertRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Alibaba Cloud account. You do not need to specify this parameter. This parameter will be deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12323344****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The mobile phone numbers of contacts for latency alerts. Separate multiple mobile phone numbers with commas (,).</para>
        /// <para>This parameter is supported only on the China site (aliyun.com) and supports only Chinese mainland mobile phone numbers. You can specify up to 10 mobile phone numbers.
        /// The China site does not support phone alerts. You can configure alert rules for DTS tasks only in the CloudMonitor console.</para>
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
        /// <para>The threshold for triggering a latency alert. Unit: seconds. The value must be an integer. Set the threshold based on your business requirements. To avoid latency fluctuations caused by network conditions or database loads, set the threshold to 10 seconds or more.</para>
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
        /// <para>This parameter is supported only on the China site (aliyun.com) and supports only Chinese mainland mobile phone numbers. You can specify up to 10 mobile phone numbers.
        /// The international site does not support phone alerts. You can configure alert rules for DTS tasks only in the CloudMonitor console.</para>
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
        /// <item><description>After you enable the exception status monitoring feature, an alert is triggered when an exception is detected.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("ErrorAlertStatus")]
        [Validation(Required=false)]
        public string ErrorAlertStatus { get; set; }

        /// <summary>
        /// <para>Instance ID of the data migration instance. You can call the <b>DescribeMigrationJobs</b> operation to query instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtslb9113qq11n****</para>
        /// </summary>
        [NameInMap("MigrationJobId")]
        [Validation(Required=false)]
        public string MigrationJobId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the data migration instance resides. For more information, see the supported region list.</para>
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

    }

}
