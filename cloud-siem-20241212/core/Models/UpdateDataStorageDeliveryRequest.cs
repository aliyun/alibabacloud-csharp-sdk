// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class UpdateDataStorageDeliveryRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response message. Valid values:</para>
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
        /// <para>The log code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aegis-log-login</para>
        /// </summary>
        [NameInMap("LogCode")]
        [Validation(Required=false)]
        public string LogCode { get; set; }

        /// <summary>
        /// <para>The status of log delivery. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>enable: Enables log delivery.</para>
        /// </description></item>
        /// <item><description><para>disable: Disables log delivery.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("LogDeliveryStatus")]
        [Validation(Required=false)]
        public string LogDeliveryStatus { get; set; }

        /// <summary>
        /// <para>The region where the Data Management hub for Threat Analysis is located. Select the region of the management hub based on the region of your asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: Your asset is in the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: Your asset is in a region outside China.</para>
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
        /// <para>The user ID of the member. This parameter is used when an administrator switches to the perspective of a member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

    }

}
