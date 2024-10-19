// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ExportOASRequest : TeaModel {
        /// <summary>
        /// <para>The APIs that you want to export.</para>
        /// </summary>
        [NameInMap("ApiIdList")]
        [Validation(Required=false)]
        public List<string> ApiIdList { get; set; }

        /// <summary>
        /// <para>The exported format:</para>
        /// <list type="bullet">
        /// <item><description>json</description></item>
        /// <item><description>yaml</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>yaml</para>
        /// </summary>
        [NameInMap("DataFormat")]
        [Validation(Required=false)]
        public string DataFormat { get; set; }

        /// <summary>
        /// <para>The API group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42925e7f5209438186d5560239af5xxx</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The OAS version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>oas2</b></description></item>
        /// <item><description><b>oas3</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>oas2</para>
        /// </summary>
        [NameInMap("OasVersion")]
        [Validation(Required=false)]
        public string OasVersion { get; set; }

        /// <summary>
        /// <para>The number of pages in which you want to export the APIs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The environment to which the API is published. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RELEASE</b>: the production environment</description></item>
        /// <item><description><b>PRE</b>: the pre-release environment</description></item>
        /// <item><description><b>TEST</b>: the test environment</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RELEASE</para>
        /// </summary>
        [NameInMap("StageName")]
        [Validation(Required=false)]
        public string StageName { get; set; }

        /// <summary>
        /// <para>Specifies whether to export API Gateway extensions at the same time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("WithXExtensions")]
        [Validation(Required=false)]
        public bool? WithXExtensions { get; set; }

    }

}
