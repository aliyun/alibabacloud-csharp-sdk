// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ModifyAgenticSpaceRequest : TeaModel {
        /// <summary>
        /// <para>The AgenticSpace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agentic-229oypxjgpau2****</para>
        /// </summary>
        [NameInMap("AgenticSpaceId")]
        [Validation(Required=false)]
        public string AgenticSpaceId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that the value is unique among different requests.</para>
        /// <para>The client token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the RequestId of the API request as the client token. The RequestId of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the Agentic space.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Agentic Space Description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run on this request.</para>
        /// <para>A dry run checks parameter validity and verifies inventory, but does not actually create an instance or incur any fees.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: A dry run is performed and no instance is created. The system checks whether required parameters are specified, the request format, business limits, and NAS inventory. If the request fails the check, an error is returned. If the request passes the check, the HTTP status code 200 is returned, but the FileSystemId is empty.</description></item>
        /// <item><description>false (default): A normal request is sent. If the request passes the check, the instance is directly modified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the file system.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31a8e4****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

    }

}
