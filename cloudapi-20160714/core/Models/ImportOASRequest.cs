// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ImportOASRequest : TeaModel {
        /// <summary>
        /// <para>The security authentication method of the API. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>APP: Only authorized applications can call the API.</b></para>
        /// </description></item>
        /// <item><description><para><b>ANONYMOUS: The API can be anonymously called. In this mode, you must take note of the following rules:</b></para>
        /// <list type="bullet">
        /// <item><description>All users who have obtained the API service information can call this API. API Gateway does not authenticate callers and cannot set user-specific throttling policies. If you make this API public, set API-specific throttling policies.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>APP</para>
        /// </summary>
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        /// <summary>
        /// <para>The name of the backend service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testBackendService</para>
        /// </summary>
        [NameInMap("BackendName")]
        [Validation(Required=false)]
        public string BackendName { get; set; }

        /// <summary>
        /// <para>The OAS-compliant text file or OSS object URL.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>swagger: &quot;2.0&quot;
        /// info:
        ///   version: &quot;1.0.0&quot;
        ///   title: &quot;Swagger Petstore 2.0&quot;
        /// basePath: &quot;/&quot;
        /// schemes:</para>
        /// <list type="bullet">
        /// <item><description>&quot;https&quot;</description></item>
        /// <item><description>&quot;http&quot;
        /// paths:
        /// /pet/findByStatus:
        ///   get:
        /// tags:
        /// - &quot;pet&quot;
        /// summary: &quot;Finds Pets by status&quot;
        /// operationId: &quot;findPetsByStatus&quot;
        /// parameters:
        /// - name: &quot;status&quot;
        ///   in: &quot;query&quot;
        ///   required: true
        ///   type: &quot;array&quot;
        ///   items:
        ///     type: &quot;string&quot;
        ///     enum:
        ///     - &quot;available&quot;
        ///     - &quot;pending&quot;
        ///     - &quot;sold&quot;
        ///     default: &quot;available&quot;
        ///   collectionFormat: &quot;multi&quot;
        /// responses:
        ///   &quot;200&quot;:
        ///     description: &quot;successful operation&quot;
        ///     schema:
        ///       type: &quot;array&quot;
        ///       items:
        ///         $ref: &quot;#/definitions/Pet&quot;
        ///   &quot;400&quot;:
        ///     description: &quot;Invalid status value&quot;</description></item>
        /// </list>
        /// <para>definitions:
        ///   Category:
        ///     type: &quot;object&quot;
        ///     properties:
        ///       id:
        ///         type: &quot;integer&quot;
        ///         format: &quot;int64&quot;
        ///       name:
        ///         type: &quot;string&quot;
        ///   Tag:
        ///     type: &quot;object&quot;
        ///     properties:
        ///       id:
        ///         type: &quot;integer&quot;
        ///         format: &quot;int64&quot;
        ///       name:
        ///         type: &quot;string&quot;
        ///   Pet:
        ///     type: &quot;object&quot;
        ///     required:
        ///     - &quot;name&quot;
        ///     - &quot;photoUrls&quot;
        ///     properties:
        ///       id:
        ///         type: &quot;integer&quot;
        ///         format: &quot;int64&quot;
        ///       category:
        ///         $ref: &quot;#/definitions/Category&quot;
        ///       name:
        ///         type: &quot;string&quot;
        ///         example: &quot;doggie&quot;
        ///       photoUrls:
        ///         type: &quot;array&quot;
        ///         items:
        ///           type: &quot;string&quot;
        ///       tags:
        ///         type: &quot;array&quot;
        ///         items:
        ///           $ref: &quot;#/definitions/Tag&quot;
        ///       status:
        ///         type: &quot;string&quot;
        ///         description: &quot;pet status in the store&quot;
        ///         enum:
        ///         - &quot;available&quot;
        ///         - &quot;pending&quot;
        ///         - &quot;sold&quot;</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The ID of the API group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08ae4aa0f95e4321849ee57f4e0b3077</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to ignore alerts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IgnoreWarning")]
        [Validation(Required=false)]
        public bool? IgnoreWarning { get; set; }

        /// <summary>
        /// <para>The OAS version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OAS2</para>
        /// </summary>
        [NameInMap("OASVersion")]
        [Validation(Required=false)]
        public string OASVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to overwrite an existing API.</para>
        /// <para>If an existing API has the same HTTP request type and backend request path as the API to be imported, the existing API is overwritten.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Overwrite")]
        [Validation(Required=false)]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// <para>The request mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MAPPING: Parameters are mapped. Unknown parameters are filtered out.</description></item>
        /// <item><description>PASSTHROUGH: Parameters are passed through.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PASSTHROUGH</para>
        /// </summary>
        [NameInMap("RequestMode")]
        [Validation(Required=false)]
        public string RequestMode { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to directly import the API without performing a precheck.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SkipDryRun")]
        [Validation(Required=false)]
        public bool? SkipDryRun { get; set; }

    }

}
