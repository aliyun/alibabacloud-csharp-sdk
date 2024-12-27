// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateFileCompressionTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The format of the package. Default value: zip.</para>
        /// <remarks>
        /// <para> Only the ZIP format is supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>zip</para>
        /// </summary>
        [NameInMap("CompressedFormat")]
        [Validation(Required=false)]
        public string CompressedFormat { get; set; }

        /// <summary>
        /// <para><b>If you have no special requirements, leave this parameter empty.</b></para>
        /// <para>The configurations of authorization chains. For more information, see <a href="https://help.aliyun.com/document_detail/465340.html">Use authorization chains to access resources of other entities</a>.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public string CredentialConfigShrink { get; set; }

        /// <summary>
        /// <para>The notification settings. For information about the asynchronous notification format, see <a href="https://help.aliyun.com/document_detail/2743997.html">Asynchronous message examples</a>.</para>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public string NotificationShrink { get; set; }

        /// <summary>
        /// <para>The name of the project.<a href="~~478153~~"></a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>immtest</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The OSS URI of the inventory object that contains the objects to compress. The inventory object stores the objects to compress by using the same data structure of the Sources parameter in the JSON format. This parameter is suitable for specifying a large number of objects to compress.</para>
        /// <remarks>
        /// <para> You must specify this parameter or the <c>Sources</c> parameter. The <c>URI</c> parameter is required and the <c>Alias</c> parameter is optional. You can specify up to 80,000 compression rule by using SourceManifestURI in one single call to the operation. The following line provides an example of the content within an inventory object.</para>
        /// </remarks>
        /// <pre><c>[{&quot;URI&quot;:&quot;oss://&lt;bucket&gt;/&lt;object&gt;&quot;, &quot;Alias&quot;:&quot;/new-dir/new-name&quot;}]
        /// </c></pre>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-bucket/test-object.json</para>
        /// </summary>
        [NameInMap("SourceManifestURI")]
        [Validation(Required=false)]
        public string SourceManifestURI { get; set; }

        /// <summary>
        /// <para>The objects to be packed and packing rules.</para>
        /// <remarks>
        /// <para> You must specify this parameter or the SourceManifestURI parameter. The Sources parameter can hold up to 100 packing rules. If you want to include more than 100 packing rules, use the SourceManifestURI parameter.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Sources")]
        [Validation(Required=false)]
        public string SourcesShrink { get; set; }

        /// <summary>
        /// <para>The OSS URI of the package. The object name part in the URI is used as the name of the package. Example: <c>name.zip</c>.</para>
        /// <para>Specify the OSS URI in the oss://${Bucket}/${Object} format, where <c>${Bucket}</c> is the name of the bucket in the same region as the current project and <c>${Object}</c> is the path of the object with the extension included.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-bucket/test-target-object.zip</para>
        /// </summary>
        [NameInMap("TargetURI")]
        [Validation(Required=false)]
        public string TargetURI { get; set; }

        /// <summary>
        /// <para>The custom information, which is returned in an asynchronous notification and facilitates notification management. The maximum length of the value is 2,048 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ID&quot;: &quot;testuid&quot;,&quot;Name&quot;: &quot;test-user&quot;,&quot;Avatar&quot;: &quot;<a href="http://test.com/testuid%22%7D">http://test.com/testuid&quot;}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
