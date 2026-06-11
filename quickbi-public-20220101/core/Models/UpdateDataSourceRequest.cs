// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class UpdateDataSourceRequest : TeaModel {
        /// <summary>
        /// <para>A JSON-formatted string defining the data source configuration to update. See the example for the specific format. The JSON string includes the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><para><c>dsId</c>: Required. The ID of the data source.</para>
        /// </description></item>
        /// <item><description><para><c>userId</c>: Optional. The Quick BI user ID of the user who modifies the data source. If you specify this parameter, the update runs as this user.</para>
        /// </description></item>
        /// <item><description><para><c>dsType</c>: Required. The type of the data source. This value cannot be changed and must match the existing data source type.</para>
        /// </description></item>
        /// <item><description><para><c>showName</c>: Optional. The display name of the data source.</para>
        /// </description></item>
        /// <item><description><para><c>address</c>: Optional. The database connection endpoint, which can be a domain name or an IP address.</para>
        /// </description></item>
        /// <item><description><para><c>port</c>: Optional. The connection port for the database.</para>
        /// </description></item>
        /// <item><description><para><c>schema</c>: Optional. The database schema. This parameter is required only for database types that support schemas. For example, the default schema for SQL Server is <c>dbo</c>, while MySQL does not use schemas.</para>
        /// </description></item>
        /// <item><description><para><c>instance</c>: Optional. The database instance.</para>
        /// </description></item>
        /// <item><description><para><c>username</c>: Optional. The username for the database account or the AccessKey ID.</para>
        /// </description></item>
        /// <item><description><para><c>password</c>: Optional. The password for the database account.</para>
        /// </description></item>
        /// <item><description><para><c>resource</c>: Specifies the VPC type. This parameter is required if you are using a VPC connection. If the data source was created with VPC settings, you must include this parameter in your update request. Omitting this parameter from the request disables the VPC connection. For a list of <c>resource</c> values, see the <b>Additional information</b> section below.</para>
        /// </description></item>
        /// <item><description><para><c>accessId</c>: Optional. The AccessKey ID for the VPC instance. This parameter is required if the <c>resource</c> parameter is specified.</para>
        /// </description></item>
        /// <item><description><para><c>accessKey</c>: Optional. The AccessKey secret for the VPC instance. This parameter is required if the <c>resource</c> parameter is specified.</para>
        /// </description></item>
        /// <item><description><para><c>instanceId</c>: Optional. The ID of the VPC instance. This parameter is required if the <c>resource</c> parameter is specified.</para>
        /// </description></item>
        /// <item><description><para><c>region</c>: Optional. The region where the VPC instance is located. This parameter is required if the <c>resource</c> parameter is specified. For a list of region IDs, see the <b>Additional information</b> section below.</para>
        /// </description></item>
        /// <item><description><para><c>config</c>: Optional. A JSON object that contains additional configuration parameters for the database. You only need to include the fields that you want to update. Any field that you include is updated to the new value, even if it is an empty string. Fields that are not included in the request remain unchanged.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;schema&quot;: &quot;schema&quot;,
        ///     &quot;userId&quot;:&quot;S<em><b><b>46345&quot;,
        ///     &quot;password&quot;: &quot;Ta</b></b>34&quot;,
        ///     &quot;showName&quot;: &quot;test&quot;,
        ///     &quot;address&quot;: &quot;11****</em>.55&quot;,
        ///     &quot;instance&quot;: &quot;quickbi_test&quot;,
        ///     &quot;dsId&quot;: &quot;34d6d******3ca8ac267&quot;,
        ///     &quot;port&quot;: &quot;3306&quot;,
        ///     &quot;dsType&quot;: &quot;mysql&quot;,
        ///     &quot;username&quot;: &quot;root&quot;,
        ///     &quot;config&quot;:  {
        ///         &quot;initialSql&quot;: &quot;Set timezone = \&quot;-10\&quot;&quot;
        ///     }
        /// }</para>
        /// </summary>
        [NameInMap("UpdateModel")]
        [Validation(Required=false)]
        public string UpdateModel { get; set; }

    }

}
