// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class SaveDataServiceApiTestResultRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the API. You can obtain the ID by calling the <a href="https://help.aliyun.com/document_detail/174012.html">ListDataServiceApis</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>417381955954827</para>
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public long? ApiId { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the system to automatically generate results. If the resultSample and failResultSample parameters are not specified, the system generates default results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoGenerate")]
        [Validation(Required=false)]
        public bool? AutoGenerate { get; set; }

        /// <summary>
        /// <para>The sample result of a failed API test. This parameter is optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;apiLog&quot;: null, &quot;data&quot;: null, &quot;errCode&quot;: 1108110622, &quot;errMsg&quot;: &quot;data Source query failed&quot;, &quot;requestId&quot;: &quot;0 bc14a **** 5902762031 ****&quot;}</para>
        /// </summary>
        [NameInMap("FailResultSample")]
        [Validation(Required=false)]
        public string FailResultSample { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace Configuration page to obtain the workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The sample result of a successful API test. This parameter is optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{  &quot;data&quot;: {    &quot;totalNum&quot;: 0,    &quot;pageSize&quot;: 10,    &quot;rows&quot;: [],    &quot;pageNum&quot;: 1  },  &quot;errCode&quot;: 0,  &quot;requestId&quot;: &quot;0bc14a561678159140664515*****&quot;,  &quot;errMsg&quot;: &quot;success&quot;,  &quot;apiLog&quot;: null}</para>
        /// </summary>
        [NameInMap("ResultSample")]
        [Validation(Required=false)]
        public string ResultSample { get; set; }

    }

}
