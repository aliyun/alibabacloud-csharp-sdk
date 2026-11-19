// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class AddDataSourceRequest : TeaModel {
        /// <summary>
        /// <para>You can refer to the logic of adding a data source on the Quick BI data source page. When you click <b>Test Connection</b>, the <c>restapi/datasource/detect</c> API operation is triggered. Simulate the request payload of this API operation by passing a JSON object of the same model, along with a valid <c>userId</c> and workspace ID in Quick BI. In version 7.1, the <c>userAsOwner</c> parameter is added. If you set this parameter to true, the data source is created as the specified <c>userId</c>.
        /// <notice>A small number of data sources are not supported. If the parameters are the same as the request payload of the test API operation but the data source still fails to be added, the current data source type does not support creation through this API operation.</notice>
        /// <notice>Do not pass the <c>encode</c> parameter. Currently, this API operation does not support encryption mode for creating data sources, and authentication that involves uploading files is not supported.</notice></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;userId&quot;: &quot;235345xxxxx24336&quot;,
        ///   &quot;userAsOwner&quot;:true,
        ///   &quot;workspaceId&quot;: &quot;235345xxxxx24336&quot;,
        ///   &quot;dsType&quot;: &quot;postgresql&quot;,
        ///   &quot;config&quot;: {
        ///     &quot;category&quot;: &quot;local&quot;,
        ///     &quot;customDriverId&quot;: null,
        ///     &quot;ssl&quot;: false,
        ///     &quot;uploadFile&quot;: true,
        ///     &quot;sslConfig&quot;: null
        ///   },
        ///   &quot;showName&quot;: &quot;test&quot;,
        ///   &quot;address&quot;: &quot;test&quot;,
        ///   &quot;port&quot;: &quot;5432&quot;,
        ///   &quot;instance&quot;: &quot;postgres&quot;,
        ///   &quot;schema&quot;: &quot;public&quot;,
        ///   &quot;userName&quot;: &quot;13<b><b>34&quot;,
        ///   &quot;password&quot;: &quot;12</b></b>425&quot;,
        /// }</para>
        /// </summary>
        [NameInMap("AddModel")]
        [Validation(Required=false)]
        public string AddModel { get; set; }

    }

}
