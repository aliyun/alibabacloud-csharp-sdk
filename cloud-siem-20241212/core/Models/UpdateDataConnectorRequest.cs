// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class UpdateDataConnectorRequest : TeaModel {
        /// <summary>
        /// <para>The configuration item ID of the collector access object in the multi-cloud configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Opera20_Salesforce_Prod</para>
        /// </summary>
        [NameInMap("AuthConfigId")]
        [Validation(Required=false)]
        public string AuthConfigId { get; set; }

        /// <summary>
        /// <para>The cloud service to which the authentication configuration belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>salesForceRestAPI</para>
        /// </summary>
        [NameInMap("AuthConfigProduct")]
        [Validation(Required=false)]
        public string AuthConfigProduct { get; set; }

        /// <summary>
        /// <para>The authentication vendor name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SALESFORCE</para>
        /// </summary>
        [NameInMap("AuthConfigVendor")]
        [Validation(Required=false)]
        public string AuthConfigVendor { get; set; }

        /// <summary>
        /// <para>The configuration information of the collector.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;regionId\&quot;:\&quot;cn-hangzhou\&quot;,\&quot;bucket\&quot;:\&quot;actiontrail-logs-1481501495248334-d776c375\&quot;,\&quot;format\&quot;:{\&quot;type\&quot;:\&quot;JSON\&quot;},\&quot;encoding\&quot;:\&quot;UTF-8\&quot;,\&quot;compressFormat\&quot;:\&quot;autoDetect\&quot;,\&quot;interval\&quot;:\&quot;5m\&quot;}</para>
        /// </summary>
        [NameInMap("DataConnectorConfig")]
        [Validation(Required=false)]
        public string DataConnectorConfig { get; set; }

        /// <summary>
        /// <para>The collector ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dc-07423146117d77db266f78bc41f4fd80</para>
        /// </summary>
        [NameInMap("DataConnectorId")]
        [Validation(Required=false)]
        public string DataConnectorId { get; set; }

        /// <summary>
        /// <para>The status of the collector. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>enabled: enabled.</description></item>
        /// <item><description>disabled: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("DataConnectorStatus")]
        [Validation(Required=false)]
        public string DataConnectorStatus { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The data management center of the threat analysis feature. Specify this parameter based on the region where your assets reside. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: Your assets belong to the Chinese mainland and Hong Kong (China).</description></item>
        /// <item><description>ap-southeast-1: Your assets belong to regions outside China.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the member account that the administrator switches to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

    }

}
