// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class UpdateDataBatchIngestionShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically discover new users.</para>
        /// <list type="bullet">
        /// <item><description><para>enabled: Enables the feature.</para>
        /// </description></item>
        /// <item><description><para>disabled: Disables the feature.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("AutoScanNew")]
        [Validation(Required=false)]
        public string AutoScanNew { get; set; }

        /// <summary>
        /// <para>The mode for batch data ingestion. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>full</para>
        /// </description></item>
        /// <item><description><para>increment</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>full</para>
        /// </summary>
        [NameInMap("DataBatchIngestionMode")]
        [Validation(Required=false)]
        public string DataBatchIngestionMode { get; set; }

        /// <summary>
        /// <para>The list of ingestion policy IDs.</para>
        /// </summary>
        [NameInMap("DataIngestionIds")]
        [Validation(Required=false)]
        public string DataIngestionIdsShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically discover new Logstores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DataSourceRecognizeEnabled")]
        [Validation(Required=false)]
        public bool? DataSourceRecognizeEnabled { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The list of user IDs for batch data ingestion.</para>
        /// </summary>
        [NameInMap("LogUserIds")]
        [Validation(Required=false)]
        public string LogUserIdsShrink { get; set; }

        /// <summary>
        /// <para>The region of the Data Management hub for threat analysis. Select a region for the management hub based on the region of your assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: Your assets are in the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: Your assets are in a region outside China.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The user ID of the member whose perspective the administrator wants to switch to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>173326*******</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

    }

}
