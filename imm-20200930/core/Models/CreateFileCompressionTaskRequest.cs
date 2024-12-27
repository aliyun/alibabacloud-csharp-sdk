// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateFileCompressionTaskRequest : TeaModel {
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
        public CredentialConfig CredentialConfig { get; set; }

        /// <summary>
        /// <para>The notification settings. For information about the asynchronous notification format, see <a href="https://help.aliyun.com/document_detail/2743997.html">Asynchronous message examples</a>.</para>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public Notification Notification { get; set; }

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
        public List<CreateFileCompressionTaskRequestSources> Sources { get; set; }
        public class CreateFileCompressionTaskRequestSources : TeaModel {
            /// <summary>
            /// <para>Specifies the path of the object in the package, or renames the object in the package.</para>
            /// <list type="bullet">
            /// <item><description>Leave this parameter empty to retain the original directory structure of the object in the package. For example, if the object is stored at <c>oss://test-bucket/test-dir/test-object.doc</c> and you do not specify this parameter, the path of the object in the package is <c>/test-dir/test-object.doc</c>.</description></item>
            /// <item><description>Rename the object. For example, if the object is stored at <c>oss://test-bucket/test-object.jpg</c> and you set the <b>Alias</b> parameter to <c>test-rename-object.jpg</c>, the name of the object in the package is <c>test-rename-object.jpg</c>.</description></item>
            /// <item><description>Specify a different path for the object in the package. For example, if the directory to be packed is <c>oss://test-bucket/test-dir/</c> and you set the <b>Alias</b> parameter to <c>/new-dir/</c>, all objects in the directory are placed in the <c>/new-dir/</c> path in the package.</description></item>
            /// <item><description>Set the parameter to <c>/</c> to remove the original directory structure.</description></item>
            /// </list>
            /// <remarks>
            /// <para> Duplicate object names may cause a failure in extracting the objects from the package, depending on the packing tool that you use. We recommend that you avoid using duplicate object names when you rename objects in the packing task.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>/new-dir/</para>
            /// </summary>
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// <para>The object matching rule. Valid values: <c>fullname</c> and <c>prefix</c>. Default value: <c>prefix</c></para>
            /// <list type="bullet">
            /// <item><description><c>prefix</c>: matches objects by object name prefix.</description></item>
            /// <item><description><c>fullname</c>: exactly matches one single object by its full object name.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>fullname</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The OSS URI of the object or directory.</para>
            /// <para>Specify the OSS URI in the oss://${Bucket}/${Object} format, where <c>${Bucket}</c> is the name of the bucket in the same region as the current project and <c>${Object}</c> is a directory or object:</para>
            /// <para>When you pack a directory, <c>${Object}</c> is the path of the directory.</para>
            /// <list type="bullet">
            /// <item><description>When you pack an object, <c>${Object}</c> is the path of the object with the extension included.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-bucket/test-object</para>
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

        }

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
