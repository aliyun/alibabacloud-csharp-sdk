// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class DeleteVpdResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed reason why the access was denied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response parameters. (If a dependent resource exists, the existing dependent resource is returned.)</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;subnet&quot;: [
        ///             {
        ///                   &quot;tenantId&quot;: &quot;1620939556166277&quot;,
        ///                   &quot;regionId&quot;: &quot;cn-wulanchabu&quot;,
        ///                   &quot;zoneId&quot;: &quot;cn&quot;,
        ///                   &quot;type&quot;: null,
        ///                   &quot;subnetId&quot;: &quot;subnet-zqebaxa0&quot;,
        ///                   &quot;name&quot;: &quot;lql_testVPD&quot;
        ///             }
        ///       ],
        ///       &quot;nc&quot;: [
        ///             {}
        ///       ]
        /// }</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public object Content { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BDBCC783-84CA-5733-8EEA-645C88B9009C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
