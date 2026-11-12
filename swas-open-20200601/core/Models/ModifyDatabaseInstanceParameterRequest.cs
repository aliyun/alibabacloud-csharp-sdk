// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class ModifyDatabaseInstanceParameterRequest : TeaModel {
        /// <summary>
        /// <para>A client-generated token to ensure request idempotence. You must ensure that the token is unique for each request. It can contain only ASCII characters and cannot be longer than 64 characters. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the database instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>db-38263fa955774501a2ae1bdaed6f****</para>
        /// </summary>
        [NameInMap("DatabaseInstanceId")]
        [Validation(Required=false)]
        public string DatabaseInstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to restart the database for the parameter changes to take effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Forces a restart. Set this to true if any modified parameter requires a restart to take effect. Otherwise, the change will not take effect.</para>
        /// </description></item>
        /// <item><description><para>false: Do not force a restart.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ForceRestart")]
        [Validation(Required=false)]
        public bool? ForceRestart { get; set; }

        /// <summary>
        /// <para>A JSON string that specifies the database parameters and their values. The value for each parameter must be a string. Format: <c>{&quot;ParameterName1&quot;:&quot;Value1&quot;,&quot;ParameterName2&quot;:&quot;Value2&quot;,...}</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;delayed_insert_timeout&quot;:&quot;600&quot;,&quot;max_length_for_sort_data&quot;:&quot;2048&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// <para>The region ID of the database instance. Call <a href="https://help.aliyun.com/document_detail/189315.html">ListRegions</a> to view the supported Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
